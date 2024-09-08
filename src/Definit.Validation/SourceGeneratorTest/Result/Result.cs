using System.Diagnostics.CodeAnalysis;

namespace Definit.NewApproach;

public sealed class EitherAttribute<T0, T1> : Attribute, Result.IGenerator
    where T0: notnull
    where T1: notnull
{
    public static string Generate(string typeName) => $$"""
    public record partial struct {{typeName}}<T0, T1> : IEither<T0, T1>
        where T0 : notnull
        where T1 : notnull
    {
        public (Null<T0>?, Null<T1>?) Value { get; }
        
        [Obsolete("Must not be used without parameters", true)]
        public {{typeName}}() {}

        public {{typeName}}(T0 value)
        {
            Value = (value, null);
        }

        public {{typeName}}(T1 value)
        {
            Value = (null, value);
        }

        public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Value;

        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Result.NullError value) => throw new Exception(typeof(Either<T0,T1>).Name);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] T0 value) => new (value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] T1 value) => new (value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Null<T0> value) => new (value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Null<T1> value) => new (value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Null<T0>? value) => new (value!.Value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Null<T1>? value) => new (value!.Value);
    }
    """;
}

public sealed class ResultAttribute<T0, T1> : Attribute, Result.IGenerator
    where T0: notnull
    where T1: notnull, IError<T1>
{
    public static string Generate(string typeName) => $$"""
    public readonly partial struct {{typeName}}<T0, T1> : IResult<T0, T1>
        where T0 : notnull
        where T1 : notnull, IError<T1>
    {
        public readonly struct Value : IEither<T0, T1>
        {
            public Either<T0, T1> Result { get; }

            (Null<T0>?, Null<T1>?) IEither<T0, T1>.Value => Result.Value;

            [Obsolete("Must not be used without parameters", true)]
            public Value() {}

            internal Value({{typeName}}<T0, T1> result)
            {
                Result = result._value;
            }

            public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Result;
        }

        private readonly Either<T0, T1> _value;

        [Obsolete("Must not be used without parameters", true)]
        public {{typeName}}() {}

        internal {{typeName}}(Either<T0, T1> value)
        {
            _value = value;
        }

        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Result.NullError value) => new (value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] T0 value) => new (value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] T1 value) => new (value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Null<T0> value) => new (value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Null<T1> value) => new (value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Null<T0>? value) => new (value!.Value);
        public static implicit operator {{typeName}}<T0, T1>([DisallowNull] Null<T1>? value) => new (value!.Value);
    }
    """;
}

public interface IError<TSelf>
    where TSelf : notnull, IError<TSelf>
{
    public abstract static TSelf Create(Exception exception); 
}

public static class Result
{
    public interface IGenerator
    {
        public abstract static string Generate(string typeName);
    }

    public interface IKeyword {}

    public sealed class MethodAttribute<T> : Attribute
        where T : Result.IKeyword
    {
    }

    public readonly struct Public : IKeyword;
    public readonly struct Private : IKeyword;

    public sealed record NullError();

    public static readonly NullError Null = new (); 
}

public static class Extensions
{
    public static void Deconstruct<T0, T1>(this Null<Either<T0, T1>> value, out Null<T0>? t0, out Null<T1>? t1)
        where T0 : notnull
        where T1 : notnull
    {
        (t0, t1) = value.Value;
    }
}

public readonly struct Null<T>
    where T : notnull
{
    public required T Value { get; init; }

    public static implicit operator T(Null<T> value) => value.Value;
    public static implicit operator Null<T>(T value) => new() { Value = value };
}

public interface IEither<T0, T1>
    where T0: notnull
    where T1: notnull
{
    public (Null<T0>?, Null<T1>?) Value { get; }

    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Value;
}

public interface IResult<T0, T1>
    where T0 : notnull
    where T1 : notnull, IError<T1>
{
}

public readonly struct Result<T0, T1> : IResult<T0, T1>
    where T0 : notnull
    where T1 : notnull, IError<T1>
{
    public readonly struct Value : IEither<T0, T1>
    {
        public Either<T0, T1> Result { get; }

        (Null<T0>?, Null<T1>?) IEither<T0, T1>.Value => Result.Value;

        [Obsolete("Must not be used without parameters", true)]
        public Value() {}

        internal Value(Result<T0, T1> result)
        {
            Result = result._value;
        }

        public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Result;
    }

    private readonly Either<T0, T1> _value;

    [Obsolete("Must not be used without parameters", true)]
    public Result() {}

    internal Result(Either<T0, T1> value)
    {
        _value = value;
    }

    public static implicit operator Result<T0, T1>([DisallowNull] Result.NullError value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] T0 value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] T1 value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] Null<T0> value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] Null<T1> value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] Null<T0>? value) => new (value!.Value);
    public static implicit operator Result<T0, T1>([DisallowNull] Null<T1>? value) => new (value!.Value);
}

public record struct Either<T0, T1> : IEither<T0, T1>
    where T0 : notnull
    where T1 : notnull
{
    public (Null<T0>?, Null<T1>?) Value { get; }
    
    [Obsolete("Must not be used without parameters", true)]
    public Either() {}

    public Either(T0 value)
    {
        Value = (value, null);
    }

    public Either(T1 value)
    {
        Value = (null, value);
    }

    internal Either((Null<T0>?, Null<T1>?) value)
    {
        Value = value;
    }

    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Value;

    public static implicit operator Either<T0, T1>([DisallowNull] Result.NullError value) => throw new Exception(typeof(Either<T0,T1>).Name);
    public static implicit operator Either<T0, T1>([DisallowNull] T0 value) => new (value);
    public static implicit operator Either<T0, T1>([DisallowNull] T1 value) => new (value);
    public static implicit operator Either<T0, T1>([DisallowNull] Null<T0> value) => new (value);
    public static implicit operator Either<T0, T1>([DisallowNull] Null<T1> value) => new (value);
    public static implicit operator Either<T0, T1>([DisallowNull] Null<T0>? value) => new (value!.Value);
    public static implicit operator Either<T0, T1>([DisallowNull] Null<T1>? value) => new (value!.Value);
}
