using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public sealed class ValidAttribute : Attribute
{

}

[Generator]
public class ValidGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            typeof(ValidAttribute).FullName,

            predicate: static (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: static (n, _) => (n.TargetNode as TypeDeclarationSyntax)!
        )
        .Where(x => x is not null);

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<TypeDeclarationSyntax> typeList
    )
    {
        var classCopies = typeList.Select(x => 
        {
            var builder = new StringBuilder();
            var model = compilation.GetSemanticModel(x.SyntaxTree);
            var nameSpace = GetNamespace(x);
            return nameSpace;
        });

        var typesList = typeList.Select(x =>
        {
            return compilation
                .GetSemanticModel(x.SyntaxTree)
                .GetDeclaredSymbol(x) as INamedTypeSymbol;
        })
        .Where(x => x is not null)
        .Select(x => x!.ToDisplayString());

        var code = $$"""
        namespace SampleSourceGenerator;

        public static class ClassNames
        {
            public static string TypesList = "{{string.Join(", ", typesList)}}";
        }
        """;

        context.AddSource("ClassNames.g.cs", code);
    }

    private static string GetHierarchy(TypeDeclarationSyntax type)
    {
        var nameSpace = GetNamespace(type);
        var parentClass = GetParentClass(type);
        var sb = new StringBuilder();

        // If we don't have a namespace, generate the code in the "default"
        // namespace, either global:: or a different <RootNamespace>
        var hasNamespace = !string.IsNullOrEmpty(nameSpace);
        if (hasNamespace)
        {
            // We could use a file-scoped namespace here which would be a little impler, 
            // but that requires C# 10, which might not be available. 
            // Depends what you want to support!
            sb
                .Append("namespace ")
                .Append(nameSpace)
                .AppendLine(@"
        {");
        }
    
        int parentsCount = 0;
        // Loop through the full parent type hiearchy, starting with the outermost
        while (parentClass is not null)
        {
            sb
                .Append("    partial ")
                .Append(parentClass.Keyword) // e.g. class/struct/record
                .Append(' ')
                .Append(parentClass.Name) // e.g. Outer/Generic<T>
                .Append(' ')
                .Append(parentClass.Constraints) // e.g. where T: new()
                .AppendLine(@"
            {");
            parentsCount++; // keep track of how many layers deep we are
            parentClass = parentClass.Child; // repeat with the next child
        }

        // Write the actual target generation code here. Not shown for brevity
        sb.AppendLine(@"public partial readonly struct TestId
        {
        }");

        // We need to "close" each of the parent types, so write
        // the required number of '}'
        for (int i = 0; i < parentsCount; i++)
        {
            sb.AppendLine(@"    }");
        }

        // Close the namespace, if we had one
        if (hasNamespace)
        {
            sb.Append('}').AppendLine();
        }

        return sb.ToString();
    }
    
    private static string GetNamespace(TypeDeclarationSyntax syntax)
    {
        // If we don't have a namespace at all we'll return an empty string
        // This accounts for the "default namespace" case
        string nameSpace = string.Empty;

        // Get the containing syntax node for the type declaration
        // (could be a nested type, for example)
        SyntaxNode? potentialNamespaceParent = syntax.Parent;
        
        // Keep moving "out" of nested classes etc until we get to a namespace
        // or until we run out of parents
        while (potentialNamespaceParent != null &&
                potentialNamespaceParent is not NamespaceDeclarationSyntax
                && potentialNamespaceParent is not FileScopedNamespaceDeclarationSyntax)
        {
            potentialNamespaceParent = potentialNamespaceParent.Parent;
        }

        // Build up the final namespace by looping until we no longer have a namespace declaration
        if (potentialNamespaceParent is BaseNamespaceDeclarationSyntax namespaceParent)
        {
            // We have a namespace. Use that as the type
            nameSpace = namespaceParent.Name.ToString();
            
            // Keep moving "out" of the namespace declarations until we 
            // run out of nested namespace declarations
            while (true)
            {
                if (namespaceParent.Parent is not NamespaceDeclarationSyntax parent)
                {
                    break;
                }

                // Add the outer namespace as a prefix to the final namespace
                nameSpace = $"{namespaceParent.Name}.{nameSpace}";
                namespaceParent = parent;
            }
        }

        // return the final namespace
        return nameSpace;
    }

    private class ParentClass
    {
        public ParentClass(string keyword, string name, string constraints, ParentClass? child)
        {
            Keyword = keyword;
            Name = name;
            Constraints = constraints;
            Child = child;
        }

        public ParentClass? Child { get; }
        public string Keyword { get; }
        public string Name { get; }
        public string Constraints { get; }
    }

    private static ParentClass? GetParentClass(TypeDeclarationSyntax typeSyntax)
    {
        // Try and get the parent syntax. If it isn't a type like class/struct, this will be null
        TypeDeclarationSyntax? parentSyntax = typeSyntax.Parent as TypeDeclarationSyntax;
        ParentClass? parentClassInfo = null;

        // Keep looping while we're in a supported nested type
        while (parentSyntax != null && IsAllowedKind(parentSyntax.Kind()))
        {
            // Record the parent type keyword (class/struct etc), name, and constraints
            parentClassInfo = new ParentClass
            (
                parentSyntax.Keyword.ValueText,
                parentSyntax.Identifier.ToString() + parentSyntax.TypeParameterList,
                parentSyntax.ConstraintClauses.ToString(),
                parentClassInfo
            ); // set the child link (null initially)

            // Move to the next outer type
            parentSyntax = (parentSyntax.Parent as TypeDeclarationSyntax);
        }

        // return a link to the outermost parent type
        return parentClassInfo;

    }

    // We can only be nested in class/struct/record
    private static bool IsAllowedKind(SyntaxKind kind) =>
        kind == SyntaxKind.ClassDeclaration  ||
        kind == SyntaxKind.StructDeclaration ||
        kind == SyntaxKind.RecordDeclaration ||
        kind == SyntaxKind.InterfaceDeclaration;
}

