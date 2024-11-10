using System.Collections.Immutable;
using System.Text;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class ThisGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            Helper.Attributes.GenerateUnionThisMeta,
            predicate: (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: (n, _) => (n.TargetSymbol as INamedTypeSymbol)!
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<INamedTypeSymbol> typeList
    )
    {
        SourceHelper.RunNullable(context, () => typeList
            .Select<INamedTypeSymbol, Func<(string, string)?>>(x => () => Generate(context, x))
            .ToImmutableArray());
    }

    private static (string Code, string ClassName)? Generate
    (
        SourceProductionContext context,
        INamedTypeSymbol type 
    )
    {
        var (code, info) = type.BuildTypeHierarchy
        (
            name => name,
            Helper.Namespace,
            "System.Diagnostics.CodeAnalysis"
        );

        var name = info.Name;
        var wrapperGenericArgs = string.Empty;
        var wrapperGenericConstraints = string.Empty;

        var publicMethods = GetMethodsPublic(context, type);
        var internalMethods = GetMethods(context, type, Accessibility.Internal);
        var protectedMethods = GetMethods(context, type, Accessibility.Protected);
        var privateMethods = GetMethods(context, type, Accessibility.Private);

        if(publicMethods is null && internalMethods is null && protectedMethods is null && privateMethods is null)
        {
            return null;
        }

        var wrapperBuilder = new StringBuilder();

        if (publicMethods is not null)
        {
            wrapperBuilder.AppendLine(publicMethods);
        }

        if (internalMethods is not null)
        {
            wrapperBuilder.AppendLine(internalMethods);
        }

        if (protectedMethods is not null)
        {
            wrapperBuilder.AppendLine(protectedMethods);
        }

        if (privateMethods is not null)
        {
            wrapperBuilder.AppendLine(privateMethods);
        }

        var typeName = type.ToDisplayString();
        code.AddBlock(wrapperBuilder.ToString());

        return (code.ToString(), name);
    }

    private static ImmutableArray<string> GetMethodsList
    (
        SourceProductionContext context,
        INamedTypeSymbol type,
        Accessibility declaredAccessibility,
        Func<string, string> overrideName
    )
    {
        var prefix = declaredAccessibility.ToString().ToLower();

        var methods = type
            .GetMembers()
            .OfType<IMethodSymbol>()
            .Where(x => 
                x.IsStatic == false 
                && x.IsExtern == false 
                && x.MethodKind == MethodKind.Ordinary
                && x.DeclaredAccessibility == declaredAccessibility)
            .Select(x => GenerateMethod(context, x, prefix, overrideName))
            .Where(x => x is not null)
            .Select(x => x!)
            .ToImmutableArray();

        return methods;
    }

    private static string? GetMethodsPublic
    (
        SourceProductionContext context,
        INamedTypeSymbol type
    )
    {
        var methods = GetMethodsList(context, type, Accessibility.Public, str => str);

        if (methods.Length == 0)
        {
            return null;
        }

        var typeName = type.ToDisplayString();
        var wrapperName = Helper.CastingWrapperName;
        var methodsString = string.Join("\n\t", string.Join("\n\n", methods).Split('\n'));

        return $$"""

        public {{wrapperName}} {{Helper.CastingMethodName}}() => new {{wrapperName}}(this);

        public readonly struct {{wrapperName}}
        {
            private {{typeName}} Value { get; }

            public {{wrapperName}}({{typeName}} value) { Value = value; }

            {{methodsString}}
        }
        """;
    }

    private static string? GetMethods
    (
        SourceProductionContext context,
        INamedTypeSymbol type,
        Accessibility declaredAccessibility
    )
    {
        var methods = GetMethodsList(context, type, declaredAccessibility, str => $"{str}_{Helper.CastingMethodName}");

        if (methods.Length == 0)
        {
            return null;
        }

        var methodsString = string.Join("\n", string.Join("\n\n", methods).Split('\n'));

        return methodsString;
    }

    public static string? GenerateMethod
    (
        SourceProductionContext context,
        IMethodSymbol method,
        string prefix,
        Func<string, string> overrideName
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

            var name = overrideName(method.Name);
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
                {{prefix}} {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
                {
                    try
                    {
                        {{method}};
                        return {{Helper.SuccessInstance}};
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
                {{prefix}} {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
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
                    Helper.ResultError(info.Name);

                var methodReturns = taskPrefix is null ? union : $"async {taskPrefix}<{union}>";

                var callMethod = info.CanBeNull
                    ?
                    $"new {Helper.Maybe(info.Name)}({method})"
                    :
                    method;


                return $$"""
                {{prefix}} {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
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
