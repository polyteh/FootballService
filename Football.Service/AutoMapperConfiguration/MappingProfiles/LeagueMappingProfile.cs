using AutoMapper;
using Football.Service.Models.League;
using StatisticsClient.Models.Leagues;

namespace Football.Service.AutoMapperConfiguration.MappingProfiles
{
    public class LeagueMappingProfile : Profile
    {
        public LeagueMappingProfile()
        {
            CreateMap<LeagueClientModel, LeagueModel>();
        }
    }
}
