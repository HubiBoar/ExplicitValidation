using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Definit.Utils.SourceGenerator;

public sealed class TypeInfo
{
    public string? NameSpace       { get; }
    public INamedTypeSymbol Symbol { get; }
    public string TypeName         { get; }
    public string ConstructorName  { get; }
    public string FullName         { get; }
    public string Name             { get; }
    public string MinimalName      { get; }

    public IReadOnlyCollection<TypeInfo> Parents  { get; }

    public TypeInfo(INamedTypeSymbol symbol)
    {
        Symbol = symbol;
        NameSpace = symbol.ContainingNamespace.IsGlobalNamespace ? null : symbol.ContainingNamespace.ToDisplayString();
        ConstructorName = symbol.Name;
        FullName = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
        Name = symbol.ToDisplayString();
        MinimalName = symbol.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat);

        var type = (Symbol.TypeKind, Symbol.IsRecord) switch
        {
            (TypeKind.Class, false)  => "class",
            (TypeKind.Class, true)   => "record",
            (TypeKind.Interface, _)  => "interface",
            (TypeKind.Struct, false) => "struct",
            (TypeKind.Struct, true)  => "record struct",
            _                        => "struct"
        };

        var generics = string.Join(", ", symbol.TypeArguments.Select(x => x.ToDisplayString()));
        generics = string.IsNullOrEmpty(generics) ? string.Empty : $"<{generics}>";
        var constraints = symbol.TypeArguments.GetGenericArguments();

        TypeName = $"partial {type} {Symbol.Name}{generics}{constraints}";
        
        var parents = new Stack<TypeInfo>();

        var parent = symbol.ContainingType;

        while(parent is not null)
        {
            parents.Push(new TypeInfo(parent));
            parent = parent.ContainingType;
        }

        Parents = parents;

    }
}

public static class SourceHelper
{
    public static void Run
    (
        SourceProductionContext context,
        Func<ImmutableArray<Func<(string Code, string FileName)>>> outerFunc
    )
    {
        try
        {
            int index = 0;
            foreach(var func in outerFunc())
            {
                try
                {
                    var (code, fileName) = func(); 
                    fileName = fileName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
                    context.AddSource($"{fileName}.g.cs", code);
                }
                catch (Exception ex)
                {
                    var code = "// \t" +string.Join("\n\t // ", ex.ToString().Split('\n'));

                    context.AddSource($"EXCEPTION.{index}.g.cs", code);
                }

                index ++;
            }
        }
        catch (Exception ex)
        {
            var code = "// \t" + string.Join("\n\t // ", ex.ToString().Split('\n'));

            context.AddSource($"EXCEPTION_TOP.g.cs", code);
        }
    }

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

