using DomainLayer.Entities;

namespace DomainLayer.Aggregate
{
    public class TeamInformations : Entity
    {
        public Team Team { get; set; } = new Team();
        public TeamStatistics Statistics { get; set; } = new TeamStatistics();  

    }
}