using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class EitherBaseGenerator : IIncrementalGenerator
{
    private const string ResultType = "Definit.Results.NewApproach.IResult";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.NewApproach.GenerateEither+BaseAttribute",
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
                .ToDisplayString() == "Definit.Results.NewApproach.GenerateEither.BaseAttribute")
            .ConstructorArguments
            .Single()
            .Value!
            .ToString());

        if(count <= 2)
        {
            return ImmutableArray<(string Code, string ClassName)>.Empty;
        }

        return Enumerable.Range(2, count).Select(i =>
        {
            var generic = Enumerable.Range(0, i).Select(x => (Type: $"T{x}", Name: $"t{x}", Ret: $"t_{x}")).ToArray();
            var genericArgs = string.Join(", ", generic.Select(x => x.Type));
            var genericOrArgs = string.Join(", ", generic.Select(x => $"Or<{x.Type}>?"));

            var genericConstraints = string.Join("\n\t", generic.Select(x => $"where {x.Type} : notnull"));

            var genericPermutations = GetAllPermutations(
                generic
                    .Select((x, i) => (Type: x.Type, Name: x.Name, Index: i))
                    .ToArray())
                .Select(x => (Args: string.Join(", ", x.Select(x => x.Type)), Values: x))
                .Where(x => x.Args != genericArgs && x.Values.Count > 0)
                .Select(x => (Name: x.Values.Count == 1 ? x.Args : $"Either<{x.Args}>", Args: x.Args, Values: x.Values))
                .ToArray();

            var constructors = string.Join("\n\t", genericPermutations.Select(x => 
            {
                var arguments = generic.Select(_ => "null").ToArray();

                if(x.Values.Count == 1)
                {
                    arguments[x.Values[0].Index] = "value";
                }
                else
                {
                    for(int i = 0; i < x.Values.Count; i ++)
                    {
                        var y = x.Values[i];
                        arguments[y.Index] = $"value.Value.Item{i+1}"; 
                    }
                }

                var call = string.Join(", ", arguments);
                return $"public Either({x.Name} value) => Value = ({call});";
            }));

            var operators = string.Join("\n\t", genericPermutations
                .Select(x => $"public static implicit operator Either<{genericArgs}>({x.Name} value) => new (value);"));

            var deconstructors = string.Join("\n", 
                GenerateAllStates(generic.Length)
                .Select(state =>
                {
                    var arguments = generic.Select((x, i) => (Type: x.Type, Name: x.Name, Ret : x.Ret, IsNull : state[i]))
                    .ToImmutableArray(); 

                    return CreateDeconstruct(arguments);
                }));

            var code = new StringBuilder($$"""
            namespace Definit.Results.NewApproach;

            public interface IEither<{{genericArgs}}> : IEitherBase<({{genericOrArgs}})>
                {{genericConstraints}};

            public readonly struct Either<{{genericArgs}}> : IEither<{{genericArgs}}> 
                {{genericConstraints}}
            {
                public ({{genericOrArgs}}) Value { get; }

                [Obsolete(DefaultConstructorException.Attribute, true)]
                public Either() => throw new DefaultConstructorException();

                {{constructors}}

                public static implicit operator Either<{{genericArgs}}>(EitherMatchError error) => throw new EitherMatchException<Either<{{genericArgs}}>>();

                {{operators}}
            }

            public static partial class EitherExtensions
            {
            {{deconstructors}} 
            }
            """);

            return (code.ToString(), $"Definit.Results.NewApproach.Either_{i}");
        })
        .ToImmutableArray();
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

    private static string CreateDeconstruct(ImmutableArray<(string Type, string Name, string Ret, bool IsNull)> arguments)
    {
        var genericArgs = string.Join(", ", arguments.Select(x => x.Type));
        var outArgs = string.Join(",\n\t\t", arguments.Select(x => 
            x.IsNull
            ?
            $"out IsNull<{x.Type}>? {x.Name}"
            :
            $"out {x.Type}? {x.Name}"
            ));

        var constraints = string.Join("\n\t\t", arguments.Select(x =>
            x.IsNull
            ?
            $"where {x.Type} : class"
            :
            $"where {x.Type} : struct"));

        var values = string.Join("\n\t\t", arguments
            .Select(x => x.IsNull ? $"{x.Name} = {x.Ret}.IsNull();" : $"{x.Name} = {x.Ret};"));

        var returns = string.Join(", ", arguments.Select(x => x.Ret));

        return $$"""

            public static void Deconstruct<{{genericArgs}}>
            (
                this Either<{{genericArgs}}> result,
                {{outArgs}}
            )
                {{constraints}}
            {
                var ({{returns}}) = result.Value;

                {{values}}
            }
        """; 
    }

    private static List<List<T>> GetAllPermutations<T>(T[] numbers)
    {
        List<List<T>> result = [];

        for (int i = 1; i <= numbers.Length; i++)
        {
            CombineAndPermute(numbers, [], 0, i, result);
        }

        return result;

        static void CombineAndPermute
        (
            T[] numbers,
            List<T> currentCombination, 
            int start,
            int k,
            List<List<T>> result
        )
        {
            if (currentCombination.Count == k)
            {
                result.AddRange(GetPermutations(currentCombination));
                return;
            }

            for (int i = start; i < numbers.Length; i++)
            {
                currentCombination.Add(numbers[i]);  
                CombineAndPermute(numbers, currentCombination, i + 1, k, result);  
                currentCombination.RemoveAt(currentCombination.Count - 1);  
            }
        }

        static List<List<T>> GetPermutations(List<T> combination)
        {
            List<List<T>> result = [];
            PermuteRecursive(combination, 0, combination.Count - 1, result);
            return result;
        }

        static void PermuteRecursive(List<T> combination, int l, int r, List<List<T>> result)
        {
            if (l == r)
            {
                result.Add(new List<T>(combination));
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    Swap(combination, l, i);
                    PermuteRecursive(combination, l + 1, r, result);
                    Swap(combination, l, i);  
                }
            }
        }

        static void Swap(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
