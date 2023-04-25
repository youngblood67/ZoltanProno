using DomainLayer.Entities;

namespace DomainLayer.Repositories
{
    public interface IPlayerStatisticsRepository
    {
        public List<Player> GetPlayerStatisticsByPlayerIdTeamIdAndSeasonId(int playerId,int teamId, int seasonId);

         
    }
}
