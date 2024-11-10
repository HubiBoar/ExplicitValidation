using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

internal static class Helper
{
    public const string Namespace             = "Definit.Results";
    public const string TypeName              = $"R";
    public const string TypeNameWithNamespace = $"{Namespace}.{TypeName}";
    public const string InterfaceName         = $"IUnionBase";
    public const string InterfaceNameWithNamespace = $"{Namespace}.{InterfaceName}";

    public const string MaybeTypeName         = $"Opt";
    public const string UnionMatchException = $"{Helper.Namespace}.UnionMatchException"; 
    public const string UnionMatchError = $"{Helper.Namespace}.UnionMatchError"; 

    public static string ResultError(string type) => $"{Helper.TypeName}<{type}, {Error}>";
    public static string UnionMaybeError(string type) => $"{Helper.TypeName}<{Maybe(type)}, {Error}>";
    public static string Maybe(string type) => $"{MaybeTypeName}<{type}>";

    public const string CastingMethodName  = $"Try";
    public const string CastingWrapperName = $"UnionsWrapper";

    public const string Success = $"{Helper.Namespace}.Success";
    public const string SuccessInstance = $"{Helper.Namespace}.Union.Success";

    public const string Error = $"System.Exception";

    public static class Attributes
    {
        public const string GenerateUnion = $"{Helper.Namespace}.GenerateUnionAttribute";

        public const string GenerateUnionThis     = $"{Helper.Namespace}.GenerateUnion.ThisAttribute";
        public const string GenerateUnionThisMeta = $"{Helper.Namespace}.GenerateUnion+ThisAttribute";

        public const string GenerateUnionObject     = $"{Helper.Namespace}.GenerateUnion.ObjectAttribute";
        public const string GenerateUnionObjectMeta = $"{Helper.Namespace}.GenerateUnion+ObjectAttribute";

        public const string GenerateUnionObjectGeneric     = $"{Helper.Namespace}.GenerateUnion.ObjectAttribute";
        public const string GenerateUnionObjectGenericMeta = $"{Helper.Namespace}.GenerateUnion+ObjectAttribute`1";
    }

    public static class Async
    {
        public const string TaskPrefix = "System.Threading.Tasks.Task";
        public const string ValueTaskPrefix = "System.Threading.Tasks.ValueTask";
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

    public static INamedTypeSymbol? IsUnion(ITypeSymbol symbol)
    {
        var union = symbol.Interfaces
            .SingleOrDefault(x => x.AllInterfaces
                .Any(y => y
                    .ToDisplayString()
                    .Equals(InterfaceNameWithNamespace)))
            ?.ContainingType;

        if(union is null)
        {
            return null;
        }

        return union;
    }

    public static INamedTypeSymbol? IsResult(ITypeSymbol symbol)
    {
        var union = symbol.Interfaces
            .SingleOrDefault(x => x.AllInterfaces
                .Any(y => y
                    .ToDisplayString()
                    .Equals(InterfaceNameWithNamespace)))
            ?.ContainingType;

        if(union is null)
        {
            return null;
        }

        return union;
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
