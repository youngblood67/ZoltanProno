namespace DomainLayer.ValueObject
{
    public abstract class Score
    {
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
    }
}