using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Utils.SourceGenerator;

public static class Helper
{
    public record struct Object
    (
        TypeDeclarationSyntax Type,
        GeneratorAttributeSyntaxContext Attribute,
        ITypeSymbol Symbol
    );

    public record struct Value
    (
        TypeDeclarationSyntax Type,
        GeneratorAttributeSyntaxContext Attribute,
        ITypeSymbol Symbol,
        ITypeSymbol GenericType
    );

    public const string IsValidName            = "Definit.Validation.IIsValid";
    private const string IsValidValueAttribute = "Definit.Validation.IsValidAttribute`1";
    private const string IsValidAttribute      = "Definit.Validation.IsValidAttribute";

    public static void RunIsValidValue
    (
        IncrementalGeneratorInitializationContext context,
        Action<SourceProductionContext, Compilation, ImmutableArray<Value>> execute
    )
    {
        Run
        (
            IsValidValueAttribute,
            context,
            type => type.Modifiers.Any(x => x.IsKind(SyntaxKind.ReadOnlyKeyword)), 
            (s, c, v) =>
            {
                var values = v
                    .Select(x => new Value(x.Type, x.Attribute, GetTypeSymbol(c, x.Type), GetTypeSymbol(x.Attribute)))
                    .DistinctBy(x => x.Symbol.ToDisplayString())
                    .ToImmutableArray();

                execute(s, c, values);
            }
        );
    }

    public static void RunIsValid
    (
        IncrementalGeneratorInitializationContext context,
        Action<SourceProductionContext, Compilation, ImmutableArray<Object>> execute
    )
    {
        Run
        (
            IsValidAttribute,
            context,
            kind => true, 
            (s, c, v) =>
            {
                var values = v
                    .Select(x => new Object(x.Type, x.Attribute, GetTypeSymbol(c, x.Type)))
                    .DistinctBy(x => x.Symbol.ToDisplayString())
                    .ToImmutableArray();

                execute(s, c, values);
            }
        );
    }

    private static ITypeSymbol GetTypeSymbol(GeneratorAttributeSyntaxContext attribute)
    {
        return attribute.Attributes.Single().AttributeClass!.TypeArguments.Single();
    }

    private static ITypeSymbol GetTypeSymbol(Compilation compilation, TypeDeclarationSyntax type)
    {
        return (compilation.GetSemanticModel(type.SyntaxTree).GetDeclaredSymbol(type) as ITypeSymbol)!;
    }

    private static void Run
    (
        string attributeName,
        IncrementalGeneratorInitializationContext context,
        Func<TypeDeclarationSyntax, bool> preficdate,
        Action<SourceProductionContext, Compilation, ImmutableArray<(TypeDeclarationSyntax Type, GeneratorAttributeSyntaxContext Attribute)>> execute
    )
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            attributeName,
            predicate: (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword))
                && preficdate(type),

            transform: (n, _) => ((n.TargetNode as TypeDeclarationSyntax)!, n)
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => execute(spc, source.Left, source.Right)); 
    }

    public static bool IsValid(ITypeSymbol type)
    {
        return type
            .GetAttributes()
            .Any(x =>
            {
                if(x.AttributeClass is null)
                {
                    return false;
                }

                var name = x.AttributeClass.ToDisplayString();
                
                return name.StartsWith(IsValidAttribute);
            })
            ||
            type
            .AllInterfaces
            .Any(x => x.ToDisplayString() == IsValidName);
    }

    public static string GenerateValidValueName(ITypeSymbol genericType)
    {
        return $"{IsValidName}<{genericType.ToDisplayString()}>";
    }
}

