using Football.Service.Models.League;
using Football.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Football.Service.Controllers
{
    [Route("api/leagues")]
    public class LeagueController : BaseApiController
    {
        private readonly ILeagueService _leagueService;
        public LeagueController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        [HttpGet]
        [Route("")]
        public void GetLeagues()
        {
            var result = _leagueService.GetLeague(2);
        }


        [HttpGet]
        [Route("{id}")]
        public LeagueModel GetLeague(int id)
        {
            var result = _leagueService.GetLeague(2);

            return result;
        }
    }
}
