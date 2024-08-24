using System.Reflection;
using Definit.Results;

namespace Definit.ConfigurationNewApproach;


public sealed record ConfigValueExample() : ConfigValue<string, ConnectionString>("ExampleValue");

public sealed record ConfigSectionExample() : ConfigSection<
(
    ConnectionString ConnectionString,
    string Value
)>
("ExampleSection");

