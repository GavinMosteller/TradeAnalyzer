namespace TradeAnalyzer.Models;

public class TradeFormViewModel
{
    public List<PlayerScoreViewModel> MyPlayers {get; set;} = new();
    public List<PlayerScoreViewModel> TheirPlayers {get; set;} = new();
}

public class TradeResultViewModel
{
    List<PlayerScoreViewModel> Receiving {get; set;} = new();
    List<PlayerScoreViewModel> Giving {get; set;} = new();

    double PointsGiven => Giving.Sum(p => p.Points);
    double PointsReceived => Receiving.Sum(p => p.Points);
    
    double Net => PointsReceived - PointsGiven;
}