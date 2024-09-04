﻿using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
public class ValueGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        Helper.RunIsValidValue(context, (s, c, v) => Execute(s, c, v));
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<Helper.Value> typeList
    )
    {
        foreach(var type in typeList.Select(x => GetType(x.Type, x.GenericType)))
        {
            context.AddSource($"{type.ClassName}.g.cs", type.Code);
        }
    }

    private static (string Code, string ClassName) GetType
    (
        TypeDeclarationSyntax type,
        ITypeSymbol genericTypeSymbol
    )
    {
        var (code, typeInfo) = type.BuildTypeHierarchy
        (
            name => $"{name}: {Helper.GenerateValidValueName(genericTypeSymbol)}",
            "Definit.Results",
            "Definit.Validation"
        );

        var name = typeInfo.Name;
        var fullName = typeInfo.FullName;
        var valueType = genericTypeSymbol.ToDisplayString();

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

