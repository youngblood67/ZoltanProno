using DomainLayer.Entities;

namespace DomainLayer.Repositories
{
    public interface IMatchRepository
    {
        // Méthodes synchrones
        public List<MatchPlayed> GetLastMatches(int nbLast, int leagueId);
        public List<MatchToPlay> GetNextMatches(int nbNext, int leagueId);
        public List<MatchPlayed> GetLastMatchesByTeamId(int nbLast, int leagueId, int teamId);
        public List<MatchToPlay> GetNextMatchesByTeamId(int nbNext, int leagueId, int teamId);


        // Méthodes asynchrones
        public Task<List<MatchPlayed>> GetLastMatchesAsync(int nbLast, int leagueId);
        public Task<List<MatchToPlay>> GetNextMatchesAsync(int nbNext, int leagueId);
        public Task<List<MatchPlayed>> GetLastMatchesByTeamIdAsync(int nbLast, int leagueId, int teamId);
        public Task<List<MatchToPlay>> GetNextMatchesByTeamIdAsync(int nbNext, int leagueId, int teamId);

    }
}
