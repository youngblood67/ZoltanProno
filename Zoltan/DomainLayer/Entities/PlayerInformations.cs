namespace DomainLayer.Entities
{
    public class PlayerInformations : Entity
    {
        public PlayerInformations(int id, string firstName, string lastName, DateTime birthdate, string nationality, decimal weight = 0, decimal height = 0, bool injured = false) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthdate;
            Nationality = nationality;
            Weight = weight;
            Height = height;
            Injured = injured;
            Statistics = new List<PlayerStatistics>();
        }
        public string FirstName { get; private set; } = String.Empty;
        public string LastName { get; private set; } = String.Empty;
        public DateTime BirthDate { get; private set; }

        public string Nationality { get; private set; } = String.Empty;
        public decimal Height { get; private set; }
        public decimal Weight { get; private set; }
        public bool Injured { get; private set; }

        public List<PlayerStatistics> Statistics { get; private set; } 



    }
}
