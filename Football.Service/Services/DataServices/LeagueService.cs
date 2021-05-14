using Football.Service.Models.League;
using Football.Service.Services.Interfaces;

namespace Football.Service.Services.DataServices
{
    public class LeagueService : ILeagueService
    {
        public LeagueModel GetLeague(int id)
        {
            return new LeagueModel() 
            {
                Id = 1,
                LeagueName = "test" 
            };
        }
    }
}
