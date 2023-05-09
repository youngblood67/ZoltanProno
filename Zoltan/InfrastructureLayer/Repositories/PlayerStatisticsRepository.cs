using DomainLayer.Entities;
using DomainLayer.Repositories;

namespace InfrastructureLayer.Repositories
{
    public class PlayerStatisticsRepository : IPlayerStatisticsRepository
    {
        private const string ApiKey = "018c7ba508536c2b310be5eabf523dae";
        private const string ApiBaseUrl = "https://v3.football.api-sports.io";

        private readonly HttpClient _httpClient;

        public PlayerStatisticsRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PlayerInformations>> GetPlayerStatisticsByPlayerIdTeamIdAndSeasonId(int playerId, int teamId, int seasonId)
        {
            throw new NotImplementedException();
        }
    }
}
