#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

public static class Examples__Auto__Extensions
{
    public static Wrapper Results(this Definit.Resultss.Examples.Examples value)
    {
        return new Wrapper() { Value = value };
    }

    public readonly struct Wrapper
    {
        public required Definit.Resultss.Examples.Examples Value { get; init; }

        public Definit.Results.Either<int, string, Definit.Resultss.Examples.NotFound> PublicRun(int i) 
		{
		    try
		    {
		        return new Definit.Results.Either<int, string, Definit.Resultss.Examples.NotFound>(this.Value.PublicRun(i));
		    }
		    catch (Exception exception)
		    {
		        return new Definit.Results.Either<int, string, Definit.Resultss.Examples.NotFound>(Error.Matches(exception).Error);
		    }
		}
    }
}