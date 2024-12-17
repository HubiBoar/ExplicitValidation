#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;
using System.Text.Json;

namespace Definit.Configuration;

partial class Example
{
	partial record TestObject: Definit.Validation.IIsValid<Definit.Configuration.Example.TestObject, Definit.Configuration.Example.TestObject.Valid>
	{
		
		private const string _NAME = "TestObject";
		
		public U<ValidationError> Validate(string? propertyName = null)
		{
		    return IsValid(propertyName ?? _NAME).ToResult();
		}
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
		
		public static U<Valid, ValidationError> Create(Definit.Configuration.Example.TestObject value, string? propertyName = null) => Valid.Create(value, propertyName); 
		
		public static Definit.Configuration.Example.TestObject Deserialize(string json) => JsonSerializer.Deserialize<Definit.Configuration.Example.TestObject>(json)!;  
		public static string Serialize(Definit.Configuration.Example.TestObject value) => JsonSerializer.Serialize(value); 
		
		public readonly struct Valid : Definit.Validation.IValid<Definit.Configuration.Example.TestObject> 
		{
		    public Definit.Configuration.Example.TestObject Value { get; } 
		
		    public Definit.Configuration.Example.TestValue.Valid TestValue { get; }
		
		    private Valid(Definit.Configuration.Example.TestObject Value, Definit.Configuration.Example.TestValue.Valid TestValue)
		    {
		        this.Value = Value;
		        this.TestValue = TestValue;
		    }
		
		    public static U<Valid, ValidationError> Create(Definit.Configuration.Example.TestObject value, string? propertyName = null)
		    {
		        var name = propertyName is null ? _NAME : propertyName; 
		
		        List<ValidationError> errors = [];
		
		        var (valid_TestValue, error_TestValue) = value.TestValue.IsValid("TestValue");
		
		        if(error_TestValue is not null)
		        {
		            errors.Add(error_TestValue.Value);
		        }
		 
		        if(errors.Count > 0)
		        {
		            return new ValidationError(name, errors.ToImmutableArray());
		        }
		
		        return new Valid(value, valid_TestValue!.Value);
		    }
		
		    public static implicit operator Definit.Configuration.Example.TestObject(Valid value) => value.Value;
		}
	}
}