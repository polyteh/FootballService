using Football.Service.Models.League;
using System.Threading.Tasks;

namespace Football.Service.Services.Interfaces
{
    public interface ILeagueService
    {
        Task<LeagueModel> GetLeagueDetails(int id);
    }
}
