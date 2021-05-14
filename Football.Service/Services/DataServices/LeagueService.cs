using Football.Service.Models.League;
using Football.Service.Services.Interfaces;
using System.Threading.Tasks;

namespace Football.Service.Services.DataServices
{
    public class LeagueService : ILeagueService
    {
        public async Task<LeagueModel> GetLeague(int id)
        {
            var result = new LeagueModel()
            {
                Id = 1,
                LeagueName = "test"
            };

            return result;
        }
    }
}
