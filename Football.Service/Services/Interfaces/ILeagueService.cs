using Football.Service.Models.League;

namespace Football.Service.Services.Interfaces
{
    public interface ILeagueService
    {
        LeagueModel GetLeague(int id);
    }
}
