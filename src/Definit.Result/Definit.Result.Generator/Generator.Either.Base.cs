using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class EitherBaseGenerator : IIncrementalGenerator
{
    private const int MaxDeconstructorsCount = 8;

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
                new Generic.Elements
                (
                    Enumerable
                        .Range(0, length)
                        .Select(x => Generic.Argument.Notnull($"T{x}"))
                        .ToImmutableArray()
                );
            
            var genericArgs = string.Join(", ", generic.ArgumentNames);
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

            public readonly struct {{either}} : {{either}}.Base{{generic.ConstraintsString}} 
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
        Generic.Elements allGenericParams,
        Generic.Elements typeGenericParams,
        string constructorName,
        string typeName
    )
    {
        var genericOrArgs = string.Join(", ", allGenericParams.Value.Select(x => $"Or<{x.Name}>?"));
        var genericArgs = allGenericParams.ArgumentNames;

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
        Generic.Elements allGenericParams,
        Generic.Elements typeGenericParams,
        string typeName
    )
    {
        var length = allGenericParams.Value.Length;

        var typeGenericArgs = string.Join(", ", typeGenericParams.Value.Select(x => x.Name));

        if(length <= MaxDeconstructorsCount)
        {
            var generic = allGenericParams.Value.Select(x => (Type: x, Return: $"{x.Name}_arg", Assign: $"{x.Name}_out")).ToArray();
            var outArgs = string.Join(",\n\t", generic.Select(x => $"out {x.Type.Name}? {x.Return}"));
            var returns = string.Join(", ", generic.Select(x => x.Assign));
            var assignments = string.Join("\n\t", generic.Select(x => $"{x.Return} = {x.Assign}?.Out ?? null;"));
            var nullValues = string.Join(" ", generic.Select(x => $"{x.Return} = null;"));
            var states = GenerateAllStates(typeGenericParams.Value.Length);

            return string.Join("\n\n", states.Select(state => 
            {
                var genericConstraints = new Generic.Elements(state.Select<bool, Generic.Element>((isClass, i) =>
                {
                    var (type, argument) = typeGenericParams.Value[i];
                    if(type is not null)
                    {
                        return type.Value;
                    }
                    
                    var genericParam = argument!.Value;

                    var main = genericParam.Constraint;

                    if(isClass)
                    {
                        var cantBeClass = 
                           main is Generic.Constraint.Struct
                        || main is Generic.Constraint.Unmanaged;
                         
                        if(cantBeClass)
                        {
                            return genericParam;
                        }

                        var newMain = main.IsNew() ? Generic.Constraint.ClassNew : Generic.Constraint.Class;

                        return new Generic.Argument(genericParam.Name, newMain, false, genericParam.Types);
                    }
                    else
                    {
                        var canBeStruct = 
                           main is Generic.Constraint.Struct
                        || main is Generic.Constraint.New
                        || main is Generic.Constraint.NotnullNew
                        || main is Generic.Constraint.Notnull;
                         
                        if(canBeStruct == false)
                        {
                            return genericParam;
                        }

                        var newMain = Generic.Constraint.Struct;

                        return new Generic.Argument(genericParam.Name, newMain, false, genericParam.Types);
                    }
                }).ToImmutableArray()); 

                return $$"""
                public static void Deconstruct<{{typeGenericArgs}}>
                (
                    this {{typeName}} either,
                    {{outArgs}}
                ){{genericConstraints.ConstraintsString}}
                {
                    var ({{returns}}) = either.Value;
                    {{assignments}}
                }

                public static void Deconstruct<{{typeGenericArgs}}>
                (
                    this {{typeName}}? either,
                    {{outArgs}}
                ){{genericConstraints.ConstraintsString}}
                {
                    if(either is null)
                    {
                        {{nullValues}}
                        return;
                    }

                    var ({{returns}}) = either.Value.Value;
                    {{assignments}}
                }
                """;
            }));
        }
        else
        {
            int roundedUp = (int)Math.Ceiling((double)length / MaxDeconstructorsCount); 
            var parts = new int[roundedUp];
            var total = length;
            while(total > 0)
            {
                for(int i = 0; i < roundedUp; i++)
                {
                    parts[i]++; 
                    total --;
                    if(total == 0)
                    {
                        break;
                    }
                }
            }
            
            int starter = 0;
            var eitherGenerics = parts.Select(x =>
            {
                var indexes = Enumerable.Range(starter, x).ToArray();
                var result = indexes.Select(i => allGenericParams.Value[i]).ToArray();             
                starter += x;
                return (Generics: result, ArgsIndexes: indexes);
            })
            .ToArray();

            var eitherGenericsArgs = eitherGenerics
                .Select((x, i) => (Type: "Either<" + string.Join(", ", x.Generics.Select(e => e.Name)) + ">", Name: $"arg_{i}", Generic: x))
                .ToArray();

            var outArgs = string.Join(",\n\t", eitherGenericsArgs.Select((x) => $"out {x.Type}? {x.Name}"));
            var nullValues = string.Join(" ", eitherGenericsArgs.Select(x => $"{x.Name} = null;"));
            var genericConstraints = allGenericParams.ConstraintsString;
            var results = Enumerable.Range(0, length).Select(x => $"out_{x}").ToArray();
            var assignOut = string.Join(", ", results);

            var returns = string.Join("\n\t", eitherGenericsArgs
                .Select(x => $"{x.Name} = " + string.Join("", x
                    .Generic
                    .ArgsIndexes
                    .Select(i => 
                    {
                        var result = results[i];
                        return $"{result} is not null ? new ({result}.Value.Out) : ";
                    }))
                    + "null;" )); 

            return $$"""
            public static void Deconstruct<{{typeGenericArgs}}>
            (
                this {{typeName}} either,
                {{outArgs}}
            ){{genericConstraints}}
            {
                var ({{assignOut}}) = either.Value;
                {{returns}}
            }

            public static void Deconstruct<{{typeGenericArgs}}>
            (
                this {{typeName}}? either,
                {{outArgs}}
            ){{genericConstraints}}
            {
                if(result is null)
                {
                    {{nullValues}}
                    return;
                }

                var ({{assignOut}}) = either.Value.Value;
                {{returns}}
            }
            """;
    }
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
