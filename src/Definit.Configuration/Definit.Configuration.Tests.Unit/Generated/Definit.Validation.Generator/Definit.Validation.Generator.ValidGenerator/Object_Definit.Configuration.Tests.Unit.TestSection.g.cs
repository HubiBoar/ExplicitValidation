#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;
using System.Text.Json;

namespace Definit.Configuration.Tests.Unit;

partial record TestSection : Definit.Validation.IIsValid<Definit.Configuration.Tests.Unit.TestSection, Definit.Configuration.Tests.Unit.TestSection.Valid>
{
	private const string _NAME = "TestSection";
	
	
	// Validate
	
	public U<ValidationError> Validate(string? propertyName = null) => IsValid(propertyName ?? _NAME).ToResult();
	
	public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
	
	
	// Factory
	
	public static U<Valid, ValidationError> Create(Definit.Configuration.Tests.Unit.TestSection value, string? propertyName = null) => Valid.Create(value, propertyName); 
	
	
	// JSON
	
	public static Definit.Configuration.Tests.Unit.TestSection Deserialize(string json) => JsonSerializer.Deserialize<Definit.Configuration.Tests.Unit.TestSection>(json)!;  
	
	public static string Serialize(Definit.Configuration.Tests.Unit.TestSection value) => JsonSerializer.Serialize(value); 
	
	
	// Valid
	
	public readonly struct Valid : Definit.Validation.IValid<Definit.Configuration.Tests.Unit.TestSection>, Definit.Validation.IValidBase<Definit.Configuration.Tests.Unit.TestSection.Valid> 
	{
	    public Definit.Configuration.Tests.Unit.TestSection _Parent { get; } 
	
	    Definit.Configuration.Tests.Unit.TestSection Definit.Validation.IValid<Definit.Configuration.Tests.Unit.TestSection>.Value => this._Parent;
	
	    public System.Type EqualityContract { get; }
		public string Value0 { get; }
		public Definit.Configuration.Tests.Unit.TestValue.Valid Value1 { get; }
	
	    private Valid(Definit.Configuration.Tests.Unit.TestSection _parent, System.Type EqualityContract, string Value0, Definit.Configuration.Tests.Unit.TestValue.Valid Value1)
	    {
	        this._Parent = _parent;
	        this.EqualityContract = EqualityContract;
			this.Value0 = Value0;
			this.Value1 = Value1;
	    }
	
	    public static implicit operator Definit.Configuration.Tests.Unit.TestSection(Valid value) => value._Parent;
	
	    // Factory
	
	    public static U<Valid, ValidationError> Create(Definit.Configuration.Tests.Unit.TestSection value, string? propertyName = null)
	    {
	        var name = propertyName is null ? Definit.Configuration.Tests.Unit.TestSection._NAME : propertyName; 
	
	        List<ValidationError> errors = [];
	
	        var (valid_Value1, error_Value1) = value.Value1.IsValid("Value1");
	
	        if(error_Value1 is not null)
	        {
	            errors.Add(error_Value1.Value);
	        }
	 
	        if(errors.Count > 0)
	        {
	            return new ValidationError(name, errors.ToImmutableArray());
	        }
	
	        return new Valid(value, value.EqualityContract, value.Value0, valid_Value1!.Value);
	    }
	
	
	    // JSON
	    
	    public static U<Valid, ValidationError> Deserialize(string json) => Create(Definit.Configuration.Tests.Unit.TestSection.Deserialize(json));
	
	    public static string Serialize(Valid valid) => Definit.Configuration.Tests.Unit.TestSection.Serialize(valid._Parent);
	}
}