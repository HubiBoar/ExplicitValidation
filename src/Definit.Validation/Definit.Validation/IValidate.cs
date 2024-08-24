using Definit.Results;

namespace Definit.Validation;

public interface IValidate
{
    public virtual Result Validate(string? propertyName = null)
    {
        return GetType()
            .GetProperties()
            .Where(x => x.PropertyType.IsAssignableFrom(typeof(IValidate)))
            .Select(x => 
            {
                var value  = x.GetValue(this);
                var casted = (IValidate)value!;
                var result = casted.Validate(x.Name);

                return result;
            })
            .Merge(propertyName);
    }
}
