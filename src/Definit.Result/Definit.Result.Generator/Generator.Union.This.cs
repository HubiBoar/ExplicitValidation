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
        SourceHelper.Run(context, () => typeList
            .Select<INamedTypeSymbol, Func<(string, string)>>(x => () => Generate(context, x))
            .ToImmutableArray());
    }

    private static (string Code, string ClassName) Generate
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
        var wrapperName = Helper.CastingWrapperName;
        var wrapperGenericArgs = string.Empty;
        var wrapperGenericConstraints = string.Empty;

        var publicMethods = type
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

        var internalMethods = type
            .GetMembers()
            .OfType<IMethodSymbol>()
            .Where(x => 
                x.IsStatic == false 
                && x.IsExtern == false 
                && x.MethodKind == MethodKind.Ordinary
                && x.DeclaredAccessibility == Accessibility.Internal)
            .Select(x => GenerateMethod(context, x))
            .Where(x => x is not null)
            .ToArray();

        var privateMethods = type
            .GetMembers()
            .OfType<IMethodSymbol>()
            .Where(x => 
                x.IsStatic == false 
                && x.IsExtern == false 
                && x.MethodKind == MethodKind.Ordinary
                && x.DeclaredAccessibility != Accessibility.Public
                && x.DeclaredAccessibility != Accessibility.Internal)
            .Select(x => GenerateMethod(context, x))
            .Where(x => x is not null)
            .ToArray();

        var publicMethodsString = string.Join("\n\t", string.Join("\n\n", publicMethods).Split('\n'));
        var internalMethodsString = string.Join("\n\t", string.Join("\n\n", internalMethods).Split('\n'));
        var privateMethodsString = string.Join("\n\t", string.Join("\n\n", privateMethods).Split('\n'));

        code.AddBlock($$"""
        public {{wrapperName}} {{Helper.CastingMethodName}}()
        {
            return new {{wrapperName}}() { Value = this };
        }

        internal Internal{{wrapperName}} Internal{{Helper.CastingMethodName}}()
        {
            return new Internal{{wrapperName}}() { Value = this };
        }

        protected Protected{{wrapperName}} Protected{{Helper.CastingMethodName}}()
        {
            return new Protected{{wrapperName}}() { Value = this };
        }

        public readonly struct {{wrapperName}}
        {
            public required {{type.ToDisplayString()}} Value { get; init; }

            {{publicMethodsString}}
        }

        internal readonly struct Internal{{wrapperName}}
        {
            public required {{type.ToDisplayString()}} Value { get; init; }

            {{internalMethodsString}}
        }

        protected readonly struct Protected{{wrapperName}}
        {
            public required {{type.ToDisplayString()}} Value { get; init; }

            {{privateMethodsString}}
        }
        """);

        return (code.ToString(), name);
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
                public {{methodReturns}} {{name}}{{genericArguments}}({{parameters}}){{genericConstraints}} 
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
