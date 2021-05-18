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

namespace StatisticsClient.Services.DataServices.Rapidapi
{
    public class StatisticsLeagueServiceRapidapi : IStatisticsLeagueService
    {
        private readonly RestClient _client;
        private readonly RapidapiConfiguration _rapidapiConfiguration;
        public StatisticsLeagueServiceRapidapi(IOptionsSnapshot<RapidapiConfiguration> rapidapiConfiguration)
        {
            _rapidapiConfiguration = rapidapiConfiguration.Value;

            if (_rapidapiConfiguration != null)
            {
                _client = new RestClient(_rapidapiConfiguration.BaseUrl);
            }
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
            request.AddUrlSegment("season", 2020);
            request.AddUrlSegment("league", 39);


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
