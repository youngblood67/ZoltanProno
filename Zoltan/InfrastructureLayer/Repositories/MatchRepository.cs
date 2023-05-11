using DomainLayer.Entities;
using DomainLayer.Repositories;

namespace InfrastructureLayer.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        // Méthodes synchrones
        public List<MatchPlayed> GetLastMatches(int nbLast, int leagueId)
        {
            throw new NotImplementedException();
        }
        public List<MatchToPlay> GetNextMatches(int nbNext, int leagueId)
        {
            throw new NotImplementedException();
        }
        public List<MatchPlayed> GetLastMatchesByTeamId(int nbLast, int leagueId, int teamId)
        {
            throw new NotImplementedException();
        }
        public List<MatchToPlay> GetNextMatchesByTeamId(int nbNext, int leagueId, int teamId)
        {
            throw new NotImplementedException();
        }

        // Méthodes asynchrones
        public async Task<List<MatchPlayed>> GetLastMatchesAsync(int nbLast, int leagueId)
        {
            throw new NotImplementedException();
        }
        public async Task<List<MatchToPlay>> GetNextMatchesAsync(int nbNext, int leagueId)
        {
            throw new NotImplementedException();
        }
        public async Task<List<MatchPlayed>> GetLastMatchesByTeamIdAsync(int nbLast, int leagueId, int teamId)
        {
            throw new NotImplementedException();
        }
        public async Task<List<MatchToPlay>> GetNextMatchesByTeamIdAsync(int nbNext, int leagueId, int teamId)
        {
            throw new NotImplementedException();
        }
    }
}
