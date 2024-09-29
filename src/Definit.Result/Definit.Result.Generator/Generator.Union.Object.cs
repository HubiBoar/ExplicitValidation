using System.Collections.Immutable;
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
            Helper.Attributes.GenerateUnionObjectMeta,

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
                    .ToDisplayString() == Helper.Attributes.GenerateUnionObject)
                .Select<AttributeData, Func<(string, string)>>(x => () => GetType(context, compilation, x)))
                .ToImmutableArray());
    }

    public static (string Code, string ClassName) Generate
    (
        SourceProductionContext context,
        INamedTypeSymbol type 
    )
    {
        var wrapperName = Helper.CastingWrapperName;
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

        using {{Helper.Namespace}};
        using System.Diagnostics.CodeAnalysis;

        namespace {{type.ContainingNamespace.ToDisplayString()}};

        public static class {{Helper.ExtensionsTypeName(typeName)}}
        {
            public static {{wrapperName}} {{Helper.CastingMethodName}}{{wrapperGenericArgs}}(this {{type.ToDisplayString()}} value){{wrapperGenericConstraints}}
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

        return (code, type.ToDisplayString());
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
                return Returns(Helper.TypeName, methodCall);
            }

            if(returnType is Method.Return.Task)
            {
                return Returns($"async {taskPrefix}<{Helper.TypeName}>", $"await {methodCall}");
            }

            if(returnType is Method.Return.ValueTask)
            {
                return Returns($"async {taskPrefix}<{Helper.TypeName}>", $"await {methodCall}");
            }

            if(returnType is Method.Return.Type type)
            {
                return ReturnsInfo(type, null);
            }

            if(returnType is Method.Return.Task.Type task)
            {
                return ReturnsInfo(task, taskPrefix);
            }

            if(returnType is Method.Return.ValueTask.Type valueTask)
            {
                return ReturnsInfo(valueTask, valueTaskPrefix);
            }

            string Returns(string methodReturns, string method)
            {
                return $$"""
                public {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
                {
                    try
                    {
                        {{method}};
                        return {{Helper.Types.SuccessInstance}};
                    }
                    catch (Exception exception)
                    {
                        return Error.Matches(exception).Error;
                    }
                }
                """;
            }

            string ReturnsInfo
            (
                Method.IReturnInfo info,
                string? taskPrefix
            )
            {
                var isUnion = Helper.IsUnion(info.Symbol); 

                var union = (isUnion is null) switch
                {   
                    true => 
                        info.CanBeNull
                        ? 
                        Helper.Types.UnionMaybeError(info.Name)
                        : 
                        Helper.Types.UnionError(info.Name),
                    false =>
                        isUnion.Value.Name
                };

                var methodReturns = taskPrefix is null ? union : $"async {taskPrefix}<{union}>";
                
                return $$"""
                    public {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
                    {
                        try
                        {
                            return new {{union}}({{method}});
                        }
                        catch (Exception exception)
                        {
                            return new {{union}}(Error.Matches(exception).Error);
                        }
                    }
                """;
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

