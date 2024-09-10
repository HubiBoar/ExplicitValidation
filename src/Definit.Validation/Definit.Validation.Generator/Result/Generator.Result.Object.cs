using System.Collections.Immutable;
using System.Text;
using Definit.Validation.Generator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
            "Definit.Results.NewApproach.GenerateObjectAttribute`1",
            predicate: (c, _) => true,
                // c is TypeDeclarationSyntax type
                // && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

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
        foreach(var type in typeList.Select(x => GetType(x)))
        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    private static (string Code, string ClassName) GetType
    (
        GeneratorAttributeSyntaxContext context
    )
    {
        var type = context.Attributes.Single().AttributeClass!.TypeArguments.Single();

        var methods = new StringBuilder();

        var typeMethods = type
            .GetMembers()
            .OfType<IMethodSymbol>()
            .Where(x => 
                x.IsStatic == false 
                && x.IsExtern == false 
                && x.MethodKind == MethodKind.Ordinary
                && x.DeclaredAccessibility == Accessibility.Public)
            .Select(x => GenerateMethod(x, $"Wrapper"))
            .Where(x => x is not null)
            .ToArray();

        foreach(var method in typeMethods) 
        {
            methods.AppendLine(method);
        }

        var allMethods = string.Join("\n\t", methods.ToString().Split('\n'));

        var code = $$"""
        #nullable enable

        using Definit.Results.NewApproach;

        namespace {{type.ContainingNamespace.ToDisplayString()}};

        public static class {{type.Name}}__Auto__Extensions
        {
            public readonly struct Wrapper
            {
                public required {{type.ToDisplayString()}} Value { get; init; }
            }

            public static Wrapper Results(this {{type.ToDisplayString()}} value)
            {
                return new Wrapper() { Value = value };
            }
            {{allMethods}}
        }
        """;
        return (code, "Objects");


    }

    private static string? GenerateMethod(IMethodSymbol method, string typeName)
    {
        var (returnType, nullable, taskPrefix, isResult) = GetReturnType(method); 

        const string wrapper = "_wrapper";

        if(isResult)
        {
            return null;
        }

        var isAsync = taskPrefix is not null;
        var parameters = method.Parameters.Length > 0 ? $", {string.Join(", ", method.Parameters.Select(x => x.ToDisplayString()))}" : "";

        var awaitCall = isAsync ? "await " : "";
        var methodCall = $"{awaitCall}{wrapper}.Value.{method.Name}({string.Join(", ", method.Parameters.Select(x => x.Name))})";
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

        return $$"""

        public static {{returnDeclaration}} {{method.Name}}(this {{typeName}} {{wrapper}}{{parameters}})
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

