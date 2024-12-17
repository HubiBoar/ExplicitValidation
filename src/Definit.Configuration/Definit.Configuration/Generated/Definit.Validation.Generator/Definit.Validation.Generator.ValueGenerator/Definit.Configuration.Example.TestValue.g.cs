#nullable enable

using Definit.Results;
using Definit.Validation;
using System.Text.Json;

namespace Definit.Configuration;

partial class Example
{
	partial struct TestValue: Definit.Validation.IIsValid<string>, Definit.Validation.IIsValid<TestValue, TestValue.Valid>
	{
		private readonly static Rule<string> _rule;
		
		private const string _NAME = "TestValue";
		
		static TestValue()
		{
		    _rule = new();
		    Rule(_rule);
		}
		
		public string Value { get; }
		
		public TestValue(string value)
		{
		    Value = value;
		}
		
		public static implicit operator Definit.Configuration.Example.TestValue(string value) => new (value);
		
		public static implicit operator string(Definit.Configuration.Example.TestValue value) => value.Value;
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this.Value, propertyName);
		
		public U<ValidationError> Validate(string? propertyName = null) => _rule.Validate(this.Value, propertyName ?? _NAME); 
		
		public static Definit.Configuration.Example.TestValue Deserialize(string json) => new Definit.Configuration.Example.TestValue(JsonSerializer.Deserialize<string>(json)!);  
		public static string Serialize(Definit.Configuration.Example.TestValue value) => JsonSerializer.Serialize(value.Value); 
		
		public static U<Valid, ValidationError> Create(Definit.Configuration.Example.TestValue value, string? propertyName = null) => Valid.Create(value, propertyName); 
		
		public readonly struct Valid : Definit.Validation.IValid<Definit.Configuration.Example.TestValue>, Definit.Validation.IValidBase<Definit.Configuration.Example.TestValue.Valid>
		{
		    private const string _NAME = "TestValue";
		
		    Definit.Configuration.Example.TestValue Definit.Validation.IValid<Definit.Configuration.Example.TestValue>.Value => this.Parent;
		
		    public string Value => Parent.Value;
		
		    public Definit.Configuration.Example.TestValue Parent { get; }
		
		    private Valid(Definit.Configuration.Example.TestValue parent)
		    {
		        this.Parent = parent;
		    }
		
		    public static U<Valid, ValidationError> Deserialize(string json) => Create(Definit.Configuration.Example.TestValue.Deserialize(json));
		    public static string Serialize(Valid valid) => Definit.Configuration.Example.TestValue.Serialize(valid.Parent);
		
		    public static U<Valid, ValidationError> Create(Definit.Configuration.Example.TestValue value, string? propertyName = null)
		    {
		        var (_, error) = value.Validate(propertyName ?? _NAME);
		        if(error is not null)
		        {
		            return error.Value;
		        }
		
		        return new Valid(value);
		    }
		}
	}
}