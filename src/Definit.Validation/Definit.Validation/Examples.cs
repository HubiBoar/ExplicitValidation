using Definit.Results;

namespace Definit.Validation;

internal static partial class Example
{
    public readonly record struct Type<T>(T Value)
    {
        public static implicit operator T(Type<T> value) => throw new Exception();
    }

    public readonly record struct Either<T0, T1>
        where T0 : notnull
        where T1 : notnull
    {
        public Either(T0 value) {}
        public Either(T1 value) {}
        public static implicit operator Either<T0, T1>(T0 value) => throw new Exception();
        public static implicit operator Either<T0, T1>(T1 value) => throw new Exception();
    }

    public static void Get<T0, T1>(Type<T0>? t0, Type<T1>? t1, out Either<T0, T1>? either)
        where T0 : notnull
        where T1 : notnull
    {
        either = t0 is not null ? new (t0.Value) : t1 is not null ? new (t1.Value) : null;
    }

    [IsValid<string>]
    private partial struct Email
    {
        public static void Rule(Rule<string> rule) => rule.NotNull();
    }

    public static partial class Parent1
    {
        [IsValid<string>]
        public partial struct Value1
        {
            public static void Rule(Rule<string> rule) => rule.NotNull();
        }
    }

    [IsValid]
    private partial record UserData
    (
        string Name,
        Email Email,
        Address Address
    );

    [IsValid]
    private partial record Address
    (
        string PostalCode,
        Email EmailProp
    );

    private static async Task<Result.Error<ValidationError>> Endpoint(UserData body)
    {
        if(body.IsValid().IsError(out var error, out var valid))
        {
            return error.Value;
        }

        return await Run(valid.NotNull().Address);
    }

    private static async Task<Result.Error<ValidationError>> Run(Address.Valid valid)
    {
        await Task.CompletedTask;
        return Result.Success;
    }

    private static async Task<Result.Error<ValidationError>> Endpoint(Email body)
    {
        if(body.IsValid().IsError(out var error, out var valid))
        {
            return error.Value;
        }

        return await Run(valid.NotNull());
    }

    private static async Task<Result> Run(Email.Valid valid)
    {
        await Task.CompletedTask;
        return Result.Success;
    }
}

partial class Example
{
    partial class Parent1
    {

    }
}

