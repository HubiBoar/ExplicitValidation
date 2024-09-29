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

    public const string CastingMethodName = $"Results";
    public const string CastingWrapperName = $"UnionsWrapper";

    public static class Attributes
    {
        public const string GenerateUnion = $"{Helper.Namespace}.GenerateUnionAttribute";

        public const string GenerateUnionObject = $"{Helper.Namespace}.GenerateUnion.ObjectAttribute";
        public const string GenerateUnionObjectMeta = $"{Helper.Namespace}.GenerateUnion+ObjectAttribute";
    }

    public static class Types
    {
        public const string HelperTypeName = $"Union";

        public const string Success = $"{Helper.Namespace}.Success";
        public const string SuccessInstance = $"{Helper.Namespace}.{HelperTypeName}.Success";

        public const string Error = $"{Helper.Namespace}.Error";

        public static string UnionError(string type) => $"{Helper.TypeName}<{type}, {Error}>";
        public static string UnionMaybeError(string type) => $"{Helper.TypeName}<Maybe<{type}>, {Error}>";
    }

    public static class Base
    {
        public const bool Activated = false;
        public const int Count = 10;
        public const int MaxDeconstructorsCount = 8;
    }

    public static string GenericTypeName(Generic.Elements elements) => $"{TypeName}{elements.ArgumentNamesFull}";
    public static string ExtensionsTypeName(int count) => $"Extensions_{TypeName}_{count}";
    public static string ExtensionsTypeName(string typeName) => $"{typeName}_Extensions_{TypeName}";
    public static string FileTypeName(int count) => $"{TypeNameWithNamespace}_{count}";

    public static Generic.Elements Generics(int count) => 
        new Generic.Elements
        (
            Enumerable
                .Range(0, count)
                .Select(x => Generic.Argument.Notnull($"T{x}"))
                .ToImmutableArray()
        );

    public static (Generic.Element Success, Generic.Element Error) Generics0() => 
    (
        Generic.Argument.Notnull(Types.Success),
        Generic.Argument.Notnull(Types.Error)
    );

    public static (Generic.Element T, Generic.Element Error) Generics1() => 
    (
        Generic.Argument.Notnull("T"),
        Generic.Argument.Notnull(Types.Error)
    );

    public static (string Name, Generic.Elements Generics)? IsUnion(ITypeSymbol symbol)
    {
        var union = symbol.AllInterfaces
            .SingleOrDefault(x => x.AllInterfaces.Any(y => y
                .ToDisplayString()
                .StartsWith(InterfaceName)))
            ?.ContainingType;

        if(union is null)
        {
            return null;
        }

        return (union.ToDisplayString(), union.TypeArguments.GetGenericArguments());
    }
}

internal static class LinqExtensions
{
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
}
