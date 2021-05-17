using Football.Service.Models.League;
using Football.Service.Models.Response;
using Football.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Football.Service.Controllers
{
    [Route("api/leagues")]
    [Produces("application/json")]
    public class LeagueController : BaseApiController
    {
        private readonly ILeagueService _leagueService;
        public LeagueController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<BaseResponse<LeagueModel>> GetLeague(int id)
        {
            var league = await _leagueService.GetLeagueDetails(2);

            var result = new BaseResponse<LeagueModel>()
            {
                Data = league
            };

            return result;
        }
    }
}
