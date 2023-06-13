using DomainLayer.Aggregate;
using DomainLayer.Entities;
using DomainLayer.Repositories;

namespace InfrastructureLayer.Repositories
{
    public class TeamInformationsRepository : ITeamInformationsRepository
    {
        public TeamInformations GetTeamInformationsByMatchIdAndTeamId(int matchId, int teamId)
        {
            throw new NotImplementedException();
        }

        public TeamInformations GetTeamInformationsBySeasonAndTeamId(int season, int teamId)
        {
            throw new NotImplementedException();
        }
    }
}
