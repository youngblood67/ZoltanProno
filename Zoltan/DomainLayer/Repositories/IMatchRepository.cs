using DomainLayer.Entities;

namespace DomainLayer.Repositories
{
    public interface IMatchRepository
    {
        public List<Match> GetNextMatches(int nbNext, int leagueId);
        public List<Match> GetLastMatches(int nbLast, int leagueId);

        public List<Match> GetLastMatchesByTeamId(int nbLast, int leagueId, int teamId);

        public List<Match> GetNextMatchesByTeamId(int nbNext, int leagueId, int teamId);
    }
}
