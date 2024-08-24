using Definit.Results;

namespace Definit.Validation;

public interface IValidate
{
    public virtual Result Validate(string? propertyName = null)
    {
        return DefaultValidate(this, propertyName);
    }

    public static Result DefaultValidate(object obj, string? propertyName = null)
    {
        return obj.GetType()
            .GetProperties()
            .Where(x => x.PropertyType.IsAssignableFrom(typeof(IValidate)))
            .Select(x => 
            {
                var value  = x.GetValue(obj);
                var casted = (IValidate)value!;
                var result = casted.Validate(x.Name);

                return result;
            })
            .Merge(propertyName);
    }
}
