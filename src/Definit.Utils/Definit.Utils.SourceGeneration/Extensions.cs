using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Definit.Utils.SourceGenerator;

public static class GenericConstraints
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

    public readonly struct Holder
    {
        public string Name { get; }

        public Main Main { get; }

        public ImmutableArray<Type> Types { get; }

        public string AsString { get; } 

        public Holder(string name) : this(name, Main.Empty, ImmutableArray<Type>.Empty){}
        public Holder(string name, Main main) : this(name, main, ImmutableArray<Type>.Empty){}

        public Holder(string name, Main main, ImmutableArray<Type> types) : this()
        {
            Name = name;
            Main = main;
            Types = types;

            var (start, end) = main.GetString();
            var typesString = string.Join(", ", types.Select(x => x.Name));
            var paramsString = string.Join(", ", new string?[] { start, typesString, end }
                    .Where(x => string.IsNullOrEmpty(x) == false));

            AsString = string.IsNullOrEmpty(paramsString) ? string.Empty : $"where {Name} : {paramsString}"; 
        }

        public override string ToString() => AsString;

        public static Holder Class(string name)   => new Holder(name, GenericConstraints.Main.Class);
        public static Holder Struct(string name)  => new Holder(name, GenericConstraints.Main.Struct);
        public static Holder Notnull(string name) => new Holder(name, GenericConstraints.Main.Notnull);
        public static Holder Empty(string name)   => new Holder(name);
    }

    public readonly struct Holders
    {
        public ImmutableArray<Holder> Value { get; }

        public Holders(ImmutableArray<Holder> value)
        {
            Value = value;
        }
    }
    
    public static Holder GetConstraints(this ITypeParameterSymbol symbol) 
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

        var types = symbol.ConstraintTypes.Select(x => new GenericConstraints.Type(x.ToDisplayString())).ToImmutableArray();

        return new Holder(symbol.ToDisplayString(), main, types);
    }

    public static bool HasConstraints(this ITypeParameterSymbol symbol) =>  
        symbol.ConstraintTypes.Length > 0
        || symbol.HasValueTypeConstraint
        || symbol.HasNotNullConstraint
        || symbol.HasReferenceTypeConstraint
        || symbol.HasUnmanagedTypeConstraint
        || symbol.HasConstructorConstraint;

    public static Holders GetGenericConstraints(this IEnumerable<ITypeSymbol> typeArguments)
    {
        var parameters = 
            typeArguments
            .OfType<ITypeParameterSymbol>()
            .Where(HasConstraints)
            .ToArray();

        if(parameters.Length == 0)
        {
            return new Holders(ImmutableArray<GenericConstraints.Holder>.Empty);
        }

        return new Holders
        (
            parameters
                .Select(GetConstraints)
                .ToImmutableArray()
        );
    }

    public static Holders GetMethodGenericConstraints(this IMethodSymbol method)
    {
        var isGeneric = method.IsGenericMethod;

        if(isGeneric is false)
        {
            return new Holders(ImmutableArray<GenericConstraints.Holder>.Empty);
        }

        return method.TypeArguments.GetGenericConstraints();
    }

    public static string ConstraintsToString(this ImmutableArray<Holder> holders) 
    {
        return "\n\t" + string.Join("\n\t", holders.Select(x => x.ToString()));
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
