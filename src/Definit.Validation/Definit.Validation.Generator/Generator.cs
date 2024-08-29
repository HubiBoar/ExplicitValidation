using System.Collections.Immutable;
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
        var hierarchyList = typeList.Select(GetHierarchy);

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
        foreach(var hierarchy in hierarchyList)
        {
            context.AddSource($"{hierarchy.ClassName}.g.cs", hierarchy.Code);
        }
    }

    private static (string Code, string ClassName) GetHierarchy(TypeDeclarationSyntax type)
    {

        var nameSpace           = GetNamespace(type);
        var (typeInfo, parents) = GetTypeInfo(type);
        var className           = typeInfo.Name;

        var code = new StringBuilder();

        var fullClassName = new StringBuilder();
        var hasNamespace = string.IsNullOrEmpty(nameSpace) == false;
        if (hasNamespace)
        {
            fullClassName.Append($"{nameSpace}.");
            code
                .Append("namespace ")
                .Append(nameSpace)
                .AppendLine(@"{");
        }
   
        int tabsStartCount = hasNamespace ? 1 : 0;
        int tabsCount = tabsStartCount;
        foreach(var parent in parents)
        {
            fullClassName.Append($"{parent.Name}.");
            code.AppendLine(parent.GenerateTypeName(tabsCount));
            tabsCount++;
        }

        code.AppendLine(typeInfo.GenerateTypeName(tabsCount+1));

        for (int i = tabsCount; i >= tabsStartCount; i--)
        {
            code.AppendLine(AddTabs(i)).Append(@"}");
        }

        if (hasNamespace)
        {
            code.AppendLine(@"}");
        }


        fullClassName.Append(className);
        return (code.ToString(), fullClassName.ToString());
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

    private class TypeInfo
    {
        public string Keyword     { get; }
        public string Name        { get; }
        public string Constraints { get; }

        public TypeInfo(TypeDeclarationSyntax type)
        {
            Keyword     = type.Keyword.ValueText;
            Name        = type.Identifier.ToString() + type.TypeParameterList;
            Constraints = type.ConstraintClauses.ToString();
        }

        public string GenerateTypeName(int tabsCount)
        {
            var code = new StringBuilder();
            var prefix = AddTabs(tabsCount);
            return code
                .Append(prefix)
                .Append(" partial ")
                .Append(Keyword) 
                .Append(Name) 
                .Append(Constraints) 
                .AppendLine(prefix)
                .Append(@"{")
                .ToString();
        }
    }

    private static string AddTabs(int count)
    {
        return string.Join("", Enumerable.Range(0, count).Select(x => "\t"));
    }

    private static (TypeInfo TypeInfo, Stack<TypeInfo> Parents) GetTypeInfo(TypeDeclarationSyntax typeSyntax)
    {
        var typeInfo = new TypeInfo(typeSyntax);
        var parents  = new Stack<TypeInfo>();

        TypeDeclarationSyntax? parentSyntax = typeSyntax.Parent as TypeDeclarationSyntax;
        while (parentSyntax != null && IsAllowedKind(parentSyntax.Kind()))
        {
            parents.Push(new TypeInfo(typeSyntax));
            parentSyntax = (parentSyntax.Parent as TypeDeclarationSyntax);
        }

        return (typeInfo, parents);
    }

    // We can only be nested in class/struct/record
    private static bool IsAllowedKind(SyntaxKind kind) =>
        kind == SyntaxKind.ClassDeclaration  ||
        kind == SyntaxKind.StructDeclaration ||
        kind == SyntaxKind.RecordDeclaration ||
        kind == SyntaxKind.InterfaceDeclaration;
}

