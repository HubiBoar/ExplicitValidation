using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Definit.Utils.SourceGenerator;

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

    public static string GetMethodGenericConstraints(this IMethodSymbol method)
    {
        var isGeneric = method.IsGenericMethod;

        if(isGeneric is false)
        {
            return string.Empty;
        }

        return method.TypeArguments.GetGenericConstraints();
    }

    public static string GetGenericConstraints(this IEnumerable<ITypeSymbol> typeArguments)
    {
        var parameters = 
            typeArguments
            .OfType<ITypeParameterSymbol>()
            .Where(HasConstraints)
            .ToArray();

        if(parameters.Length == 0)
        {
            return string.Empty;
        }

        return "\n\t" + string.Join("\n\t", parameters.Select(ConstraintsToString)); 
    }

    public static string ConstraintsToString(this ITypeParameterSymbol symbol) 
    {
        List<string> builder = new ();

        if(symbol.HasValueTypeConstraint)
        {
            builder.Add("struct");
        }

        if(symbol.HasNotNullConstraint)
        {
            builder.Add("notnull");
        }

        if(symbol.HasReferenceTypeConstraint)
        {
            builder.Add("class");
        }

        if(symbol.HasUnmanagedTypeConstraint)
        {
            builder.Add("unmanaged");
        }

        foreach(var type in symbol.ConstraintTypes)
        {
            builder.Add($"{type.ToDisplayString()}");
        }

        if(symbol.HasConstructorConstraint)
        {
            builder.Add("new()");
        }

        var constraints = string.Join(", ", builder);
        var name = symbol.ToDisplayString();

        return $"where {name} : {constraints}";
    }

    public static bool HasConstraints(this ITypeParameterSymbol symbol) =>  
        symbol.ConstraintTypes.Length > 0
        || symbol.HasValueTypeConstraint
        || symbol.HasNotNullConstraint
        || symbol.HasReferenceTypeConstraint
        || symbol.HasUnmanagedTypeConstraint
        || symbol.HasConstructorConstraint;
}
