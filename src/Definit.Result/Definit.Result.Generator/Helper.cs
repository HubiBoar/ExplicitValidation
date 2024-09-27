using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

internal static class LinqExtensions
{
    private const string ResultType = "Definit.Results.IResultBase";

    public static T[][] Chunk<T>(this T[] arr, int size)
    {
        if(size <= 0)
        {
            size = 1;
        }

        List<T[]> result = [];
        for (var i = 0; i < arr.Length / size + 1; i++)
        {
            result.Add(arr.Skip(i * size).Take(size).ToArray());
        }

        return result.ToArray();
    }

    public static string? GetEitherFromResult(this ITypeSymbol symbol)
    {
        if(symbol is INamedTypeSymbol type)
        {
            var either = type.AllInterfaces.SingleOrDefault(x => x.ToDisplayString().StartsWith(ResultType))
                ?.TypeArguments
                .Single();

            return either is not null ? either.ToDisplayString() : null; 
        }

        return null;
    }
}
