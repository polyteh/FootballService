using AutoMapper;
using Football.Service.Models.League;
using Football.Service.Services.Interfaces;
using StatisticsClient.Services.Interfaces;
using System.Threading.Tasks;

namespace Football.Service.Services.DataServices
{
    public class LeagueService : ILeagueService
    {
        private readonly IStatisticsLeagueService _statisticsLeagueService;
        private readonly IMapper _mapper;

        public LeagueService(IStatisticsLeagueService statisticsLeagueService,
            IMapper mapper)
        {
            _statisticsLeagueService = statisticsLeagueService;
            _mapper = mapper;
        }

        public async Task<LeagueModel> GetLeagueDetails(int id)
        {
            var result = await _statisticsLeagueService.GetLeagueDetails(id);

            var mappedResult = _mapper.Map<LeagueModel>(result);

            return mappedResult;
        }
    }
}
