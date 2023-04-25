namespace DomainLayer.Entities
{
    public class League : Entity
    {
        public League(int id) : base(id) { }
        public string Name { get; set; }
        public string Season { get; set; }
        public string Country { get; set; }
    }
}
