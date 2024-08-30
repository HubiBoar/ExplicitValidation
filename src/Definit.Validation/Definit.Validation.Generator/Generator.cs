using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
public class ValidValueGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.CreateSyntaxProvider
        (
            predicate: static (c, _) =>
                c is RecordDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: static (n, _) => (n.Node as RecordDeclarationSyntax)!
        )
        .Where(x => x is not null);

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<RecordDeclarationSyntax> typeList
    )
    {
        var typesList = typeList.Select(x =>
        {
            var symbol = compilation.GetSemanticModel(x.SyntaxTree).GetDeclaredSymbol(x) as ITypeSymbol;
            var baseName = symbol!.BaseType?.ToDisplayString();
            return (Symbol: symbol, Record: x, BaseName: baseName);
        })
        .DistinctBy(x => x.Symbol.ToDisplayString())
        .Where(x => x.BaseName is not null && x.BaseName.StartsWith("NewApproach.IsValid<"))
        .Select(x => 
        {
            var type = x.Symbol.BaseType!.TypeArguments.Single().ToDisplayString(); 
            return (Symbol: x.Symbol, Record: x.Record, BaseName: x.BaseName, Type: type);
        });

        var names = typesList.Select(x => $"{x.Symbol.ToDisplayString()} => {x.BaseName} => {x.Type}");

        var code = $$"""
        namespace SampleSourceGenerator;

        public static class ClassNames
        {
            public static string TypesList = "{{string.Join(" :: ", names)}}";
        }
        """;

        context.AddSource("ClassNames.g.cs", code);

        var hierarchyList = typesList.Select(x => GetHierarchy(x.Record, x.Symbol, x.Type));

        foreach(var hierarchy in hierarchyList)
        {
            context.AddSource($"{hierarchy.ClassName}.g.cs", hierarchy.Code);
        }
    }

    private static (string Code, string ClassName) GetHierarchy
    (
        TypeDeclarationSyntax type,
        ITypeSymbol symbol,
        string valueType
    )
    {
        const string validName      = "Valid";
        const string isValid        = "IsValid";
        const string backingIsValid = "_isValid";

        var nameSpace           = GetNamespace(type);
        var (typeInfo, parents) = GetTypeInfo(type);
        var className           = typeInfo.Name;

        var code = new StringBuilder();

        var fullClassName = new StringBuilder();
        var hasNamespace  = string.IsNullOrEmpty(nameSpace) == false;
        if (hasNamespace)
        {
            fullClassName.Append($"{nameSpace}.");
            code.AppendLine("#nullable enable")
                .AppendLine()
                .AppendLine("using Definit.Results;")
                .AppendLine()
                .Append($"namespace {nameSpace}")
                .AddLine(0, "{");
        }
   
        int tabsStartCount = hasNamespace ? 1 : 0;
        int tabsCount = tabsStartCount;
        foreach(var parent in parents)
        {
            fullClassName.Append($"{parent.Name}.");
            code.Append(parent.GenerateTypeName(tabsCount));
            tabsCount++;
        }

        code.Append(typeInfo.GenerateTypeName(tabsCount));
      
        //Valid Creation
        {
            tabsCount += 1;

            code.AddLine(tabsCount, $$"""
                public Result<{{validName}}> {{isValid}} => {{backingIsValid}} ??= {{validName}}.IsValid(this);
                private Result<{{validName}}>? {{backingIsValid}} = null;

                public static implicit operator {{className}}({{valueType}} value) => new {{className}}
                {
                    Value = value,
                };

                public static implicit operator {{valueType}}({{className}} value) => value.Value;

                """);

            code.AddLine(tabsCount, $$"""
                public sealed record {{validName}}
                {
                """);

            tabsCount += 1;

            code.AddLine(tabsCount, $$"""
                public {{valueType}} Value => Holder.Value;
                private {{className}} Holder { get; }

                private Valid({{className}} holder)
                {
                    Holder = holder;
                }

                public static implicit operator {{className}}(Valid value) => value.Holder;

                public static Result<Valid> IsValid({{className}} value)
                {
                    if(value.Validate().Is(out Error error))
                    {
                        return error;
                    }
                    return new Valid(value);
                """);
        }

        for (int i = tabsCount; i >= 0; i--)
        {
            code.AddLine(i, "}");
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
            return code.AddLine(tabsCount, $"partial {Keyword} {Name} {Constraints}")
                .AddLine(tabsCount, "{")
                .ToString();
        }
    }


    private static (TypeInfo TypeInfo, Stack<TypeInfo> Parents) GetTypeInfo(TypeDeclarationSyntax typeSyntax)
    {
        var typeInfo = new TypeInfo(typeSyntax);
        var parents  = new Stack<TypeInfo>();

        TypeDeclarationSyntax? parentSyntax = typeSyntax.Parent as TypeDeclarationSyntax;
        while (parentSyntax != null && IsAllowedKind(parentSyntax.Kind()))
        {
            parents.Push(new TypeInfo(parentSyntax));
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

public static class StringHelper
{
    public static string AddTabs(int count)
    {
        return string.Join("", Enumerable.Range(0, count).Select(x => "\t"));
    }

    public static StringBuilder AddLine(this StringBuilder builder, int tabsCount, string value)
    {
        var tabs = AddTabs(tabsCount);
        var lines = string.Join("\n", value.Split('\n').Select(x => $"{tabs}{x}"));
        return builder.AppendLine().Append(lines);
    }

    public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
    {
        var keys = new HashSet<TKey>();
        foreach (var element in source)
        {
            if (keys.Contains(keySelector(element))) continue;
            keys.Add(keySelector(element));
            yield return element;
        }
    }
}

