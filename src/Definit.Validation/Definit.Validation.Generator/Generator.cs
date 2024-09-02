﻿using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
public class ValidValueGenerator : IIncrementalGenerator
{
    private const string interfaceName = "NewApproach.IIsValid<";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.CreateSyntaxProvider
        (
            predicate: static (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: static (n, _) => (n.Node as TypeDeclarationSyntax)!
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
        var typesList = typeList.Select(x =>
        {
            var symbol = compilation.GetSemanticModel(x.SyntaxTree).GetDeclaredSymbol(x) as ITypeSymbol;
            return (Symbol: symbol!, Record: x);
        })
        .DistinctBy(x => x.Symbol.ToDisplayString())
        .Where(x => x.Symbol.AllInterfaces
            .SingleOrDefault(y => y
                .ToDisplayString()
                .StartsWith(interfaceName)) is not null)
        .Select(x => 
        {
            var type = x.Symbol.AllInterfaces
                .Single(y => y
                    .ToDisplayString()
                    .StartsWith(interfaceName))
                .TypeArguments
                .Single();

            return (Symbol: x.Symbol, Record: x.Record, Type: type);
        });

        var names = typesList.Select(x => $"{x.Symbol.ToDisplayString()} => {x.Type.ToDisplayString()}");

        var code = $$"""
        namespace SampleSourceGenerator;

        public static class ClassNames
        {
            public static string TypesList = "{{string.Join(" :: ", names)}}";
        }
        """;

        context.AddSource("ClassNames.g.cs", code);

        var hierarchyList = typesList.Select(x => GetHierarchy(x.Record, x.Symbol, x.Type.ToDisplayString()));

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
        var (code, typeInfo) = type.BuildTypeHierarchy("Definit.Results");

        var name = typeInfo.Name;

        code.AddBlock($$"""
        public {{valueType}} Value { get; }

        public {{name}}({{valueType}} value)
        {
            Value = value;
        }

        public static implicit operator {{name}}({{valueType}} value) => new (value);

        public static implicit operator {{valueType}}({{name}} value) => value.Value;

        public Result Validate() => {{interfaceName}}{{valueType}}>.DefaultValidate(this);
        """);

        return (code.ToString(), typeInfo.FullName);
    }
}

