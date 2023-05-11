using DomainLayer.Entities;

namespace DomainLayer.Repositories
{
    public interface IPlayerStatisticsRepository
    {
        //Méthode synchrone :
        public List<PlayerInformations> GetPlayerStatisticsByPlayerIdTeamIdAndSeasonId(int playerId, int teamId, int seasonId);

        //Méthode asynchrone :
        public Task<List<PlayerInformations>> GetPlayerStatisticsByPlayerIdTeamIdAndSeasonIdAsync(int playerId,int teamId, int seasonId);

         
    }
}
