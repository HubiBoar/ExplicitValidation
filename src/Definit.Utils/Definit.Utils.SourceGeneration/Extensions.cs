using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Definit.Utils.SourceGenerator;

public static class GenericConstraints
{
    public interface IMain
    {
        public string Name { get; }        

        public readonly struct Struct : IMain 
        {
            public string Name => "struct";
        }

        public readonly struct Class : IMain
        {
            public string Name => "class";
        }

        public readonly struct Unmanaged : IMain
        {
            public string Name => "unmanaged";
        }

        public readonly struct Notnull : IMain
        {
            public string Name => "notnull";
        }
    }

    public readonly struct New
    {
        public string Name => "new()";
    }

    public readonly struct Type
    {
        public string Name { get; }

        public Type(string name) => Name = name;
    }

    public readonly struct Holder
    {
        public string Name { get; }

        public IMain? Main { get; }

        public ImmutableArray<Type> Types { get; }

        public New? New { get; }

        private readonly string _string; 

        public Holder(string name, IMain? main, ImmutableArray<Type> types, New? @new) : this()
        {
            Name = name;
            Main = main;
            Types = types;
            New = @new;

            var mainString = main is null ? string.Empty : main.Name;
            var typesString = string.Join(", ", types.Select(x => x.Name));
            var newString = @new is null ? string.Empty : @new.Value.Name;
            var paramsString = string.Join(", ", new string[] { mainString, typesString, newString }
                    .Where(x => string.IsNullOrEmpty(x) == false));

            _string = string.IsNullOrEmpty(paramsString) ? string.Empty : $"where {Name} : {paramsString}"; 
        }

        public override string ToString() => _string;

        public static Holder Class(string name) => new Holder(name, new IMain.Class(), ImmutableArray<Type>.Empty, null);
        public static Holder Struct(string name) => new Holder(name, new IMain.Struct(), ImmutableArray<Type>.Empty, null);
        public static Holder Notnull(string name) => new Holder(name, new IMain.Notnull(), ImmutableArray<Type>.Empty, null);
        public static Holder Empty(string name) => new Holder(name, null, ImmutableArray<Type>.Empty, null);
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
        IMain? main = null;

        if(symbol.HasValueTypeConstraint)
        {
            main = new IMain.Struct();
        }
        else if(symbol.HasNotNullConstraint)
        {
            main = new IMain.Notnull();
        }
        else if(symbol.HasReferenceTypeConstraint)
        {
            main = new IMain.Class();
        }
        else if(symbol.HasUnmanagedTypeConstraint)
        {
            main = new IMain.Unmanaged();
        }

        var types = symbol.ConstraintTypes.Select(x => new GenericConstraints.Type(x.ToDisplayString())).ToImmutableArray();

        New? @new = symbol.HasConstructorConstraint ? new New() : null;

        return new Holder(symbol.ToDisplayString(), main, types, @new);
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
