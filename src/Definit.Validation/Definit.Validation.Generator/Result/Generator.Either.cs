using System.Collections.Immutable;
using Definit.Validation.Generator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class EitherGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.NewApproach.GenerateEitherAttribute",
            predicate: (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: (n, _) => ((n.TargetNode as TypeDeclarationSyntax)!, (n.TargetSymbol as ITypeSymbol)!)
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<(TypeDeclarationSyntax Syntax, ITypeSymbol Symbol)> typeList
    )
    {
        foreach(var type in typeList.Select(x => GetType(x.Syntax, x.Symbol)))
        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    private static (string Code, string ClassName) GetType
    (
        TypeDeclarationSyntax syntax,
        ITypeSymbol symbol
    )
    {
        var (code, typeInfo) = syntax.BuildTypeHierarchy
        (
            name => $"readonly {name}",
            "Definit.Results",
            "Definit.Validation",
            "System.Diagnostics.CodeAnalysis"
        );

        var interf = symbol.AllInterfaces
            .Single(x => x.ToDisplayString()
            .StartsWith("Definit.Results.NewApproach.IEither"));

        var genericArgs = interf.TypeArguments.Select(x => x.ToDisplayString()).ToArray();

        var name = typeInfo.Name;
        var fullName = typeInfo.FullName;
        var constructorName = symbol.Name;

        var tuple = $"({string.Join(", ", genericArgs.Select(x => $"Null<{x}>?"))})";
        var constructors = string.Join("\n", genericArgs.Select((x, index) =>
        {
            var tupleParams = Enumerable.Range(0, genericArgs.Length).Select(_ => "null").ToArray();
            tupleParams[index] = "value"; 
            var init = string.Join(", ", tupleParams);
            return $"public {constructorName}([DisallowNull] {x} value) => Value = ({init});";
        }));

        var deconstructorOut = string.Join(", ", genericArgs.Select((x, i) => $"out Null<{x}>? t{i}"));
        var deconstructorAsignment = string.Join(", ", genericArgs.Select((x, i) => $"t{i}"));
        var deconstructor = $"public void Deconstruct({deconstructorOut}) => ({deconstructorAsignment}) = Value;";

        var operators = string.Join("\n\n", genericArgs.Select(x => $$"""
        public static implicit operator {{name}}([DisallowNull] {{x}} value) => new (value); 
        public static implicit operator {{name}}([DisallowNull] Null<{{x}}> value) => new (value); 
        public static implicit operator {{name}}([DisallowNull] Null<{{x}}>? value) => new (value!.Value); 
        """));

        code.AddBlock($$"""
        public {{tuple}} Value { get; }                                                                                              
                                                                                                                                                  
        [Obsolete("Must not be used without parameters", true)]                                                                                   
        public {{constructorName}}() {}                                                                                                                        
                                                                                                                                                  
        {{constructors}}
                                                                                                                                                  
        {{deconstructor}}
                                                                                                                                                  
        public static implicit operator {{name}}([DisallowNull] Result.NullError value) => throw new Exception("{{fullName}}"); 

        {{operators}}
        """);

        return (code.ToString(), typeInfo.FullName);
    }
}

