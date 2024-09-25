using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Definit.Utils.SourceGenerator;

public static class Generic
{
    public enum Constraint
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

    public static bool IsNew(this Constraint main) => main switch
    {
        Constraint.New => true,
        Constraint.ClassNew => true,
        Constraint.NotnullNew => true,
        _ => false
    };

    public static void Deconstruct(this Constraint main, out string? start, out string? end) => (start, end) = main.GetString();

    public static (string? Start, string? End) GetString(this Constraint main) => main switch
    {
        Constraint.Struct           => ("struct", null),
        Constraint.Unmanaged        => ("unmanaged", null),
        Constraint.Class            => ("class", null),
        Constraint.Notnull          => ("notnull", null),
        Constraint.ClassNullable    => ("class?", null),
        Constraint.New              => (null, "new()"),
        Constraint.ClassNew         => ("class", "new()"),
        Constraint.NotnullNew       => ("notnull", "new()"),
        Constraint.ClassNullableNew => ("class?", "new()"),
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

        public Constraint Constraint { get; }

        public ImmutableArray<Type> Types { get; }

        public bool HasNullAnnotation { get; }

        public string AsString { get; } 

        public Argument(string name) : this(name, Constraint.Empty, false, ImmutableArray<Type>.Empty){}
        public Argument(string name, Constraint main) : this(name, main, false, ImmutableArray<Type>.Empty){}

        public Argument(string name, Constraint main, bool hasNullAnnotation, ImmutableArray<Type> types) : this()
        {
            Name = name;
            Constraint = main;
            Types = types;
            HasNullAnnotation = hasNullAnnotation;
            var (start, end) = main;
            var typesString = string.Join(", ", types.Select(x => x.Name));
            var paramsString = string.Join(", ", new string?[] { start, typesString, end }
                    .Where(x => string.IsNullOrEmpty(x) == false));

            AsString = string.IsNullOrEmpty(paramsString) ? string.Empty : $"where {Name} : {paramsString}"; 
        }

        public override string ToString() => AsString;

        public static Argument Class(string name)   => new Argument(name, Generic.Constraint.Class);
        public static Argument Struct(string name)  => new Argument(name, Generic.Constraint.Struct);
        public static Argument Notnull(string name) => new Argument(name, Generic.Constraint.Notnull);
        public static Argument Empty(string name)   => new Argument(name);
        public static Argument Struct(string name, params string[] types)
            => new Argument(name, Generic.Constraint.Struct, false, types.Select(x => new Type(x)).ToImmutableArray());
        public static Argument Struct(string name, params Type[] types)
            => new Argument(name, Generic.Constraint.Struct, false, types.ToImmutableArray());
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
            AsString = value.Length == 0 ? string.Empty : "\n\t" + string.Join("\n\t", value.Select(x => x.ToString()));
        }


        public override string ToString() => AsString;
    }
    
    public static Argument GetGenericArgument(this ITypeParameterSymbol symbol) 
    {
        Constraint constraint = Constraint.Empty;

        var hasNullableAnnotation = symbol.NullableAnnotation is NullableAnnotation.Annotated;

        if(symbol.HasValueTypeConstraint)
        {
            constraint = Constraint.Struct;
        }
        else if(symbol.HasUnmanagedTypeConstraint)
        {
            constraint = Constraint.Unmanaged;
        }
        else if(symbol.HasNotNullConstraint)
        {
            constraint = symbol.HasConstructorConstraint ? Constraint.NotnullNew : Constraint.Notnull;
        }
        else if(symbol.HasReferenceTypeConstraint)
        {
            if(symbol.ReferenceTypeConstraintNullableAnnotation is not NullableAnnotation.Annotated)
            {
                constraint = symbol.HasConstructorConstraint ? Constraint.ClassNew : Constraint.Class;
            }
            else
            {
                constraint = symbol.HasConstructorConstraint ? Constraint.ClassNullableNew : Constraint.ClassNullable;
            }
        }
        else if(symbol.HasConstructorConstraint)
        {
            constraint = Constraint.New;
        }

        var types = symbol.ConstraintTypes.Select(x => new Generic.Type(x.ToDisplayString())).ToImmutableArray();

        return new Argument(symbol.ToDisplayString(), constraint, hasNullableAnnotation, types);
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
