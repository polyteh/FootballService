using Microsoft.Extensions.DependencyInjection;
using StatisticsClient.Services.DataServices.Rapidapi;
using StatisticsClient.Services.Interfaces;

namespace Football.Service.Extensions.ServiceCollectionExtension
{
    public static class IServiceCollectionStatisticsClientExtension
    {
        public static IServiceCollection AddStatisticsClientServices(this IServiceCollection services) 
        {
            services.AddTransient<IStatisticsLeagueService, StatisticsLeagueServiceRapidapi>();

            return services;
        }
    }
}
