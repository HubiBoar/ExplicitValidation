using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class EitherBaseGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.GenerateEither+BaseAttribute",
            predicate: (c, _) => true,

            transform: (n, _) => (n)
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<GeneratorAttributeSyntaxContext> typeList
    )
    {
        foreach(var type in typeList.SelectMany(x => GetType(x)))
        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
        
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    private static ImmutableArray<(string Code, string ClassName)> GetType
    (
        GeneratorAttributeSyntaxContext context
    )
    {
        int count = int.Parse(context
            .Attributes
            .Single(x => x
                .AttributeClass!
                .ToDisplayString() == "Definit.Results.GenerateEither.BaseAttribute")
            .ConstructorArguments
            .Single()
            .Value!
            .ToString());

        return Enumerable.Range(0, count).Select(inx =>
        {
            var length = inx + 2;
            var generic = Enumerable.Range(0, length).Select(x => $"T{x}").ToArray();
            
            var genericArgs = string.Join(", ", generic.Select(x => x));
            var either = $"Either<{genericArgs}>";
            var (interior, extension, genericOrArgs) = EitherInterior
            (
                generic,
                generic,
                string.Empty,
                "Either",
                either
            );

            interior = string.Join("\n\t", interior.Split('\n'));
            extension = string.Join("\n\t", extension.Split('\n'));

            var setupCode = $$"""
            #nullable enable

            using System.Diagnostics.CodeAnalysis;

            namespace Definit.Results;

            public readonly struct {{either}} : {{either}}.Base 
            {
                public interface Base : IEitherBase<({{genericOrArgs}})>;

                {{interior}}
            }

            public static partial class EitherExtensions 
            {
                {{extension}}
            }
            """;

            string fileName = $"Definit.Results.Either_{length}"; 

            return (setupCode, fileName);
        })
        .ToImmutableArray();
    }

    public static (string Interior, string Extensions, string GenericOrArgs) EitherInterior
    (
        string[] genericParams,
        string[] typeGenericParams,
        string typeGenericConstraints,
        string constructorName,
        string typeName
    )
    {
        var generic = genericParams.Select(x => (Type: x, Name: $"{x}_arg")).ToArray();
        var genericArgs = string.Join(", ", generic.Select(x => x.Type));
        var typeGenericArgs = string.Join(", ", typeGenericParams);
        var genericOrArgs = string.Join(", ", generic.Select(x => $"Or<{x.Type}>?"));

        var constructors = string.Join("\n", generic
            .Select((x, i) =>
            {
                var args = Enumerable.Range(0, generic.Length).Select(_ => "null").ToArray();
                args[i] = "value!";

                var argsString = string.Join(", ", args);

                return $"public {constructorName}({x.Type} value) => Value = ({argsString});";
            }));

        var operators = string.Join("\n", generic
            .Select(x => $"public static implicit operator {typeName}({x.Type} value) => new (value);"));

        var outArgs = string.Join(",\n\t", generic.Select(x => $"out Or<{x.Type}>? {x.Name}"));
        var returns = string.Join(", ", generic.Select(x => x.Name));
        var nullValues = string.Join(" ", generic.Select(x => $"{x.Name} = null;"));

        var interior = $$"""
        public ({{genericOrArgs}}) Value { get; }

        [Obsolete(DefaultConstructorException.Attribute, true)]
        public {{constructorName}}() => throw new DefaultConstructorException();

        {{constructors}}

        public static implicit operator {{typeName}}([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<{{genericArgs}}>>();
        {{operators}}
        """;

        var extension = $$"""
        public static void Deconstruct<{{typeGenericArgs}}>
        (
            this {{typeName}} result,
            {{outArgs}}
        ){{typeGenericConstraints}}
        {
            ({{returns}}) = result.Value;
        }

        public static void Deconstruct<{{typeGenericArgs}}>
        (
            this {{typeName}}? result,
            {{outArgs}}
        ){{typeGenericConstraints}}
        {
            if(result is null)
            {
                {{nullValues}}
                return;
            }

            ({{returns}}) = result.Value.Value;
        }
        """;

        return (interior, extension, genericOrArgs);
    }
}
