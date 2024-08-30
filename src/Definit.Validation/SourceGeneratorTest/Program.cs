using SampleSourceGenerator;
using NewApproach;
using Definit.Results;

Console.WriteLine(ClassNames.TypesList);

namespace Examples
{
    public partial record Email() : IsValid<string>(Rule.NotNull.Min(5));

    public static partial class Parent1
    {
        public partial record Value1() : IsValid<string>(Rule.NotNull.Min(5));
    }

    public static class ExampleValue
    {
        private static async Task<Result> Endpoint(Email body)
        {
            if(body.IsValid.Is(out Error error).Else(out var valid))
            {
                return error;
            }

            return await Run(valid);
        }

        private static async Task<Result> Run(Email.Valid valid)
        {
            await Task.CompletedTask;
            return Result.Success;
        }
    }
}
