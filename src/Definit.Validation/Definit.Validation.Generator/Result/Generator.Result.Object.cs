using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class ObjectGenerator : IIncrementalGenerator
{
    private const string ResultType = "Definit.Results.NewApproach.IResult";
    private const string TaskType = "System.Threading.Tasks.Task";
    private const string ValueTaskType = "System.Threading.Tasks.ValueTask";
    private const string Success = "Definit.Results.NewApproach.Success";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.NewApproach.GenerateObjectAttribute",
            predicate: (c, _) => true,

            transform: (n, _) => n
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<GeneratorAttributeSyntaxContext> typeList
    )
    {
        foreach(var type in typeList.Select(x => GetType(compilation, x)))
        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    public static (string Code, string ClassName) Generate(ITypeSymbol type, bool allowUnsafe)
    {
        var methods = new StringBuilder();

        var typeMethods = type
            .GetMembers()
            .OfType<IMethodSymbol>()
            .Where(x => 
                x.IsStatic == false 
                && x.IsExtern == false 
                && x.MethodKind == MethodKind.Ordinary
                && x.DeclaredAccessibility == Accessibility.Public)
            .Select(x => GenerateMethod(x, $"Wrapper", allowUnsafe))
            .Where(x => x is not null)
            .ToArray();

        foreach(var method in typeMethods) 
        {
            methods.AppendLine(method);
        }

        var allMethods = string.Join("\n\t\t", methods.ToString().Split('\n'));

        var code = $$"""
        #nullable enable

        using Definit.Results.NewApproach;

        namespace {{type.ContainingNamespace.ToDisplayString()}};

        public static class {{type.Name}}__Auto__Extensions
        {
            public static Wrapper Results(this {{type.ToDisplayString()}} value)
            {
                return new Wrapper() { Value = value };
            }

            public readonly struct Wrapper
            {
                public required {{type.ToDisplayString()}} Value { get; init; }
                {{allMethods}}
            }
        }
        """;
        return (code, type.Name);
    }

    private static (string Code, string ClassName) GetType
    (
        Compilation compilation,
        GeneratorAttributeSyntaxContext context
    )
    {
        var typeInAttribute = context.Attributes.Single().ConstructorArguments.Single().Value!;
        var value = context.Attributes.Single().NamedArguments.SingleOrDefault(x => x.Key == "AllowUnsafe").Value.Value;
        bool allowUnsafe = value is null ? false : bool.Parse(value.ToString());
        var type = compilation.GetTypeByMetadataName(typeInAttribute.ToString())!;

        return Generate(type, allowUnsafe);
    }

    private static string? GenerateMethod(IMethodSymbol method, string typeName, bool allowUnsafe)
    {
        var (returnType, nullable, taskPrefix, isResult) = GetReturnType(method); 

        if(isResult)
        {
            return null;
        }

        var isUnsafe = method.IsUnsafe();

        if(allowUnsafe == false && isUnsafe)
        {
            return null;
        }

        var isAsync = taskPrefix is not null;
        var parameters = string.Join(", ", method.Parameters.Select(x => x.ToDisplayString()));

        var decGeneric = method.GetMethodGenericArgs();
        var decGenericConstraints = method.GetMethodGenericConstraints();

        var parametersCall = method.GetCallingParameters();
        var awaitCall = isAsync ? "await " : "";
        var methodCall = $"{awaitCall}this.Value.{method.Name}({string.Join(", ", parametersCall)})";
        var returnCall = method.ReturnsVoid ? 
        $"""
                {methodCall};
                return new {returnType}.Value(new {returnType}(Result.Success));
        """
        :
        nullable ?
        $$"""
                var _call_result = {{methodCall}};

                if(_call_result is null)
                {
                    return new {{returnType}}.Value(new {{returnType}}(Result.Null));
                }

                return new {{returnType}}.Value(new {{returnType}}(_call_result));
        """
        :
        $"""
                return new {returnType}.Value(new {returnType}({methodCall}));
        """;

        var returnDeclaration = isAsync ? $"async {taskPrefix}<{returnType}.Value>" : $"{returnType}.Value";

        var decNew = method.Name == "ToString" && method.Parameters.Length == 0 ? "new " : "";
        var decUnsafe = isUnsafe ? "unsafe " : "";

        return $$"""

        public {{decUnsafe}}{{decNew}}{{returnDeclaration}} {{method.Name}}{{decGeneric}}({{parameters}}){{decGenericConstraints}}
        {
            try
            {
        {{returnCall}}
            }
            catch (Exception exception)
            {
                return new {{returnType}}.Value(new {{returnType}}(Error.Create(exception)));
            }
        }
        """;
    }

    private static (string ReturnType, bool nullable, string? TaskPrefix, bool IsResult) GetReturnType(IMethodSymbol method)
    {
        bool nullable = false;
        if(method.ReturnsVoid)
        {
            return ($"Result<Success, Error>", nullable, null, false);
        }

        var returnName = method.ReturnType.ToDisplayString(); 
        var isTask = returnName.StartsWith(TaskType);
        var isValueTask = returnName.StartsWith(ValueTaskType);

        var typeSymbol = (method.ReturnType as INamedTypeSymbol)!;

        if(isTask is false && isValueTask is false)
        {
            if(typeSymbol.NullableAnnotation is NullableAnnotation.Annotated)
            {
                returnName = typeSymbol.WithNullableAnnotation(NullableAnnotation.NotAnnotated).ToDisplayString();
                returnName = $"{returnName}, Null";
                nullable = true;
            }

            return ($"Result<{returnName}, Error>", nullable, null, IsResult(typeSymbol));
        }

        var taskPrefix = isTask ? "Task" : "ValueTask";

        if(typeSymbol.IsGenericType == false)
        {
            return ($"Result<Success, Error>", nullable, taskPrefix, false);
        }

        var taskSymbol = (typeSymbol.TypeArguments.Single() as INamedTypeSymbol)!;

        returnName = taskSymbol.ToDisplayString();

        if(taskSymbol.NullableAnnotation is NullableAnnotation.Annotated)
        {
            returnName = taskSymbol.WithNullableAnnotation(NullableAnnotation.NotAnnotated).ToDisplayString();
            returnName = $"{returnName}, Null";
            nullable = true;
        }
        return ($"Result<{returnName}, Error>", nullable, taskPrefix, IsResult(taskSymbol));

        static bool IsResult(ITypeSymbol type)
        {
            return type.AllInterfaces.Any(x => x.ToDisplayString().StartsWith(ResultType));
        }
    }

}

