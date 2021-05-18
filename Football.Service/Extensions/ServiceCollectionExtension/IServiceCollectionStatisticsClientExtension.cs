using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StatisticsClient.Configuration;
using StatisticsClient.Interfaces.Shared;
using StatisticsClient.Services.DataServices.Rapidapi;
using StatisticsClient.Services.Interfaces;
using StatisticsClient.Services.Shared;

namespace Football.Service.Extensions.ServiceCollectionExtension
{
    public static class IServiceCollectionStatisticsClientExtension
    {
        public static IServiceCollection AddStatisticsClientServices(this IServiceCollection services,
            IConfiguration Configuration) 
        {
            //add services
            services.AddTransient<IStatisticsLeagueService, StatisticsLeagueServiceRapidapi>();
            services.AddTransient<ISendRequest, SendRequestService>();

            //add configuration
            services.Configure<RapidapiConfiguration>(Configuration.GetSection("Rapidapi"));

            return services;
        }
    }
}
