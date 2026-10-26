using Microsoft.Extensions.DependencyInjection;
using TankRadar.Application;

namespace TankRadar.UnitTests;

public class DependencyInjectionTests
{
    [Fact]
    public void AddApplication_ReturnsSameServiceCollection()
    {
        var services = new ServiceCollection();

        var result = services.AddApplication();

        Assert.Same(services, result);
    }
}
