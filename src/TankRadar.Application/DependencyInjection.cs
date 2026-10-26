using Microsoft.Extensions.DependencyInjection;

namespace TankRadar.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Use cases (handlers) and validators are registered here.
        return services;
    }
}
