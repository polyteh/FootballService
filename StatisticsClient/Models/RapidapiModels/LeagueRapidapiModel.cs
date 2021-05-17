using System;
using System.Collections.Generic;

namespace StatisticsClient.Models.RapidapiModels
{
    public class LeagueRapidapiModel : BaseRapidapiResponse<List<LeagueResponse>>
    {

    }

    public class LeagueResponse
    {
        public League League { get; set; }
    }
    public class League
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string logo { get; set; }
        public string flag { get; set; }
        public int season { get; set; }
        public List<List<Standing>> standings { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
    }

    public class Goals
    {
        public int @for { get; set; }
        public int against { get; set; }
    }

    public class All
    {
        public int played { get; set; }
        public int win { get; set; }
        public int draw { get; set; }
        public int lose { get; set; }
        public Goals goals { get; set; }
    }

    public class Home
    {
        public int played { get; set; }
        public int win { get; set; }
        public int draw { get; set; }
        public int lose { get; set; }
        public Goals goals { get; set; }
    }

    public class Away
    {
        public int played { get; set; }
        public int win { get; set; }
        public int draw { get; set; }
        public int lose { get; set; }
        public Goals goals { get; set; }
    }

    public class Standing
    {
        public int rank { get; set; }
        public Team team { get; set; }
        public int points { get; set; }
        public int goalsDiff { get; set; }
        public string group { get; set; }
        public string form { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public All all { get; set; }
        public Home home { get; set; }
        public Away away { get; set; }
        public DateTime update { get; set; }
    }
}
