using Newtonsoft.Json;
using StatisticsClient.Models.Leagues;
using StatisticsClient.Models.RapidapiModels;
using StatisticsClient.Services.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace StatisticsClient.Services.DataServices.Rapidapi
{
    public class StatisticsLeagueServiceRapidapi : IStatisticsLeagueService
    {
        public async Task<LeagueClientModel> GetLeagueDetails(int id)
        {
            var leaguesDetail = new LeagueRapidapiModel();

            using (StreamReader r = new StreamReader(@"D:\BaseBackUp\JSON\league.json"))
            {
                string canabisJson = r.ReadToEnd();
                leaguesDetail = JsonConvert.DeserializeObject<LeagueRapidapiModel>(canabisJson);
            }



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
