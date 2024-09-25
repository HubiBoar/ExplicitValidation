using System.Collections.Immutable;
using System.Text;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class MethodGenerator : IIncrementalGenerator
{
    private const string ResultType = "Definit.Results.IResultBase<";
    private const string TaskType = "System.Threading.Tasks.Task<";

    private record struct TypeInfo
    (
        INamedTypeSymbol Parent,
        ImmutableArray<MethodInfo> Methods
    );

    private record struct MethodInfo
    (
        string Keyword,
        MethodDeclarationSyntax Syntax,
        IMethodSymbol Symbol
    );

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (s, _) => ShouldTransform(s), 
                transform: static (ctx, _) => ctx); 

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<GeneratorSyntaxContext> syntaxes
    )
    {
        SourceHelper.Run(context, () => 
            syntaxes
                .Select(x => Transform(compilation, x))
                .Where(x => x is not null)
                .Select(x => x!.Value)
                .GroupBy(x => x.Type, SymbolEqualityComparer.Default)
                .Select(x => new TypeInfo((x.Key as INamedTypeSymbol)!, x.Select(v => v.Method).ToImmutableArray()))
                .Select<TypeInfo, Func<(string, string)>>(x => () => GetType(x))
                .ToImmutableArray());
    }

    private static (string Code, string ClassName) GetType(TypeInfo type)
    {
        var (code, info) = type.Parent.BuildTypeHierarchy
        (
            name => name,
            "Definit.Results",
            "System.Diagnostics.CodeAnalysis"
        );

        var methods = string.Join("\n\n", type.Methods.Select(method =>
        {
            var returnType = GetResultType(method.Symbol)!.Value;
            var isAsync = returnType.IsTask;
            var returnEither = returnType.Type.AllInterfaces.Single(x => x.ToDisplayString().StartsWith(ResultType)).TypeArguments.Single().ToDisplayString();
            var returnResult = returnType.Type.ToDisplayString();

            var decStatic = method.Symbol.IsStatic ? " static": string.Empty;
            var decAsync = isAsync ? " async" : string.Empty; 
            var decReturn = isAsync ? $"{TaskType}{returnEither}>" : returnEither;
            var decName = method.Symbol.Name.Remove(0, 1);

            var decGeneric = method.Symbol.GetMethodGenericArgs();
            var decGenericConstraints = method.Symbol.GetMethodGenericArguments();
            var decParameters = string.Join(", ", method.Symbol.Parameters.Select(x => x.ToDisplayString()));
            var declaration = $"{method.Keyword}{decStatic}{decAsync} {decReturn} {decName}{decGeneric}({decParameters})";

            var awaitCall = isAsync ? "await " : string.Empty;
            var parametersCall = method.Symbol.GetCallingParameters();
            var methodCall = $"{awaitCall}{method.Symbol.Name}({parametersCall})";

            return $$"""
            {{declaration}}{{decGenericConstraints.ConstraintsString}}
            {
                try
                {
                    return ResultHelper.ToReturn<{{returnResult}}, {{returnEither}}>({{methodCall}});
                }
                catch (Exception exception)
                {
                    return ResultHelper.ToReturn<{{returnResult}}, {{returnEither}}>(exception);
                }
            }
            """;
        }));

        code.AddBlock(methods);

        return (code.ToString(), info.Name);
    }

    private static readonly (string Attribute, string Keyword)[] Attributes = 
    [
        ("Definit.Results.GenerateResult.Method.PublicAttribute", "public"),
        ("Definit.Results.GenerateResult.Method.PrivateAttribute", "private"),
        ("Definit.Results.GenerateResult.Method.Public.OverrideAttribute", "public override"),
        ("Definit.Results.GenerateResult.Method.Private.OverrideAttribute", "private override"),
        ("Definit.Results.GenerateResult.Method.Public.VirtualAttribute", "public virual"),
        ("Definit.Results.GenerateResult.Method.Private.VirtualAttribute", "private virual")
    ];

    private static bool ShouldTransform(SyntaxNode node)
    {
        return node is MethodDeclarationSyntax method
            && method.Modifiers.Any(x => x.IsKind(SyntaxKind.PrivateKeyword))
            && method.AttributeLists.Count > 0 
            && node.Parent is not null
            && node.Parent is TypeDeclarationSyntax type
            && type is not null
            && type.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword));
    }

    private static (INamedTypeSymbol Type, MethodInfo Method)? Transform
    (
        Compilation compilation,
        GeneratorSyntaxContext context
    )
    {
        var parentSyntax = (TypeDeclarationSyntax)context.Node.Parent!; 
        var typeSymbol = compilation
            .GetSemanticModel(parentSyntax.SyntaxTree)
            .GetDeclaredSymbol(parentSyntax) as INamedTypeSymbol;

        var methodSyntax = (MethodDeclarationSyntax)context.Node;

        foreach (AttributeSyntax attributeSyntax in methodSyntax.AttributeLists.SelectMany(x => x.Attributes))
        {
            var attributeSymbol = (context.SemanticModel.GetSymbolInfo(attributeSyntax).Symbol as IMethodSymbol)!;

            string fullName = attributeSymbol.ContainingType.ToDisplayString();
           
            var attributes = Attributes.Where(x => x.Attribute == fullName).ToArray();
            if (attributes.Length == 1)
            {
                var attribute = attributes[0];

                var methodSymbol = (context.SemanticModel.GetDeclaredSymbol(methodSyntax) as IMethodSymbol)!;
            
                if(methodSymbol.Name.StartsWith("_") == false)
                {
                    return null;
                }

                if(GetResultType(methodSymbol) is null)
                {
                   return null;
                }

                return (typeSymbol!, new MethodInfo(attribute.Keyword, methodSyntax, methodSymbol));
            }
        }

        return null;
    }  

    private static (INamedTypeSymbol Type, bool IsTask)? GetResultType(IMethodSymbol symbol)
    {
        if((symbol.ReturnType is INamedTypeSymbol returnType) == false)
        {
            return null;
        }

        if(IsResult(returnType))
        {
            return (returnType, false);
        }
        
        if(returnType.ToDisplayString().StartsWith(TaskType) == false)
        {
            return null;
        }

        if((returnType.TypeArguments.First() is INamedTypeSymbol genericReturn) == false)
        {
            return null;
        }

        if(IsResult(genericReturn))
        {
            return (genericReturn, true);
        }

        return null;

        static bool IsResult(ITypeSymbol type)
        {
            return type.AllInterfaces.Any(x => x.ToDisplayString().StartsWith(ResultType));
        }
    }
}

