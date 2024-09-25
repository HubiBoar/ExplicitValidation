using System.Collections.Immutable;
using System.Text;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class ObjectGenerator : IIncrementalGenerator
{
    private const string ResultType = "Definit.Results.IResultBase";
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
        SourceHelper.Run(context, () => 
            typeList
            .SelectMany(x => x.Attributes
                .Where(y => y.AttributeClass is not null && y.AttributeClass!
                    .ToDisplayString() == "Definit.Results.GenerateResult.ObjectAttribute") 
                .Select<AttributeData, Func<(string, string)>>(x => () => GetType(context, compilation, x)))
                .ToImmutableArray());
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
            wrapperGenericConstraints = type.TypeArguments.GetGenericArguments().ConstraintsString;
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
        const string TaskPrefix = "System.Threading.Tasks.Task";
        const string ValueTaskPrefix = "System.Threading.Tasks.ValueTask";

        try
        {
            var (returnType, internalType, returns, task) = GetReturnType(method); 

            var isUnsafe = method.IsUnsafe();

            if(allowUnsafe == false && isUnsafe)
            {
                return null;
            }

            var isAsync = task is not Task.None;
            var taskPrefix = task switch
            {
                Task.ValueTask => ValueTaskPrefix,
                Task.Task => TaskPrefix,
                _ => string.Empty
            };

            var parameters = string.Join(", ", method.Parameters.Select(x => x.ToDisplayString()));

            var decGeneric = method.GetMethodGenericArgs();
            var decGenericConstraints = method.GetMethodGenericArguments();

            var parametersCall = method.GetCallingParameters();
            var awaitCall = isAsync ? "await " : "";
            var methodCall = $"{awaitCall}this.Value.{method.Name}({string.Join(", ", parametersCall)})";
            var returnCall = returns switch
            {
                Returns.Success =>

                $$"""
                try
                {
                    {{methodCall}};
                    return (Error?)null;
                }
                catch (Exception exception)
                {
                    return Error.Matches(exception).Error;
                }
                """, 

                Returns.Maybe => 

                $$"""
                try
                {
                    {{internalType}} method_result = {{methodCall}};
                    var maybe_result = new Maybe<{{internalType}}>(method_result); 

                    return new {{returnType}}(maybe_result);
                }
                catch (Exception exception)
                {
                    return new {{returnType}}(Error.Matches(exception).Error);
                }
                """,

                _ => $$"""
                try
                {
                    return new {{returnType}}(({{methodCall}})!);
                }
                catch (Exception exception)
                {
                    return new {{returnType}}(Error.Matches(exception).Error);
                }
                """,
            };

            returnCall = string.Join("\n\t", returnCall.Split('\n'));
            var returnDeclaration = isAsync ? $"async {taskPrefix}<{returnType}>" : $"{returnType}";

            var decNew = method.Name == "ToString" && method.Parameters.Length == 0 ? "new " : "";
            var decUnsafe = isUnsafe ? "unsafe " : "";

            return $$"""

            public {{decUnsafe}}{{decNew}}{{returnDeclaration}} {{method.Name}}{{decGeneric}}({{parameters}}){{decGenericConstraints.ConstraintsString}}
            {
                {{returnCall}}
            }
            """;
        }
        catch (Exception exception)
        {
            var description = $"{method.ReturnType.ToDisplayString()} {method.ToDisplayString()} {exception.ToString()}";

            return exception.ReportException(context, description);
        }
    }

    private enum Task
    {
        None,
        Task,
        ValueTask
    }

    private enum Returns
    {
        Success,
        Maybe,
        Type
    }

    private static (string ReturnType, string? InternalType, Returns Returns, Task Async) GetReturnType(IMethodSymbol method)
    {
        const string success = "Error?";

        var returnType = method.GetReturnType();
        if(returnType is Method.Return.Void)
        {
            return (success, null, Returns.Success, Task.None);
        }

        if(returnType is Method.Return.Type type)
        {
            var (name, returns) = ToResult(type);
            return (name, type.Name, returns, Task.None);
        }

        if(returnType is Method.Return.Task)
        {
            return (success, null, Returns.Success, Task.Task);
        }

        if(returnType is Method.Return.ValueTask)
        {
            return (success, null, Returns.Success, Task.ValueTask);
        }

        if(returnType is Method.Return.Task.Type task)
        {
            var (name, returns) = ToResult(task);
            return (name, task.Name, returns, Task.Task);
        }

        if(returnType is Method.Return.ValueTask.Type valueTask)
        {
            var (name, returns) = ToResult(valueTask);
            return (name, valueTask.Name, returns, Task.ValueTask);
        }

        static (string Name, Returns Returns) ToResult(Method.IReturnInfo info)
        {
            var name = info.CanBeNull ? $"Either<Maybe<{info.Name}>, Error>" : $"Either<{info.Name}, Error>";
            var returns = info.CanBeNull ? Returns.Maybe : Returns.Type;
            if(info.Symbol is INamedTypeSymbol type)
            {
                var either = type.AllInterfaces.SingleOrDefault(x => x.ToDisplayString().StartsWith(ResultType))
                    ?.TypeArguments
                    .Single()
                    .ToDisplayString()
                    ??
                    name;

                return (either, returns); 
            }

            return (name, returns); 
        }

        throw new ArgumentOutOfRangeException();
    }
}

