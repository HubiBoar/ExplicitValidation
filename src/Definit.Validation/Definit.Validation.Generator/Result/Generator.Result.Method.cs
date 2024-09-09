using System.Collections.Immutable;
using System.Text;
using Definit.Validation.Generator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class MethodGenerator : IIncrementalGenerator
{
    private record struct TypeInfo
    (
        TypeDeclarationSyntax Parent,
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
                transform: static (ctx, _) => Transform(ctx)) 
            .Where(static m => m is not null)
            .Select(static (x, _) => x!.Value);

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<(TypeDeclarationSyntax Type, MethodInfo Method)> typeList
    )
    {
        var types = typeList
            .GroupBy(x => x.Type)
            .Select(x => new TypeInfo(x.Key, x.Select(v => v.Method).ToImmutableArray()))
            .ToArray();

        foreach(var type in types.Select(x => GetType(x)))
        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    private static (string Code, string ClassName) GetType(TypeInfo type)
    {
        var (code, typeInfo) = type.Parent.BuildTypeHierarchy
        (
            name => name,
            "Definit.Results",
            "Definit.Validation",
            "System.Diagnostics.CodeAnalysis"
        );

        var builder = new StringBuilder();

        foreach(var method in type.Methods)
        {
            builder.AppendLine().Append($$"""
            keyword: {{method.Keyword}}
            displayString: {{method.Symbol.ToDisplayString()}}
            params: {{string.Join(", ", method.Symbol.Parameters.Select(x => x.ToDisplayString()))}}
            typeParams: {{string.Join(", ", method.Symbol.TypeParameters.Select(x => x.ToDisplayString()))}}
            typeArgs: {{string.Join(", ", method.Symbol.TypeArguments.Select(x => x.ToDisplayString()))}}
            parts: {{string.Join(", ", method.Symbol.ToDisplayParts().Select(x => x.Symbol?.ToDisplayString()))}}
            return: {{method.Symbol.ReturnType.ToDisplayString()}}
            name: {{method.Symbol.Name}}
            modifiers: {{string.Join(", ", method.Syntax.Modifiers.Select(x => x.Value?.ToString()))}}
            modifiers: {{string.Join(", ", method.Syntax.Modifiers.Select(x => x.ToFullString()))}}
            """);
        }

        code.AddBlock(builder.ToString());

        return (code.ToString(), typeInfo.FullName);
    }

    private static readonly (string Attribute, string Keyword)[] Attributes = 
    [
        ("Definit.Results.NewApproach.GenerateMethod.PublicAttribute", "public"),
        ("Definit.Results.NewApproach.GenerateMethod.PrivateAttribute", "private")
    ];

    private static bool ShouldTransform(SyntaxNode node)
    {
        return node is MethodDeclarationSyntax method
            && method.AttributeLists.Count > 0 
            && node.Parent is not null
            && node.Parent is TypeDeclarationSyntax type
            && type is not null
            && type.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword));
    }

    private static (TypeDeclarationSyntax Type, MethodInfo Method)? Transform
    (
        GeneratorSyntaxContext context
    )
    {
        var typeSyntax = (TypeDeclarationSyntax)context.Node.Parent!; 

        var methodSyntax = (MethodDeclarationSyntax)context.Node;

        var methodSymbol = (context.SemanticModel.GetDeclaredSymbol(methodSyntax) as IMethodSymbol)!;

        if(methodSymbol.Name.StartsWith("_") == false)
        {
            return null;
        }

        foreach (AttributeSyntax attributeSyntax in methodSyntax.AttributeLists.SelectMany(x => x.Attributes))
        {
            var attributeSymbol = (context.SemanticModel.GetSymbolInfo(attributeSyntax).Symbol as IMethodSymbol)!;

            string fullName = attributeSymbol.ContainingType.ToDisplayString();
           
            var attributes = Attributes.Where(x => x.Attribute == fullName).ToArray();
            if (attributes.Length == 1)
            {
                var attribute = attributes[0];
                
                return (typeSyntax, new MethodInfo(attribute.Keyword, methodSyntax, methodSymbol));
            }
        }

        return null;
    }  
}

