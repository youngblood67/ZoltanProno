namespace DomainLayer.Entities
{
    public class League : Entity
    {
        public string Name { get; set; }
        public string Season { get; set; }
        public string Country { get; set; }
        public League(int id, string name, string season, string country) : base(id)
        {
            Name = name;
            Season = season;
            Country = country;
        }
    }
}
