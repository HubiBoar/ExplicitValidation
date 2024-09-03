﻿using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
public class ValueGenerator : IIncrementalGenerator
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

            return GetType(x.Record, type.ToDisplayString());
        });

        foreach(var type in typesList)
        {
            context.AddSource($"{type.ClassName}.g.cs", type.Code);
        }
    }

    private static (string Code, string ClassName) GetType
    (
        TypeDeclarationSyntax type,
        string valueType
    )
    {
        var (code, typeInfo) = type.BuildTypeHierarchy("Definit.Results");

        var name = typeInfo.Name;
        var fullName = typeInfo.FullName;

        code.AddBlock($$"""
        private readonly static Rule<{{valueType}}> _rule;

        static {{name}}()
        {
            _rule = new();
            Rule(_rule);
        }

        public {{valueType}} Value { get; }

        public {{name}}({{valueType}} value)
        {
            Value = value;
        }

        public static implicit operator {{fullName}}({{valueType}} value) => new (value);

        public static implicit operator {{valueType}}({{fullName}} value) => value.Value;

        public Result Validate() => _rule.Validate(Value);

        public Result<Valid> IsValid() => Valid.Create(this);

        public readonly struct Valid
        {
            public {{fullName}} Value { get; }

            private Valid({{fullName}} Value)
            {
                this.Value = Value;
            }

            public static Result<Valid> Create({{fullName}} Value)
            {
                if(Value.Validate().Is(out Error error))
                {
                    return error;
                }

                return new Valid(Value);
            }
        }
        """);

        return (code.ToString(), typeInfo.FullName);
    }
}

