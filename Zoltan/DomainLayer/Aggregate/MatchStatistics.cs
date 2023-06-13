using DomainLayer.ValueObject;

namespace DomainLayer.Aggregate
{
    public class MatchStatistics
    {
        HalfTimeScore HalfTimeScore { get; set; } = new HalfTimeScore();
        FullTimeScore FullTimeScore { get; set; } = new FullTimeScore();
        ExtraTimeScore ExtraTimeScore { get; set; } = new ExtraTimeScore();
        PenaltyScore PenaltyScore { get; set; } = new PenaltyScore();

    }
}