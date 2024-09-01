using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

public sealed class TypeInfo
{
    public string Keyword     { get; }
    public string Name        { get; }
    public string Constraints { get; }
    public string FullName    { get; }

    public TypeInfo(string? nameSpace, IEnumerable<string> parentsNames, TypeDeclarationSyntax type)
    {
        Keyword     = type.Keyword.ValueText;
        Name        = type.Identifier.ToString() + type.TypeParameterList;
        Constraints = type.ConstraintClauses.ToString();
        FullName    = nameSpace is null
            ?
            $"{string.Join(".", parentsNames)}.{Name}"
            :
            $"{nameSpace}.{string.Join(".", parentsNames)}.{Name}";
    }

    public string GenerateTypeName()
    {
        return $"partial {Keyword} {Name} {Constraints}";
    }
}

public static class SourceHelper
{
    public static (SourceBuilder Code, TypeInfo TypeInfo) BuildTypeHierarchy
    (
        this TypeDeclarationSyntax syntax,
        ImmutableArray<string> usings
    )
    {
       var (nameSpace, typeInfo, parents) = GetTypeAndParentsInfo(syntax); 
       
       var code = new SourceBuilder(usings.ToArray(), nameSpace); 


    }

    private static (string? NameSpace, TypeInfo TypeInfo, Stack<TypeInfo> Parents) GetTypeAndParentsInfo
    (
        TypeDeclarationSyntax syntax
    )
    {
        var nameSpace = GetNamespace(syntax);
        var parents  = new Stack<TypeInfo>();
        var parentNames = new List<string>();

        TypeDeclarationSyntax? parentSyntax = syntax.Parent as TypeDeclarationSyntax;
        while (parentSyntax != null && IsAllowedKind(parentSyntax.Kind()))
        {
            var parent = new TypeInfo(nameSpace, parentNames, parentSyntax);
            parents.Push(parent);
            parentNames.Add(parent.Name);
            parentSyntax = (parentSyntax.Parent as TypeDeclarationSyntax);
        }

        var typeInfo = new TypeInfo(nameSpace, parentNames, syntax);
        return (nameSpace, typeInfo, parents);
    }

    private static string? GetNamespace(TypeDeclarationSyntax syntax)
    {
        string? nameSpace = null;

        SyntaxNode? potentialNamespaceParent = syntax.Parent;
        
        while (potentialNamespaceParent != null &&
                potentialNamespaceParent is not NamespaceDeclarationSyntax
                && potentialNamespaceParent is not FileScopedNamespaceDeclarationSyntax)
        {
            potentialNamespaceParent = potentialNamespaceParent.Parent;
        }

        if (potentialNamespaceParent is BaseNamespaceDeclarationSyntax namespaceParent)
        {
            nameSpace = namespaceParent.Name.ToString();
            
            while (true)
            {
                if (namespaceParent.Parent is not NamespaceDeclarationSyntax parent)
                {
                    break;
                }

                nameSpace = $"{namespaceParent.Name}.{nameSpace}";
                namespaceParent = parent;
            }
        }

        return nameSpace;
    }

    private static bool IsAllowedKind(SyntaxKind kind) =>
        kind == SyntaxKind.ClassDeclaration  ||
        kind == SyntaxKind.StructDeclaration ||
        kind == SyntaxKind.RecordDeclaration ||
        kind == SyntaxKind.InterfaceDeclaration;
}
