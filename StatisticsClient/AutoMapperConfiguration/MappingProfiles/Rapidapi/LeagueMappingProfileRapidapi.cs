using AutoMapper;
using StatisticsClient.Models.Leagues;
using StatisticsClient.Models.RapidapiModels;

namespace StatisticsClient.AutoMapperConfiguration.MappingProfiles.Rapidapi
{
    public class LeagueMappingProfileRapidapi : Profile
    {
        public LeagueMappingProfileRapidapi()
        {
            CreateMap<LeagueRapidapiResponse, LeagueClientModel>();
            CreateMap<StandingClientModel, StandingRapidapi>();
            CreateMap<TeamClientModel, TeamRapidapi>();
            CreateMap<StatisticsClientModel, StatisticsRapidapi>();
            CreateMap<GoalsClientModel, GoalsRapidapi>();
        }
    }
}
