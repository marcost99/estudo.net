using DI.Services;
using WebApplication1.Services;

namespace DI.Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPurchaseRepository, PurchaseRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPurchaseService, PurchaseService>();
            services.AddScoped<IClientService, ClientService>();
            return services;
        }
    }
}
