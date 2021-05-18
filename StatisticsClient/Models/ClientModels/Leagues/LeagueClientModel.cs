using System;
using System.Collections.Generic;

namespace StatisticsClient.Models.Leagues
{
    public class LeagueClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Logo { get; set; }
        public string Flag { get; set; }
        public int Season { get; set; }
        public List<List<StandingClientModel>> Standings { get; set; }
    }

    public class StandingClientModel
    {
        public int Rank { get; set; }
        public TeamClientModel Team { get; set; }
        public int Points { get; set; }
        public int GoalsDiff { get; set; }
        public string Group { get; set; }
        public string Form { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public StatisticsClientModel AllStatistics { get; set; }
        public StatisticsClientModel HomeStatistics { get; set; }
        public StatisticsClientModel Away { get; set; }
        public DateTime Update { get; set; }
    }

    public class StatisticsClientModel
    {
        public int Played { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }
        public GoalsClientModel Goals { get; set; }
    }

    public class GoalsClientModel
    {
        public int OwnGoals { get; set; }
        public int OpponentGoals { get; set; }
    }

    public class TeamClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
