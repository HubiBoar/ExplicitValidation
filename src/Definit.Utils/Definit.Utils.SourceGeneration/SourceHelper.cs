using Microsoft.CodeAnalysis;

namespace Definit.Utils.SourceGenerator;

public sealed class TypeInfo
{
    public string? NameSpace       { get; }
    public INamedTypeSymbol Symbol { get; }
    public string TypeName         { get; }

    public IReadOnlyList<TypeInfo> Parents  { get; }

    public TypeInfo(INamedTypeSymbol symbol)
    {
        Symbol = symbol;
        NameSpace = symbol.ContainingNamespace.IsGlobalNamespace ? null : symbol.ContainingNamespace.ToDisplayString();
        var type = Symbol.TypeKind switch
        {
            TypeKind.Class => "class",
            _ => "struct"
        };

        var generics = string.Join(", ", Symbol.TypeArguments.Select(x => x.ToDisplayString()));
        generics = string.IsNullOrEmpty(generics) ? string.Empty : $"<{generics}>";
        var constraints = Symbol.TypeArguments.GetGenericConstraints();
        constraints = string.IsNullOrEmpty(constraints) ? string.Empty : $"\n\t{constraints}";

        TypeName = $"partial {type} {Symbol.Name}{generics}{constraints}";
        
        var parents = new List<TypeInfo>();

        var parent = symbol.ContainingType;

        while(parent is not null)
        {
            parents.Add(new TypeInfo(parent));
            parent = parent.ContainingType;
        }

        Parents = parents;
    }
}

public static class SourceHelper
{
    public static (SourceBuilder Code, TypeInfo TypeInfo) BuildTypeHierarchy
    (
        this INamedTypeSymbol symbol,
        Func<string, string> editTypeInfo,
        params string[] usings
    )
    {
        var typeInfo = new TypeInfo(symbol); 
        var code = new SourceBuilder(usings.ToArray(), typeInfo.NameSpace); 

        int index = 0;
        foreach(var parent in typeInfo.Parents)
        {
            if(index == 0)
            {
                code.AddBlockDontIndent(parent.TypeName);
            }
            else
            {
                code.AddBlock(parent.TypeName);
            }
            index ++;
        }

        if(typeInfo.Parents.Count > 0)
        {
            code.AddBlock(editTypeInfo(typeInfo.TypeName));
        }
        else
        {
            code.AddBlockDontIndent(editTypeInfo(typeInfo.TypeName));
        }

        return (code, typeInfo);
    }
}
