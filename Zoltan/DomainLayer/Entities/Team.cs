using DomainLayer.Entities;

namespace DomainLayer
{
    public class Team : Entity
    {
        public Team(int id, string name) : base(id)
        {
            Name = name;    
        }

        public string Name { get; private set; } = String.Empty;

   
    }
}