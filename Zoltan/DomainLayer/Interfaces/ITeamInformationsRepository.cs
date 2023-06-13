using DomainLayer.Aggregate;

namespace DomainLayer.Repositories
{
    public interface ITeamInformationsRepository
    {
        public TeamInformations GetTeamInformationsBySeasonAndTeamId(int season, int teamId);

        public TeamInformations GetTeamInformationsByMatchIdAndTeamId(int matchId,int teamId);
    }
}
