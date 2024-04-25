using dnet_exception_handling.Domain.Interfaces;
using dnet_exception_handling.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace dnet_exception_handling.Infrastructure.Common.Composer;

public static class RegisterDependencies
{
    public static IServiceCollection RegisterInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<MyRepository>();
        services.AddSingleton<IRepository<object>, MyRepository>(x => x.GetRequiredService<MyRepository>());
        return services;
    }
}