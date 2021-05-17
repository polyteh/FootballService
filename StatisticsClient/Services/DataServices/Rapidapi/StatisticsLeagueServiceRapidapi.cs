using StatisticsClient.Models.Leagues;
using StatisticsClient.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StatisticsClient.Services.DataServices.Rapidapi
{
    public class StatisticsLeagueServiceRapidapi : IStatisticsLeagueService
    {
        public async Task<LeagueClientModel> GetLeague(long id)
        {
            var result = new LeagueClientModel()
            {
                Id = 1,
                LeagueName = "test"
            };

            return result;
        }

        public IEnumerable<LeagueClientModel> GetLeagues()
        {
            throw new System.NotImplementedException();
        }
    }
}
