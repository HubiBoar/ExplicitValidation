using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

//[Generator]
internal sealed class UnionBaseGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.CreateSyntaxProvider
        (
            predicate: static (_, _) => true,

            transform: static (n, _) => (n)
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation
    )
    {
        SourceHelper.Run(context, Run);
    }

    private static ImmutableArray<Func<(string Code, string FileName)>> Run()
    {
        return
        Enumerable
            .Range(2, Helper.Base.Count - 2)
            .Select<int, Func<(string, string)>>(i => () => Generate(i))
            .ToImmutableArray();
    }

    private static (string Code, string FileName) Generate(int count)
    {
        var allGenerics = Helper.Generics(count); 
        var constructorName = Helper.TypeName;
        var genericTypeName = Helper.GenericTypeName(allGenerics); 

        string extensionsName = Helper.ExtensionsTypeName(count);
        string fileName = Helper.FileTypeName(count); 

        var setupCode = CreateType
        (
            allGenerics,
            allGenerics,
            constructorName, 
            genericTypeName,
            extensionsName
        );

        return (setupCode, fileName);
    }

    private static string CreateType
    (
        Generic.Elements allGenericParams,
        Generic.Elements typeGenericParams,
        string constructorName,
        string typeName,
        string extensionsName
    )
    {
        var (interior, extension, genericOrArgs) = GetInterior
        (
            allGenericParams,
            typeGenericParams,
            constructorName,
            typeName
        );

        var infoName = $"{Helper.InterfaceInfoName}{allGenericParams.ArgumentNamesFull}";
        interior = string.Join("\n\t", interior.Split('\n'));
        extension = string.Join("\n\t", extension.Split('\n'));

        return $$"""
        #nullable enable

        using System.Diagnostics.CodeAnalysis;

        namespace {{Helper.Namespace}};

        public interface {{infoName}} : {{Helper.InterfaceName}}<({{genericOrArgs}})>{{typeGenericParams.ConstraintsString}};

        public readonly struct {{typeName}} : {{typeName}}.Base{{typeGenericParams.ConstraintsString}} 
        {
            public interface Base : {{infoName}};

            {{interior}}
        }

        public static class {{extensionsName}}
        {
            {{extension}}
        }
        """;
    }

    public static (string Interior, string Extensions, string GenericOrArgs) GetInterior
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

        public static implicit operator {{typeName}}([DisallowNull] {{Helper.UnionMatchError}} _) => throw new {{Helper.UnionMatchException}}<{{Helper.TypeName}}<{{genericArgs}}>>();
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

        var typeGenericArgs = typeGenericParams.Value.Length > 0
            ? 
            "<" + string.Join(", ", typeGenericParams.Value.Select(x => x.Name)) + ">"
            :
            string.Empty;

        if(length <= Helper.Base.MaxDeconstructorsCount)
        {
            var generic = allGenericParams.Value.Select((x, i) => (Type: x, Return: $"_arg_{i}", Assign: $"_out_{i}")).ToArray();
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
                public static void Deconstruct{{typeGenericArgs}}
                (
                    this {{typeName}} either,
                    {{outArgs}}
                ){{genericConstraints.ConstraintsString}}
                {
                    var ({{returns}}) = either.Value;
                    {{assignments}}
                }

                public static void Deconstruct{{typeGenericArgs}}
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
            int roundedUp = (int)Math.Ceiling((double)length / Helper.Base.MaxDeconstructorsCount); 
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
                .Select((x, i) => (Type: $"{Helper.TypeName}<" + string.Join(", ", x.Generics.Select(e => e.Name)) + ">", Name: $"_arg_{i}", Generic: x))
                .ToArray();

            var outArgs = string.Join(",\n\t", eitherGenericsArgs.Select((x) => $"out {x.Type}? {x.Name}"));
            var nullValues = string.Join(" ", eitherGenericsArgs.Select(x => $"{x.Name} = null;"));
            var genericConstraints = allGenericParams.ConstraintsString;
            var results = Enumerable.Range(0, length).Select(x => $"_out_{x}").ToArray();
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
            public static void Deconstruct{{typeGenericArgs}}
            (
                this {{typeName}} either,
                {{outArgs}}
            ){{genericConstraints}}
            {
                var ({{assignOut}}) = either.Value;
                {{returns}}
            }

            public static void Deconstruct{{typeGenericArgs}}
            (
                this {{typeName}}? either,
                {{outArgs}}
            ){{genericConstraints}}
            {
                if(either is null)
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
