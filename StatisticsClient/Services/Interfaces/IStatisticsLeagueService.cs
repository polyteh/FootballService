using StatisticsClient.Models.Leagues;
using System.Collections.Generic;

namespace StatisticsClient.Services.Interfaces
{
    public interface IStatisticsLeagueService
    {
        LeagueClientModel GetLeague (long id);
        IEnumerable<LeagueClientModel> GetLeagues();
    }
}
