using DomainLayer.Entities;

namespace DomainLayer
{
    public class Team : Entity
    {
        public Team(int id, string name) : base(id)
        {
            Name = name;    
            Statistics = new List<TeamStatistics>();
        }

        public string Name { get; private set; } = String.Empty;

        public List<TeamStatistics> Statistics { get; private set; }

    }
}