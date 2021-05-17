using StatisticsClient.Models.Leagues;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StatisticsClient.Services.Interfaces
{
    public interface IStatisticsLeagueService
    {
        Task<LeagueClientModel> GetLeague (long id);
        IEnumerable<LeagueClientModel> GetLeagues();
    }
}
