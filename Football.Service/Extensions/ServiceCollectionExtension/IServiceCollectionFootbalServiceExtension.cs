using Football.Service.AutoMapperConfiguration;
using Football.Service.Services.DataServices;
using Football.Service.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Football.Service.Extensions.ServiceCollectionExtension
{
    public static class IServiceCollectionFootbalServiceExtension
    {
        public static IServiceCollection AddFootballServices(this IServiceCollection service)
        {
            service.AddTransient<ILeagueService, LeagueService>();
            service.AddSingleton(provider => MappingProfile.GetAutoMapperConfiguration(provider).CreateMapper());

            return service;
        }
    }
}
