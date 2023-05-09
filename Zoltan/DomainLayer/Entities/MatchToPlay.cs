namespace DomainLayer.Entities
{
    public class MatchToPlay : Match
    {
        public MatchToPlay(int id, DateTime dt, League league, Team tHome, Team tAway) : base(id, dt, league, tHome, tAway){}

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Saison " + League.Season + " - " + League.Country + " - " + League.Name +
                Environment.NewLine + HomeTeam.Name + " : - " 
                + Environment.NewLine + AwayTeam.Name + " : - " 
                + Environment.NewLine + "En attente : le match sera joué le  " + DateAndTime;
        }
    }
}
