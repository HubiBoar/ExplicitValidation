using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class ObjectGenerator : IIncrementalGenerator
{
    private const string ResultType = "Definit.Results.IResultBase";
    private const string TaskType = "System.Threading.Tasks.Task";
    private const string ValueTaskType = "System.Threading.Tasks.ValueTask";
    private const string Success = "Definit.Results.Success";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.GenerateResult+ObjectAttribute",
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
                    .ToDisplayString() == "Definit.Results.GenerateResult.ObjectAttribute") 
                .Select(x => GetType(context, compilation, x))))

        {
            context.AddSource($"{type.ClassName}.g.cs", type.Code);
        }
    }

    public static (string Code, string ClassName) Generate
    (
        SourceProductionContext context,
        INamedTypeSymbol type, 
        bool allowUnsafe
    )
    {
        var methods = new StringBuilder();
        
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

        var typeName = type.Name;
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
            .Select(x => GenerateMethod(context, x, type.ToDisplayString(), allowUnsafe))
            .Where(x => x is not null)
            .ToArray();

        foreach(var method in typeMethods) 
        {
            methods.AppendLine(method);
        }

        var allMethods = string.Join("\n\t\t", methods.ToString().Split('\n'));

        var code = $$"""
        #nullable enable

        using Definit.Results;
        using System.Diagnostics.CodeAnalysis;

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

        var name = type
            .ToDisplayString()
            .Replace("<", "_")
            .Replace(">", "")
            .Replace(", ", "_")
            .Replace(" ", "_")
            .Replace(",", "_");

        return (code, name);
    }

    private static (string Code, string ClassName) GetType
    (
        SourceProductionContext context,
        Compilation compilation,
        AttributeData attribute
    )
    {
        var type = (INamedTypeSymbol)attribute.ConstructorArguments.Single().Value!;
        var value = attribute.NamedArguments.SingleOrDefault(x => x.Key == "AllowUnsafe").Value.Value;
        bool allowUnsafe = value is null ? false : bool.Parse(value.ToString());

        return Generate(context, type, allowUnsafe);
    }

    private static string? GenerateMethod
    (
        SourceProductionContext context,
        IMethodSymbol method,
        string typeName, 
        bool allowUnsafe
    )
    {
        try
        {
            var result = GetReturnType(method); 
            if(result is null)
            {
                return null;
            }

            var (returnType, returnsSuccess, taskPrefix) = result.Value;

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
            var returnCall = returnsSuccess ? 
            $"""
            {methodCall};
            return new {returnType}(Result.Success);
            """
            :
            $"return new {returnType}(({methodCall})!);";

            returnCall = string.Join("\n\t\t", returnCall.Split('\n'));

            var returnDeclaration = isAsync ? $"async {taskPrefix}<{returnType}>" : $"{returnType}";

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
                    return new {{returnType}}(Error.Matches(exception).Error);
                }
            }
            """;
        }
        catch (Exception exception)
        {
            var description = $"{method.ReturnType.ToDisplayString()} {method.ToDisplayString()} {exception.ToString()}";
            var desc = new DiagnosticDescriptor
            (
                "ROG0001",
                "Exception on method creation",
                description,
                "Error",
                DiagnosticSeverity.Error,
                true
            );
            
            context.ReportDiagnostic(Diagnostic.Create(desc, Location.None));
            return $"// EXCEPTION\n// {string.Join("\n// ", description.Split('\n'))}";
        }
    }

    private static (string ReturnType, bool ReturnsSuccess, string? TaskPrefix)? GetReturnType(IMethodSymbol method)
    {
        if(method.ReturnsVoid)
        {
            return ($"Either<Success, Error>", true, null);
        }

        if(IsResult(method.ReturnType))
        {
            return null;
        }

        var returnName = method.ReturnType.ToDisplayString(); 
        var isTask = returnName.StartsWith(TaskType);
        var isValueTask = returnName.StartsWith(ValueTaskType);

        if(isTask is false && isValueTask is false)
        {
            return ($"Either<{returnName}, Error>", false, null);
        }

        var taskPrefix = isTask ? "Task" : "ValueTask";

        var typeSymbol = (method.ReturnType as INamedTypeSymbol)!;  

        if(typeSymbol.IsGenericType == false)
        {
            return ($"Either<Success, Error>", true, taskPrefix);
        }

        var taskSymbol = typeSymbol.TypeArguments.Single();

        if(IsResult(taskSymbol))
        {
            return null;
        }

        returnName = taskSymbol.ToDisplayString();

        return ($"Either<{returnName}, Error>", false, taskPrefix);

        static bool IsResult(ITypeSymbol type)
        {
            return type.AllInterfaces.Any(x => x.ToDisplayString().StartsWith(ResultType));
        }
    }
}

