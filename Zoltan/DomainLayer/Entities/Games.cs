namespace DomainLayer.Entities
{
    public class Games
    {
        public int Appearences { get; set; }
        public int LineUps { get; set; }
        public int MinutesPlayed { get; set; }
        public string Position { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        public bool IsCaptain { get; set; } = false;
    }
}