using Definit.Results;

namespace Definit.Configuration.Tests.Unit;

public class SectionTests
{
    [Fact]
    public void GetFromConfigTest()
    {
        //Arrange
        var values = new Dictionary<string, string>
        {
            {"testSection:Value0", "Value0"},
            {"testSection:Value1", "Value1"},
        };
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(values!)
            .Build();

        //Act
        var section = TestSectionConfig.Create<TestSectionConfig>(configuration);
       
        //Assert
        var (valid, _) = section.Get();
        valid!.Value.Value0.Should().Be("Value0");
        valid!.Value.Value1.Should().Be("Value1");
    }
    
    [Fact]
    public void GetNullFromConfigTest()
    {
        //Arrange
        var values = new Dictionary<string, string> { };
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(values!)
            .Build();

        //Act
        var section = TestSectionConfig.Create<TestSectionConfig>(configuration);

        //Assert
        var (_, error) = section.Get();
        error.Should().NotBeNull();
    }
    
    [Fact]
    public void GetNullValueFromConfigTest()
    {
        //Arrange
        var values = new Dictionary<string, string>
        {
            {"testSection", ""},
        };
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(values!)
            .Build();

        //Act
        var section = TestSectionConfig.Create<TestSectionConfig>(configuration);

        //Assert
        var (_, error) = section.Get();
        error.Should().NotBeNull();
    }
    
    [Fact]
    public void RegisterTest()
    {
        //Arrange
        var services = new ServiceCollection();
        var values = new Dictionary<string, string>
        {
            {"test:Value0", "Value0"},
            {"test:Value1", "Value1"},
        };
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(values!)
            .Build();

        //Act
        TestSectionConfig.Register<TestSectionConfig>(services, configuration);

        //Assert
        services.Should().Contain(x => x.ServiceType == typeof(TestSectionConfig));
    }
}
