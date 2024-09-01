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

        var code = new StringBuilder()
            .AppendLine("#nullable enable")
            .AppendLine()
            .AppendLine("using Definit.Results;")
            .AppendLine();

        var fullClassName = new StringBuilder();

        var hasNamespace  = string.IsNullOrEmpty(nameSpace) == false;

        if (hasNamespace)

        {
            fullClassName.Append($"{nameSpace}.");
            code.AppendLine($"namespace {nameSpace};");
        }
   
        int tabsStartCount = 0;
        int tabsCount = tabsStartCount;
        foreach(var parent in parents)
        {
            fullClassName.Append($"{parent.Name}.");
            code.Append(parent.GenerateTypeName(tabsCount));
            tabsCount++;
        }

        code.AddLine(tabsCount, $$"""
        sealed partial record {{className}}
        {
        """);
      
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
}

