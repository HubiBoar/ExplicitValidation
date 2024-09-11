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
        foreach(var type in typeList
            .SelectMany(x => x.Attributes
                .Where(y => y.AttributeClass is not null && y.AttributeClass!
                    .ToDisplayString()
                    .StartsWith("Definit.Results.NewApproach.GenerateObjectAttribute")) 
                .Select(x => GetType(compilation, x))))

        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    public static (string Code, string ClassName) Generate(INamedTypeSymbol type, bool allowUnsafe)
    {
        var methods = new StringBuilder();
        
        var typeName = type.Name;
        var wrapperName = $"Wrapper";
        var wrapperGenericArgs = string.Empty;
        var wrapperGenericConstraints = string.Empty;

        if(type.IsUnboundGenericType)
        {
            type = type.ConstructedFrom;
            wrapperGenericArgs = "<" + string.Join(", ", type.TypeArguments.Select(x => x.ToDisplayString())) + ">";
            wrapperName = $"{wrapperName}{wrapperGenericArgs}";
            wrapperGenericConstraints = type.TypeArguments.GetGenericConstraints();
        }

        if(type.IsGenericType)
        {
            var types = string.Join("_", type.TypeArguments.Select(x => x.ToDisplayString()));

            typeName = $"{typeName}_{types}";
        }

        var typeMethods = type
            .GetMembers()
            .OfType<IMethodSymbol>()
            .Where(x => 
                x.IsStatic == false 
                && x.IsExtern == false 
                && x.MethodKind == MethodKind.Ordinary
                && x.DeclaredAccessibility == Accessibility.Public)
            .Select(x => GenerateMethod(x, allowUnsafe))
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

        public static class {{typeName}}__Auto__Extensions
        {
            public static {{wrapperName}} Results{{wrapperGenericArgs}}(this {{type.ToDisplayString()}} value){{wrapperGenericConstraints}}
            {
                return new {{wrapperName}}() { Value = value };
            }

            public readonly struct {{wrapperName}}{{wrapperGenericConstraints}}
            {
                public required {{type.ToDisplayString()}} Value { get; init; }
                {{allMethods}}
            }
        }
        """;
        return (code, typeName);
    }

    private static (string Code, string ClassName) GetType
    (
        Compilation compilation,
        AttributeData attribute
    )
    {
        var type = (INamedTypeSymbol)attribute.ConstructorArguments.Single().Value!;
        var value = attribute.NamedArguments.SingleOrDefault(x => x.Key == "AllowUnsafe").Value.Value;
        bool allowUnsafe = value is null ? false : bool.Parse(value.ToString());

        return Generate(type, allowUnsafe);
    }

    private static string? GenerateMethod(IMethodSymbol method, bool allowUnsafe)
    {
        try
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
        catch (Exception exception)
        {
            return $"//{method.ReturnType.ToDisplayString()} :: {method.ToDisplayString()}\n// " + string.Join("\n// ", exception.ToString().Split('\n'));
        }
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

