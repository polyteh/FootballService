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
        public int OwnGoals { get; set; }
        [JsonProperty("against")]
        public int OpponentGoals { get; set; }
    }

    public class StatisticsRapidapi
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
        public StatisticsRapidapi AllStatistics { get; set; }
        [JsonProperty("home")]
        public StatisticsRapidapi HomeStatistics { get; set; }
        [JsonProperty("away")]
        public StatisticsRapidapi Away { get; set; }
        public DateTime Update { get; set; }
    }
}
