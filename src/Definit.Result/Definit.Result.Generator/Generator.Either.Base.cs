using System.Collections.Immutable;
using System.Text;
using Definit.Utils.SourceGenerator;
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
        SourceHelper.Run(context, () => typeList
            .SelectMany<GeneratorAttributeSyntaxContext, Func<(string, string)>>(x => GetType(x))
            .ToImmutableArray());
    }

    private static ImmutableArray<Func<(string Code, string ClassName)>> GetType
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

        return Enumerable.Range(0, count).Select<int, Func<(string, string)>>(inx => () =>
        {
            var length = inx + 2;
            var generic = 
                new GenericConstraints.Holders
                (
                    Enumerable
                        .Range(0, length)
                        .Select(x => GenericConstraints.Holder.Notnull($"T{x}"))
                        .ToImmutableArray()
                );
            
            var genericArgs = string.Join(", ", generic.Value.Select(x => x.Name));
            var either = $"Either<{genericArgs}>";
            var (interior, extension, genericOrArgs) = EitherInterior
            (
                generic,
                generic,
                "Either",
                either
            );

            interior = string.Join("\n\t", interior.Split('\n'));
            extension = string.Join("\n\t", extension.Split('\n'));

            var setupCode = $$"""
            #nullable enable

            using System.Diagnostics.CodeAnalysis;

            namespace Definit.Results;

            public readonly struct {{either}} : {{either}}.Base{{generic}} 
            {
                public interface Base : IEitherBase<({{genericOrArgs}})>;

                {{interior}}
            }

            public static class EitherExtensions_{{length}} 
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
        GenericConstraints.Holders allGenericParams,
        GenericConstraints.Holders typeGenericParams,
        string constructorName,
        string typeName
    )
    {
        var genericOrArgs = string.Join(", ", allGenericParams.Value.Select(x => $"Or<{x.Name}>?"));
        var genericArgs = string.Join(", ", allGenericParams.Value.Select(x => x.Name));

        var constructors = string.Join("\n", allGenericParams.Value
            .Select((x, i) =>
            {
                var args = Enumerable.Range(0, allGenericParams.Value.Length).Select(_ => "null").ToArray();
                args[i] = "value!";

                var argsString = string.Join(", ", args);

                return $"public {constructorName}({x.Name} value) => Value = ({argsString});";
            }));

        var operators = string.Join("\n", allGenericParams.Value
            .Select(x => $"public static implicit operator {typeName}({x.Name} value) => new (value);"));

        var interior = $$"""
        public ({{genericOrArgs}}) Value { get; }

        [Obsolete(DefaultConstructorException.Attribute, true)]
        public {{constructorName}}() => throw new DefaultConstructorException();

        {{constructors}}

        public static implicit operator {{typeName}}([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<{{genericArgs}}>>();
        {{operators}}
        """;

        var extension = GenerateExtensions(allGenericParams, typeGenericParams, typeName);
        
        return (interior, extension, genericOrArgs);
    }

    private static string GenerateExtensions
    (
        GenericConstraints.Holders allGenericParams,
        GenericConstraints.Holders typeGenericParams,
        string typeName
    )
    {
        var length = allGenericParams.Value.Length;
        var generic = allGenericParams.Value.Select(x => (Type: x, Name: $"{x.Name}_arg")).ToArray();

        var typeGenericArgs = string.Join(", ", typeGenericParams.Value.Select(x => x.Name));
        var returns = string.Join(", ", generic.Select(x => x.Name));
        var nullValues = string.Join(" ", generic.Select(x => $"{x.Name} = null;"));

        var builder = new StringBuilder();
        if(length <= 4)
        {
            var outArgs = string.Join(",\n\t", generic.Select(x => $"out {x.Type.Name}? {x.Name}"));
            var states = GenerateAllStates(length);

            foreach(var state in states)
            {
                var genericConstraints = new GenericConstraints.Holders(state.Select((isClass, i) =>
                {
                    var genericParam = typeGenericParams.Value[i];
                    var main = genericParam.Main;

                    if(isClass)
                    {
                        var cantBeClass = 
                           main is GenericConstraints.Main.Struct
                        || main is GenericConstraints.Main.Unmanaged;
                         
                        if(cantBeClass)
                        {
                            return genericParam;
                        }

                        var newMain = main.IsNew() ? GenericConstraints.Main.ClassNew : GenericConstraints.Main.Class;

                        return new GenericConstraints.Holder(genericParam.Name, newMain, genericParam.Types);
                    }
                    else
                    {
                        var canBeStruct = 
                           main is GenericConstraints.Main.Struct
                        || main is GenericConstraints.Main.New
                        || main is GenericConstraints.Main.NotnullNew
                        || main is GenericConstraints.Main.Notnull;
                         
                        if(canBeStruct == false)
                        {
                            return genericParam;
                        }

                        var newMain = GenericConstraints.Main.Struct;

                        return new GenericConstraints.Holder(genericParam.Name, newMain, genericParam.Types);
                    }
                }).ToImmutableArray()); 

                var deconstructor = $$"""
                public static void Deconstruct<{{typeGenericArgs}}>
                (
                    this {{typeName}} result,
                    {{outArgs}}
                ){{genericConstraints}}
                {
                    ({{returns}}) = result.Value;
                }

                public static void Deconstruct<{{typeGenericArgs}}>
                (
                    this {{typeName}}? result,
                    {{outArgs}}
                ){{genericConstraints}}
                {
                    if(result is null)
                    {
                        {{nullValues}}
                        return;
                    }

                    ({{returns}}) = result.Value.Value;
                }
                """;

                builder
                    .AppendLine()
                    .AppendLine(deconstructor);
            }
        }
        else
        {
            //TODO
        }

        return builder.ToString();
    }

    private static bool[][] GenerateAllStates(int size)
    {
        int totalStates = (int)Math.Pow(2, size);  
        bool[][] result = new bool[totalStates][];

        for (int i = 0; i < totalStates; i++)
        {
            bool[] currentState = new bool[size];
            
            for (int bit = 0; bit < size; bit++)
            {
                currentState[bit] = (i & (1 << bit)) != 0;
            }

            result[i] = currentState;
        }

        return result;
    }
}
