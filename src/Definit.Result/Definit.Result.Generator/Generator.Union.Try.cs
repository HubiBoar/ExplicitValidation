using System.Collections.Immutable;
using System.Text;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
internal sealed class UnionTryGenerator : IIncrementalGenerator
{
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
            const string taskPrefix = Helper.Async.TaskPrefix;
            const string valueTaskPrefix = Helper.Async.ValueTaskPrefix;

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
                return Returns(Helper.ReturnsVoid, methodCall);
            }

            if(returnType is Method.Return.Task)
            {
                return Returns($"async {taskPrefix}<{Helper.ReturnsVoid}>", $"await {methodCall}");
            }

            if(returnType is Method.Return.ValueTask)
            {
                return Returns($"async {taskPrefix}<{Helper.ReturnsVoid}>", $"await {methodCall}");
            }

            if(returnType is Method.Return.Type type)
            {
                return ReturnsInfo(type, null, methodCall);
            }

            if(returnType is Method.Return.Task.Type task)
            {
                return ReturnsInfo(task, taskPrefix, $"await {methodCall}");
            }

            if(returnType is Method.Return.ValueTask.Type valueTask)
            {
                return ReturnsInfo(valueTask, valueTaskPrefix, $"await {methodCall}");
            }

            string Returns(string methodReturns, string method)
            {
                return $$"""
                public {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
                {
                    try
                    {
                        {{method}};
                        return {{Helper.ReturnsVoidSuccess}};
                    }
                    catch (Exception exception)
                    {
                        return exception;
                    }
                }
                """;
            }

            string ReturnsInfo
            (
                Method.IReturnInfo info,
                string? taskPrefix,
                string method
            )
            {
                var isUnion = Helper.IsUnion(info.Symbol); 

                return (isUnion is null) switch
                {   
                    true => ReturnsNotUnion(info, taskPrefix, method),
                    false => ReturnsUnion(info, isUnion, taskPrefix, method)
                };
            }

            string ReturnsUnion
            (
                Method.IReturnInfo info,
                INamedTypeSymbol union,
                string? taskPrefix,
                string method
            )
            {
                var unionArgs = string.Join(", ", union.TypeArguments
                    .Select(x => x.ToDisplayString())
                    .Where(x => x != Helper.Error)
                    .Concat([Helper.Error]));

                var unionReturns = $"{Helper.TypeName}<{unionArgs}>";
                var methodReturns = taskPrefix is null ? unionReturns : $"async {taskPrefix}<{unionReturns}>";

                StringBuilder callMethod = new();

                var methodArgs = union.TypeArguments.Select((x, i) => (Name: $"_arg_{i}", Type: x.ToDisplayString())).ToArray();
                callMethod.AppendLine("var (" + string.Join(", ", methodArgs.Select(x => x.Name)) + $") = {method};"); 

                foreach(var arg in methodArgs)
                {
                    callMethod.AppendLine($$"""

                            if ({{arg.Name}} is not null)
                            {
                                return ({{arg.Type}}){{arg.Name}};
                            }
                    """);
                }

                return $$"""
                public {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
                {
                    try
                    {
                        {{callMethod}}
                        
                        return new {{Helper.UnionMatchError}}();
                    }
                    catch (Exception exception)
                    {
                        return exception;
                    }
                }
                """;
            }

            string ReturnsNotUnion
            (
                Method.IReturnInfo info,
                string? taskPrefix,
                string method
            )
            {
                var union = info.CanBeNull
                    ? 
                    Helper.UnionMaybeError(info.Name)
                    : 
                    Helper.UnionError(info.Name);

                var methodReturns = taskPrefix is null ? union : $"async {taskPrefix}<{union}>";

                var callMethod = info.CanBeNull
                    ?
                    $"new {Helper.Maybe(info.Name)}({method})"
                    :
                    method;


                return $$"""
                public {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
                {
                    try
                    {
                        return {{callMethod}};
                    }
                    catch (Exception exception)
                    {
                        return exception;
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
