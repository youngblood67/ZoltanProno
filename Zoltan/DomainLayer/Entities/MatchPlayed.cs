namespace DomainLayer.Entities
{
    public class MatchPlayed : Match
    {
        public int HomeScore { get; private set; }
        public int AwayScore { get; private set; }
        public MatchTeamStatistics HomeTeamStatistics { get; private set; }
        public MatchTeamStatistics AwayTeamStatistics { get; private set; }

        public MatchPlayed(int id, DateTime dt, League league, Team tHome, Team tAway, int homeScore, int awayScore, MatchTeamStatistics tHomeStats, MatchTeamStatistics tAwayStats) : base(id, dt, league, tHome, tAway)
        {
            HomeScore = homeScore;
            AwayScore = awayScore;
            HomeTeamStatistics = tHomeStats;
            AwayTeamStatistics = tAwayStats;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Saison " + League.Season + " - " + League.Country + " - " + League.Name +
                Environment.NewLine + HomeTeam.Name + " : " + HomeScore
                + Environment.NewLine + AwayTeam.Name + " : " + AwayScore
                + Environment.NewLine;
        }

    }
}
