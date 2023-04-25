namespace DomainLayer.Entities
{
    public class Match : Entity
    {
        public Match(int id, DateTime dt, League league, Team tHome, Team tAway) : base(id)
        {
            DateAndTime = dt;
            League = league;
            HomeTeam = tHome;
            AwayTeam = tAway;
            HomeScore = 0;
            AwayScore = 0;
            HomeTeamStatistics = new MatchTeamStatistics();
            AwayTeamStatistics = new MatchTeamStatistics(); 

        }
        public Match(int id, DateTime dt, League league, Team tHome, Team tAway,int homeScore, int awayScore, MatchTeamStatistics tHomeStats, MatchTeamStatistics tAwayStats) : base(id)
        {
            DateAndTime = dt;
            League = league;
            HomeTeam = tHome;
            AwayTeam = tAway;
            HomeScore = HomeScore;
            AwayScore = AwayScore;
            HomeTeamStatistics = tHomeStats;
            AwayTeamStatistics = tAwayStats;
        }

        public DateTime DateAndTime { get; private set; }
        public League League { get; private set; }
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }
        public MatchTeamStatistics HomeTeamStatistics { get; private set; }
        public MatchTeamStatistics AwayTeamStatistics { get; private set; }

        public int? HomeScore { get; private set; }
        public int? AwayScore { get; private set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Saison " + League.Season + " - " + League.Country + " - " + League.Name +
                Environment.NewLine +
                "Match : " + Environment.NewLine + " \t " + HomeTeam.Name + " : " + HomeScore
                + Environment.NewLine + " \t " + AwayTeam.Name + " : " + AwayScore
                + Environment.NewLine;
        }

    }
}
