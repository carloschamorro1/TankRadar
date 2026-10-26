using Microsoft.Extensions.DependencyInjection;

namespace TankRadar.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // EF Core, Tankerkoenig client and background jobs are registered here.
        return services;
    }
}
