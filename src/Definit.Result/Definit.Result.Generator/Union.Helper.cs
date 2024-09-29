using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

internal static class Helper
{
    public const string Namespace = "Definit.Results";
    public const string TypeName = $"U";
    public const string TypeNameWithNamespace = $"{Namespace}.{TypeName}";
    public const string InterfaceName = $"IUnionBase";

    public static class Types
    {
        public const string Success = "Definit.Results.Success";
        public const string Error = "Definit.Results.Success";
    }

    public static class Base
    {
        public const bool Activated = false;
        public const int Count = 10;
        public const int MaxDeconstructorsCount = 8;
    }

    public static string GenericTypeName(Generic.Elements elements) => $"{TypeName}{elements.ArgumentNamesFull}";

    public static Generic.Elements Generics(int count) => 
        new Generic.Elements
        (
            Enumerable
                .Range(0, count)
                .Select(x => Generic.Argument.Notnull($"T{x}"))
                .ToImmutableArray()
        );

    public static (Generic.Element First, Generic.Element Second) Generics0() => 
    (
        Generic.Argument.Notnull(Types.Success),
        Generic.Argument.Notnull(Types.Error)
    );

    public static (Generic.Element First, Generic.Element Second) Generics1() => 
    (
        Generic.Argument.Notnull("T"),
        Generic.Argument.Notnull(Types.Error)
    );
}

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
