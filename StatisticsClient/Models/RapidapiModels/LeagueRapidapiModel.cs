using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace StatisticsClient.Models.RapidapiModels
{
    public class LeagueRapidapiModel : BaseRapidapiResponse<List<LeagueRapidapiResponse>>
    {

    }

    public class LeagueRapidapiResponse
    {
        public LeagueRapidapi League { get; set; }
    }
    public class LeagueRapidapi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Logo { get; set; }
        public string Flag { get; set; }
        public int Season { get; set; }
        public List<List<StandingRapidapi>> Standings { get; set; }
    }

    public class TeamRapidapi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }

    public class GoalsRapidapi
    {
        [JsonProperty("for")]
        public int For { get; set; }
        public int Against { get; set; }
    }

    public class AllStatisticsRapidapi
    {
        public int Played { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }
        public GoalsRapidapi Goals { get; set; }
    }

    public class HomeStatisticsRapidapi
    {
        public int Played { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }
        public GoalsRapidapi Goals { get; set; }
    }

    public class AwayStatisticsRapidapi
    {
        public int Played { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }
        public GoalsRapidapi Goals { get; set; }
    }

    public class StandingRapidapi
    {
        public int Rank { get; set; }
        public TeamRapidapi Team { get; set; }
        public int Points { get; set; }
        public int GoalsDiff { get; set; }
        public string Group { get; set; }
        public string Form { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        [JsonProperty("all")]
        public AllStatisticsRapidapi AllStatistics { get; set; }
        [JsonProperty("home")]
        public HomeStatisticsRapidapi HomeStatistics { get; set; }
        [JsonProperty("away")]
        public AwayStatisticsRapidapi Away { get; set; }
        public DateTime Update { get; set; }
    }
}
