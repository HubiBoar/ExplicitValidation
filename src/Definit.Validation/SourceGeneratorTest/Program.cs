using SampleSourceGenerator;
using NewApproach;
using Definit.Results;

Console.WriteLine(ClassNames.TypesList);

namespace Examples
{
    public readonly partial struct Email : IIsValid<string>
    {
        public void Rule(Rule<string> rule) => rule.NotNull();
    }

    public static partial class Parent1
    {
        public readonly partial struct Value1 : IIsValid<string>
        {
            public void Rule(Rule<string> rule) => rule.NotNull();
        }
    }

    public static class ExampleValue
    {
        private static async Task<Result> Endpoint(Email body)
        {
            if(body.IsValid().Is(out Error error).Else(out var valid))
            {
                return error;
            }

            return await Run(valid);
        }

        private static async Task<Result> Run(Valid<Email> valid)
        {
            await Task.CompletedTask;
            return Result.Success;
        }
    }
}
