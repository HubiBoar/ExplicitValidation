namespace Definit.Validation;

public static partial class Valid
{
    public sealed class Validator<T>
        where T : notnull
    {
        public IReadOnlyCollection<Func<T, Result>> Rules => _rules;

        private readonly List<Func<T, Result>> _rules;

        public Validator()
        {
            _rules = [];
        }

        public Validator<T> AddRule(Func<T, Result> rule)
        {
            _rules.Add(rule);
            return this;
        }
    }
}
