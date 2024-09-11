using System.Collections.Immutable;
using Definit.Validation.Generator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class ResultGenerator : IIncrementalGenerator
{
    private const string ResultType = "Definit.Results.NewApproach.IResult";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.NewApproach.GenerateResultAttribute",
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
            .StartsWith(ResultType));

        var genericArgs = interf.TypeArguments.Select(x => x.ToDisplayString()).ToArray();

        var name = typeInfo.Name;
        var fullName = typeInfo.FullName;
        var constructorName = symbol.Name;

        var tuple = $"({string.Join(", ", genericArgs.Select(x => $"Null<{x}>?"))})";
        var either = $"Either<{string.Join(", ", genericArgs)}>";

        var deconstructorOut = string.Join(", ", genericArgs.Select((x, i) => $"out Null<{x}>? t{i}"));
        var deconstructorAsignment = string.Join(", ", genericArgs.Select((x, i) => $"t{i}"));
        var deconstructor = $"public void Deconstruct({deconstructorOut}) => ({deconstructorAsignment}) = Result;";

        var operators = string.Join("\n\n", genericArgs.Select(x => $$"""
        public static implicit operator {{name}}([DisallowNull] {{x}} value) => new (value!); 
        public static implicit operator {{name}}([DisallowNull] Null<{{x}}> value) => new (value); 
        public static implicit operator {{name}}([DisallowNull] Null<{{x}}>? value) => new (value!.Value); 
        """));

        code.AddBlock($$"""
        public readonly struct Value : I{{either}}
        {
            public {{either}} Result { get; }

            {{tuple}} I{{either}}.Value => Result.Value;

            [Obsolete("Must not be used without parameters", true)]                                                                                   
            public Value() {}                                                                                                                        

            public Value({{fullName}} result)
            {
                Result = result._value;
            }

            {{deconstructor}}                                                                                                                                          
        }

        private readonly {{either}} _value;                                                                                              
                                                                                                                                                  
        [Obsolete("Must not be used without parameters", true)]                                                                                   
        public {{constructorName}}() {}                                                                                                                        
                                                                                                                                                  
        public {{constructorName}}({{either}} value)
        {
            _value = value;
        }
                                                                                                                                                  
        public static implicit operator {{name}}([DisallowNull] ResultMatchError value) => throw new ResultMatchException<{{fullName}}>(); 

        {{operators}}
        """);

        return (code.ToString(), typeInfo.FullName);
    }
}

