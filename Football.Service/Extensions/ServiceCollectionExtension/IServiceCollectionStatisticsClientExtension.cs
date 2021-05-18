using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StatisticsClient.Configuration;
using StatisticsClient.Services.DataServices.Rapidapi;
using StatisticsClient.Services.Interfaces;

namespace Football.Service.Extensions.ServiceCollectionExtension
{
    public static class IServiceCollectionStatisticsClientExtension
    {
        public static IServiceCollection AddStatisticsClientServices(this IServiceCollection services,
            IConfiguration Configuration) 
        {
            services.AddTransient<IStatisticsLeagueService, StatisticsLeagueServiceRapidapi>();

            services.Configure<RapidapiConfiguration>(Configuration.GetSection("Rapidapi"));

            return services;
        }
    }
}
