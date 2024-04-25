using Microsoft.Extensions.DependencyInjection;

namespace dnet_exception_handling.Application.Common.Composers;

public static class RegisterDependencies
{
    public static IServiceCollection RegisterApplication(this IServiceCollection services)
    {
        services.AddSingleton<MyService>();
        return services;
    }
}