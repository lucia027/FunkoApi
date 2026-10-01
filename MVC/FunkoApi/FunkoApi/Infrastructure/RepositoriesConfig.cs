using FunkoApi.Repository;

namespace FunkoApi.Infrastructure;

public static class RepositoriesConfig {

    public static IServiceCollection AddRepositories(this IServiceCollection services) {
        services.AddSingleton<IFunkoRepository, FunkoRepository>();
        return services;
    }
}