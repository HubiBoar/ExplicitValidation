#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;
using System.Text.Json;

namespace Definit.Configuration;

partial class Example
{
	partial record TestObject : Definit.Validation.IIsValid<Definit.Configuration.Example.TestObject, Definit.Configuration.Example.TestObject.Valid>
	{
		private const string _NAME = "TestObject";
		
		
		// Validate
		
		public U<ValidationError> Validate(string? propertyName = null) => IsValid(propertyName ?? _NAME).ToResult();
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
		
		
		// Factory
		
		public static U<Valid, ValidationError> Create(Definit.Configuration.Example.TestObject value, string? propertyName = null) => Valid.Create(value, propertyName); 
		
		
		// JSON
		
		public static Definit.Configuration.Example.TestObject Deserialize(string json) => JsonSerializer.Deserialize<Definit.Configuration.Example.TestObject>(json)!;  
		
		public static string Serialize(Definit.Configuration.Example.TestObject value) => JsonSerializer.Serialize(value); 
		
		
		// Valid
		
		public readonly struct Valid : Definit.Validation.IValid<Definit.Configuration.Example.TestObject>, Definit.Validation.IValidBase<Definit.Configuration.Example.TestObject.Valid> 
		{
		    public Definit.Configuration.Example.TestObject _Parent { get; } 
		
		    Definit.Configuration.Example.TestObject Definit.Validation.IValid<Definit.Configuration.Example.TestObject>.Value => this._Parent;
		
		    public System.Type EqualityContract { get; }
			public string Name { get; }
			public Definit.Configuration.Example.Email.Valid TestValue { get; }
			public Definit.Configuration.Example.Email.Valid TestValue2 { get; }
		
		    private Valid(Definit.Configuration.Example.TestObject _parent, System.Type EqualityContract, string Name, Definit.Configuration.Example.Email.Valid TestValue, Definit.Configuration.Example.Email.Valid TestValue2)
		    {
		        this._Parent = _parent;
		        this.EqualityContract = EqualityContract;
				this.Name = Name;
				this.TestValue = TestValue;
				this.TestValue2 = TestValue2;
		    }
		
		    public static implicit operator Definit.Configuration.Example.TestObject(Valid value) => value._Parent;
		
		    // Factory
		
		    public static U<Valid, ValidationError> Create(Definit.Configuration.Example.TestObject value, string? propertyName = null)
		    {
		        var name = propertyName is null ? Definit.Configuration.Example.TestObject._NAME : propertyName; 
		
		        List<ValidationError> errors = [];
		
		        var (valid_TestValue, error_TestValue) = value.TestValue.IsValid("TestValue");
		
		        if(error_TestValue is not null)
		        {
		            errors.Add(error_TestValue.Value);
		        }
		
		        var (valid_TestValue2, error_TestValue2) = value.TestValue2.IsValid("TestValue2");
		
		        if(error_TestValue2 is not null)
		        {
		            errors.Add(error_TestValue2.Value);
		        }
		 
		        if(errors.Count > 0)
		        {
		            return new ValidationError(name, errors.ToImmutableArray());
		        }
		
		        return new Valid(value, value.EqualityContract, value.Name, valid_TestValue!.Value, valid_TestValue2!.Value);
		    }
		
		
		    // JSON
		    
		    public static U<Valid, ValidationError> Deserialize(string json) => Create(Definit.Configuration.Example.TestObject.Deserialize(json));
		
		    public static string Serialize(Valid valid) => Definit.Configuration.Example.TestObject.Serialize(valid._Parent);
		}
	}
}