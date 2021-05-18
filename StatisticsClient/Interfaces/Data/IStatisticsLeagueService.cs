using StatisticsClient.Models.Leagues;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StatisticsClient.Services.Interfaces
{
    public interface IStatisticsLeagueService
    {
        Task<LeagueClientModel> GetLeagueDetails (int id);
        IEnumerable<LeagueClientModel> GetLeagues();
    }
}
