#nullable enable

using Definit.Results;
using Definit.Validation;
using System.Text.Json;

namespace Definit.Configuration.Tests.Unit;

partial struct TestValue : Definit.Validation.IIsValid<string>, Definit.Validation.IIsValid<TestValue, TestValue.Valid>
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
	
	public static implicit operator Definit.Configuration.Tests.Unit.TestValue(string value) => new (value);
	
	public static implicit operator string(Definit.Configuration.Tests.Unit.TestValue value) => value.Value;
	
	
	// Validate
	
	public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this.Value, propertyName);
	
	public U<ValidationError> Validate(string? propertyName = null) => _rule.Validate(this.Value, propertyName ?? _NAME); 
	
	
	// Factory
	
	public static U<Valid, ValidationError> Create(Definit.Configuration.Tests.Unit.TestValue value, string? propertyName = null) => Valid.Create(value, propertyName); 
	
	
	// JSON
	
	public static Definit.Configuration.Tests.Unit.TestValue Deserialize(string json) => new Definit.Configuration.Tests.Unit.TestValue(JsonSerializer.Deserialize<string>(json)!);  
	
	public static string Serialize(Definit.Configuration.Tests.Unit.TestValue value) => JsonSerializer.Serialize(value.Value); 
	
	
	// Valid
	
	public readonly struct Valid : Definit.Validation.IValid<Definit.Configuration.Tests.Unit.TestValue>, Definit.Validation.IValidBase<Definit.Configuration.Tests.Unit.TestValue.Valid>
	{
	    Definit.Configuration.Tests.Unit.TestValue Definit.Validation.IValid<Definit.Configuration.Tests.Unit.TestValue>.Value => this._Parent;
	
	    public string Value => _Parent.Value;
	
	    public Definit.Configuration.Tests.Unit.TestValue _Parent { get; }
	
	    private Valid(Definit.Configuration.Tests.Unit.TestValue parent)
	    {
	        this._Parent = parent;
	    }
	
	    public static implicit operator Definit.Configuration.Tests.Unit.TestValue(Valid value) => value.Value;
	
	
	    // Factory
	
	    public static U<Valid, ValidationError> Create(Definit.Configuration.Tests.Unit.TestValue value, string? propertyName = null)
	    {
	        var (_, error) = value.Validate(propertyName ?? Definit.Configuration.Tests.Unit.TestValue._NAME);
	        if(error is not null)
	        {
	            return error.Value;
	        }
	
	        return new Valid(value);
	    }
	
	
	    // JSON
	    
	    public static U<Valid, ValidationError> Deserialize(string json) => Create(Definit.Configuration.Tests.Unit.TestValue.Deserialize(json));
	
	    public static string Serialize(Valid valid) => Definit.Configuration.Tests.Unit.TestValue.Serialize(valid._Parent);
	}
}