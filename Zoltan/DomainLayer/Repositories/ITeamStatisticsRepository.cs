namespace DomainLayer.Repositories
{
    public interface ITeamStatisticsRepository
    {
        public Team GetTeamStatisticsBySeasonAndTeamId(int season, int teamId);

        public Team GetTeamStatisticsByMatchIdAndTeamId(int matchId,int teamId);
    }
}
