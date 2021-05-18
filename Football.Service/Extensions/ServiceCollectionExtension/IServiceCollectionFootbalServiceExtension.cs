using Football.Service.AutoMapperConfiguration;
using Football.Service.Services.DataServices;
using Football.Service.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Football.Service.Extensions.ServiceCollectionExtension
{
    public static class IServiceCollectionFootbalServiceExtension
    {
        public static IServiceCollection AddFootballServices(this IServiceCollection services)
        {
            services.AddTransient<ILeagueService, LeagueService>();
            services.AddSingleton(provider => MappingProfile.GetAutoMapperConfiguration(provider).CreateMapper());

            return services;
        }
    }
}
