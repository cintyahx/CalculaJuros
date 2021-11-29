using CalculaJuros.Service;
using CalculaJuros.Service.External;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.DI
{
    public static class ConfigureDI
    {
        private static IConfiguration _configuration;

        public static IServiceCollection ConfigureInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            services.InjectServices();
            return services;
        }

        private static void InjectServices(this IServiceCollection services)
        {
            services.AddScoped<ICalculaJurosService, CalculaJurosService>();
            services.AddScoped<ITaxaJurosService, TaxaJurosService>();
        }
    }
}
