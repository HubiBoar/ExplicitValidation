using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Definit.Utils.SourceGenerator;

public static class Generic
{
    public enum Main
    {
        Empty,

        Struct,
        Unmanaged,

        Class,
        Notnull,
        ClassNullable,

        New,
        ClassNew,
        NotnullNew,
        ClassNullableNew,
    }

    public static bool IsNew(this Main main) => main switch
    {
        Main.New => true,
        Main.ClassNew => true,
        Main.NotnullNew => true,
        _ => false
    };

    public static void Deconstruct(this Main main, out string? start, out string? end) => (start, end) = main.GetString();

    public static (string? Start, string? End) GetString(this Main main) => main switch
    {
        Main.Struct           => ("struct", null),
        Main.Unmanaged        => ("unmanaged", null),
        Main.Class            => ("class", null),
        Main.Notnull          => ("notnull", null),
        Main.ClassNullable    => ("class?", null),
        Main.New              => (null, "new()"),
        Main.ClassNew         => ("class", "new()"),
        Main.NotnullNew       => ("notnull", "new()"),
        Main.ClassNullableNew => ("class?", "new()"),
        _                     => (null, null),
    };

    public readonly struct Type
    {
        public string Name { get; }

        public Type(string name)
        {
            Name = name;
        }
    }

    public readonly struct Argument
    {
        public string Name { get; }

        public Main Main { get; }

        public ImmutableArray<Type> Types { get; }

        public string AsString { get; } 

        public Argument(string name) : this(name, Main.Empty, ImmutableArray<Type>.Empty){}
        public Argument(string name, Main main) : this(name, main, ImmutableArray<Type>.Empty){}

        public Argument(string name, Main main, ImmutableArray<Type> types) : this()
        {
            Name = name;
            Main = main;
            Types = types;

            var (start, end) = main;
            var typesString = string.Join(", ", types.Select(x => x.Name));
            var paramsString = string.Join(", ", new string?[] { start, typesString, end }
                    .Where(x => string.IsNullOrEmpty(x) == false));

            AsString = string.IsNullOrEmpty(paramsString) ? string.Empty : $"where {Name} : {paramsString}"; 
        }

        public override string ToString() => AsString;

        public static Argument Class(string name)   => new Argument(name, Generic.Main.Class);
        public static Argument Struct(string name)  => new Argument(name, Generic.Main.Struct);
        public static Argument Notnull(string name) => new Argument(name, Generic.Main.Notnull);
        public static Argument Empty(string name)   => new Argument(name);
        public static Argument Struct(string name, params string[] types)
            => new Argument(name, Generic.Main.Struct, types.Select(x => new Type(x)).ToImmutableArray());
        public static Argument Struct(string name, params Type[] types)
            => new Argument(name, Generic.Main.Struct, types.ToImmutableArray());
    }

    public readonly struct Arguments
    {
        public ImmutableArray<Argument> Value { get; }

        public string AsString { get; }
        public string ArgumentNames { get; }

        public Arguments(Arguments arg, params Argument[] value) : this(arg.Value.Concat(value).ToImmutableArray()) {}
        public Arguments(params Argument[] value) : this(value.ToImmutableArray()) {}
        public Arguments(Arguments value, Arguments value2) : this(value.Value.Concat(value2.Value).ToImmutableArray()) {}
        
        public Arguments(ImmutableArray<Argument> value)
        {
            Value = value;
            ArgumentNames = string.Join(", ", value.Select(x => x.Name));
            AsString = "\n\t" + string.Join("\n\t", value.Select(x => x.ToString()));
        }


        public override string ToString() => AsString;
    }
    
    public static Argument GetGenericArgument(this ITypeParameterSymbol symbol) 
    {
        Main main = Main.Empty;

        if(symbol.HasValueTypeConstraint)
        {
            main = Main.Struct;
        }
        else if(symbol.HasUnmanagedTypeConstraint)
        {
            main = Main.Unmanaged;
        }
        else if(symbol.HasNotNullConstraint)
        {
            main = symbol.HasConstructorConstraint ? Main.NotnullNew : Main.Notnull;
        }
        else if(symbol.HasReferenceTypeConstraint)
        {
            if(symbol.ReferenceTypeConstraintNullableAnnotation is not NullableAnnotation.Annotated)
            {
                main = symbol.HasConstructorConstraint ? Main.ClassNew : Main.Class;
            }
            else
            {
                main = symbol.HasConstructorConstraint ? Main.ClassNullableNew : Main.ClassNullable;
            }
        }
        else if(symbol.HasConstructorConstraint)
        {
            main = Main.New;
        }

        var types = symbol.ConstraintTypes.Select(x => new Generic.Type(x.ToDisplayString())).ToImmutableArray();

        return new Argument(symbol.ToDisplayString(), main, types);
    }

    public static Arguments GetGenericArguments(this IEnumerable<ITypeSymbol> typeArguments)
    {
        var parameters = 
            typeArguments
            .OfType<ITypeParameterSymbol>()
            .ToArray();

        if(parameters.Length == 0)
        {
            return new Arguments(ImmutableArray<Generic.Argument>.Empty);
        }

        return new Arguments
        (
            parameters
                .Select(GetGenericArgument)
                .ToImmutableArray()
        );
    }

    public static Arguments GetMethodGenericArguments(this IMethodSymbol method)
    {
        var isGeneric = method.IsGenericMethod;

        if(isGeneric is false)
        {
            return new Arguments(ImmutableArray<Generic.Argument>.Empty);
        }

        return method.TypeArguments.GetGenericArguments();
    }
}

public static class LinqExtensions
{
    public static IEnumerable<TSource> DistinctBy<TSource, TKey>
    (
        this IEnumerable<TSource> source,
        Func<TSource, TKey> keySelector
    )
    {
        var keys = new HashSet<TKey>();
        foreach (var element in source)
        {
            if (keys.Contains(keySelector(element))) continue;
            keys.Add(keySelector(element));
            yield return element;
        }
    }

    public static T[][] Chunk<T>(this T[] arr, int size)
    {
        List<T[]> result = [];
        for (var i = 0; i < arr.Length / size + 1; i++)
        {
            result.Add(arr.Skip(i * size).Take(size).ToArray());
        }

        return result.ToArray();
    }
}

public static class GeneratorExtensions
{
    public static string GetCallingParameters(this IMethodSymbol method)
    {
        var parametersCall = method.Parameters.Select(x => GetParam(x)).ToArray();

        return string.Join(", ", parametersCall);

        static string GetParam(IParameterSymbol p)
        {
            return p.RefKind switch
            {
                RefKind.Ref => $"ref {p.Name}", 
                RefKind.In => $"in {p.Name}", 
                RefKind.Out => $"out {p.Name}",  
                RefKind.RefReadOnlyParameter => $"ref readonly {p.Name}", 
                _ => p.Name
            };
        }
    }

    public static bool IsUnsafe(this IMethodSymbol method)
    {
        return method.Parameters.Select(x => x.Type).Any(x => x.TypeKind == TypeKind.Pointer);
    }

    public static string GetMethodGenericArgs(this IMethodSymbol method)
    {
        var isGeneric = method.IsGenericMethod;

        if(isGeneric is false)
        {
            return string.Empty;
        }

        var genericParams = string.Join(", ", method.TypeArguments.Select(x => x.ToDisplayString()));

        return $"<{genericParams}>";
    }
}
