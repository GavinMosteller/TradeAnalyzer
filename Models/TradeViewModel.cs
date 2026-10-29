namespace TradeAnalyzer.Models;

public class TradeFormViewModel
{
    public List<PlayerScoreViewModel> MyPlayers {get; set;} = new();
    public List<PlayerScoreViewModel> TheirPlayers {get; set;} = new();
}

public class TradeResultViewModel
{
    public List<PlayerScoreViewModel> Receiving {get; set;} = new();
    public List<PlayerScoreViewModel> Giving {get; set;} = new();

    public double PointsGiven => Giving.Sum(p => p.Points);
    public double PointsReceived => Receiving.Sum(p => p.Points);
    
    public double Net => PointsReceived - PointsGiven;
}