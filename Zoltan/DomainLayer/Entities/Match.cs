namespace DomainLayer.Entities
{
    public abstract class Match : Entity
    {
        public DateTime DateAndTime { get; private set; }
        public League League { get; private set; }
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }
        public Match(int id, DateTime dt, League league, Team tHome, Team tAway) : base(id)
        {
            DateAndTime = dt;
            League = league;
            HomeTeam = tHome;
            AwayTeam = tAway;
        }
    }
}
