using Definit.Results;

namespace Definit.Configuration.Tests.Unit;

public class ValueTests
{
    [Fact]
    public void GetFromConfigTest()
    {
        //Arrange
        var values = new Dictionary<string, string>
        {
            {"testValue", "5"},
        };
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(values!)
            .Build();

        //Act
        var value = TestValueConfig.Create<TestValueConfig>(configuration);

        //Assert
        var (valid, _) = value.Get();

        valid!.Value.Out.Should().Be(5);
    }
    
    [Fact]
    public void GetNullFromConfigTest()
    {
        //Arrange
        var values = new Dictionary<string, string> { };
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(values!)
            .Build();

        var value = TestValueConfig.Create<TestValueConfig>(configuration);

        //Assert
        var (_, error) = value.Get();
        error.Should().NotBeNull();
    }
    
    [Fact]
    public void RegisterTest()
    {
        //Arrange
        var services = new ServiceCollection();
        var values = new Dictionary<string, string>
        {
            {"testValue", "TestValue"},
        };
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(values!)
            .Build();

        //Act
        TestValueConfig.Register<TestValueConfig>(services, configuration);

        //Assert
        services.Should().Contain(x => x.ServiceType == typeof(TestValueConfig));
    }
}
