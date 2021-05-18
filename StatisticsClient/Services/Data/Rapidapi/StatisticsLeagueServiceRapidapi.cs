using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;
using StatisticsClient.Configuration;
using StatisticsClient.Models.Leagues;
using StatisticsClient.Models.RapidapiModels;
using StatisticsClient.Services.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using StatisticsClient.Extensions;
using StatisticsClient.Services.Data.Rapidapi;
using StatisticsClient.Interfaces.Shared;

namespace StatisticsClient.Services.DataServices.Rapidapi
{
    public class StatisticsLeagueServiceRapidapi : BaseServiceRapidapi, IStatisticsLeagueService
    {
        public StatisticsLeagueServiceRapidapi(IOptionsSnapshot<RapidapiConfiguration> rapidapiConfiguration, 
            ISendRequest sendRequest) : base(rapidapiConfiguration, sendRequest)
        {

        }

        public async Task<LeagueClientModel> GetLeagueDetails(int id)
        {
            var leaguesDetail = new LeagueRapidapiModel();

            using (StreamReader r = new StreamReader(@"D:\BaseBackUp\JSON\league.json"))
            {
                string canabisJson = r.ReadToEnd();
                leaguesDetail = JsonConvert.DeserializeObject<LeagueRapidapiModel>(canabisJson);
            }

            var request = new RestRequest("standings", Method.GET);
            request.AddRapidapiHeaders(_rapidapiConfiguration);
            request.AddParameter("season", 2020);
            request.AddParameter("league", 39);

            var resultt = await _sendRequest.SendLoggedRequest<List<LeagueRapidapiModel>>(_client, request);

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
