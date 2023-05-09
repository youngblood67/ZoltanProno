using DomainLayer.Entities;

namespace DomainLayer.Repositories
{
    public interface IPlayerStatisticsRepository
    {
        public Task<List<PlayerInformations>> GetPlayerStatisticsByPlayerIdTeamIdAndSeasonId(int playerId,int teamId, int seasonId);

         
    }
}
