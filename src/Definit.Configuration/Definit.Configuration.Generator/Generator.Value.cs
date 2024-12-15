using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Configuration.Generator;

[Generator]
public class ValueGenerator : IIncrementalGenerator
{
    private const string Attribute = "Definit.Configuration.ConfigAttribute`1";
    private const string AttributeName = "Definit.Configuration.ConfigAttribute<";
    private const string InterfaceName = "Definit.Configuration.IConfig";
    private const string ValidInterface = "Definit.Validation.IValid";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            Attribute,
            predicate: (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: (n, _) => (n.TargetSymbol as INamedTypeSymbol, n
                .Attributes
                .Single(x =>
                    x.AttributeClass is not null 
                    && x.AttributeClass
                    .ToDisplayString()
                    .StartsWith(AttributeName))
                .AttributeClass!
                .TypeArguments.Single() as INamedTypeSymbol)
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());
        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right!)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<(INamedTypeSymbol Type, INamedTypeSymbol GenericType)> typeList
    )
    {
        SourceHelper.Run
        (
            context,
            () => typeList
                .Select<(INamedTypeSymbol Type, INamedTypeSymbol GenericType), Func<(string, string)>>
                (
                    x => () => GetType(x.Type, x.GenericType)
                )
                .ToImmutableArray()
        );
    }

    private static (string Code, string ClassName) GetType
    (
        INamedTypeSymbol type,
        INamedTypeSymbol genericTypeSymbol
    )
    {
        var (code, info) = type.BuildTypeHierarchy
        (
            name => $"sealed {name}",
            "Definit.Results",
            "Definit.Configuration",
            "Definit.Validation"
        );

        var constructorName = info.ConstructorName;
        var name = info.Name;
        var minimalName = info.MinimalName;
        var valueType = genericTypeSymbol.ToDisplayString();

        code.AddBlock($$"""
        public sealed class Config : {{InterfaceName}}<{{genericTypeSymbol.ToDisplayString()}}, {{type.Name}}.Valid>
        {
            private readonly static Rule<{{valueType}}> _rule;

            static Config()
            {
                _rule = new();
                {{name}}.Rule(_rule);
            }

            private Func<U<Valid, ValidationError>> Value { get; init; }

            public Config(Func<U<Valid, ValidationError>> value)
            {
                Value = value;
            }

            public Config(IConfiguration configuration)
            {
                Value = () => Valid.Create(configuration);
            }

            public U<Valid, ValidationError> IsValid(string? propertyName = null) => Value();

            public U<ValidationError> Validate(string? propertyName = null) => Value().ToResult(); 

            public static U<ValidationError> Register(IServiceCollection services, IConfiguration configuration)
            {
                services.AddSingleton<Config>(_ => new Config(configuration));

                return new Config(configuration).Validate();
            }
        }

        public readonly struct Valid : {{ValidInterface}}<{{valueType}}>
        {
            public {{valueType}} Value { get; }

            private Valid({{valueType}} value)
            {
                Value = value;
            }

            public static U<Valid, ValidationError> Create(IConfiguration configuration)
            {
                var (value, error) = ConfigHelper.GetValue<{{valueType}}>(configuration, {{name}}.SectionName);  
                if (error is not null)
                {
                    return error.Value;
                }

                (var _, error) = _rule.Validate(({{valueType}})value!, SectionName);
                if (error is not null)
                {
                    return error.Value;
                }

                return new Valid(({{valueType}})value!);
            }
        }
        """);

        return (code.ToString(), name);
    }
}

