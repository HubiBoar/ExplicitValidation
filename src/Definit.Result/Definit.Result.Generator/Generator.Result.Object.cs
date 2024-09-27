using System.Collections.Immutable;
using System.Text;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class ObjectGenerator : IIncrementalGenerator
{
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
        INamedTypeSymbol type 
    )
    {
        var wrapperName = $"Wrapper";
        var wrapperGenericArgs = string.Empty;
        var wrapperGenericConstraints = string.Empty;

        if(type.IsUnboundGenericType)
        {
            type = type.ConstructedFrom;
            var generics = type.TypeArguments.GetGenericArguments();

            wrapperGenericArgs = generics.ArgumentNamesFull;
            wrapperGenericConstraints = generics.ConstraintsString;

            wrapperName = $"{wrapperName}{wrapperGenericArgs}";
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
            .Select(x => GenerateMethod(context, x))
            .Where(x => x is not null)
            .ToArray();

        var methods = string.Join("\n\n", typeMethods); 

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

        return Generate(context, type);
    }

    public static string? GenerateMethod
    (
        SourceProductionContext context,
        IMethodSymbol method
    )
    {
        try
        {
            const string taskPrefix = "System.Threading.Tasks.Task";
            const string valueTaskPrefix = "System.Threading.Tasks.ValueTask";

            if(method.IsUnsafe() || method.Name == "ToString")
            {
                return null;
            }

            var name = method.Name;
            var parameters = string.Join(", ", method.Parameters.Select(x => x.ToDisplayString()));
            var returnType = method.GetReturnType();
            var call = string.Join(", ", method.GetCallingParameters());
            var methodCall = $"this.Value.{name}({call})";
            var generics = method.GetMethodGenericArguments();
            var genericArguments = generics.ArgumentNamesFull;
            var genericConstraints = generics.ConstraintsString;

            if(returnType is Method.Return.Void)
            {
                return Result("Error?", methodCall);
            }

            if(returnType is Method.Return.Task)
            {
                return Result($"async {taskPrefix}<Error?>", $"await {methodCall}");
            }

            if(returnType is Method.Return.ValueTask)
            {
                return Result($"async {taskPrefix}<Error?>", $"await {methodCall}");
            }

            if(returnType is Method.Return.Type type)
            {
                var returns = ToResult(type);
                return ResultInfo(returns, type.Name, returns, type.CanBeNull, methodCall);
            }

            if(returnType is Method.Return.Task.Type task)
            {
                var returns = ToResult(task);
                return ResultInfo(returns, task.Name, $"async {taskPrefix}<{returns}>", task.CanBeNull, $"await {methodCall}");
            }

            if(returnType is Method.Return.ValueTask.Type valueTask)
            {
                var returns = ToResult(valueTask);
                return ResultInfo(returns, valueTask.Name, $"async {valueTaskPrefix}<{returns}>", valueTask.CanBeNull, $"await {methodCall}");
            }

            string Result(string methodReturns, string method)
            {
                return $$"""
                public {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
                {
                    try
                    {
                        {{method}};
                        return (Error?)null;
                    }
                    catch (Exception exception)
                    {
                        return Error.Matches(exception).Error;
                    }
                }
                """;
            }

            string ResultInfo(string either, string internalType, string methodReturns, bool canBeNull, string method)
            {
                return canBeNull switch
                {
                    false => $$"""
                    public {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
                    {
                        try
                        {
                            return new {{either}}({{method}});
                        }
                        catch (Exception exception)
                        {
                            return new {{either}}(Error.Matches(exception).Error);
                        }
                    }
                    """,
                    true => $$"""
                    public {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
                    {
                        try
                        {
                            return new {{either}}(new Maybe<{{internalType}}>({{method}}));
                        }
                        catch (Exception exception)
                        {
                            return new {{either}}(Error.Matches(exception).Error);
                        }
                    }
                    """,
                };
            }

            static string ToResult(Method.IReturnInfo info)
            {
                var either = info.Symbol.GetEitherFromResult(); 

                return either ?? (info.CanBeNull ? $"Either<Maybe<{info.Name}>, Error>" : $"Either<{info.Name}, Error>");
            }

            return null;
        }
        catch (Exception exception)
        {
            var typeName = $"{method.ContainingType?.ToDisplayString()} :: " ?? string.Empty;
            var description = $"{typeName}{method.ReturnType.ToDisplayString()} :: {method.ToDisplayString()} :: {exception.ToString()}";

            return exception.ReportException(context, description);
        }
    }
}

