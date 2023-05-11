using DomainLayer.Entities;
using DomainLayer.Repositories;
using InfrastructureLayer.Models;
using Newtonsoft.Json;

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

        public List<PlayerInformations> GetPlayerStatisticsByPlayerIdTeamIdAndSeasonId(int playerId, int teamId, int seasonId)
        {
            string endpoint = $"{ApiBaseUrl}/players?id={playerId}&team={teamId}&season={seasonId}";

            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            request.Headers.Add("x-rapidapi-host", "v3.football.api-sports.io");
            request.Headers.Add("x-rapidapi-key", ApiKey);

            var response = _httpClient.Send(request);

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<Query>(content);
                int test = 0;
               
            }

            throw new NotImplementedException();

        }

        public async Task<List<PlayerInformations>> GetPlayerStatisticsByPlayerIdTeamIdAndSeasonIdAsync(int playerId, int teamId, int seasonId)
        {
            throw new NotImplementedException();
        }

    }
}
