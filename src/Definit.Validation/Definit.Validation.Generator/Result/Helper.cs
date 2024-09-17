namespace Definit.Results.Generator;

internal static class LinqExtensions
{
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
