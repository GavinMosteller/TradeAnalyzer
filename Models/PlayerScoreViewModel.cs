namespace TradeAnalyzer.Models;

public class PlayerScoreViewModel
{
    public int Id {get; set;}
    public string Name {get; set;} = "";
    public string Position {get; set;} = "";
    public string Team {get; set;} = "";
    public double Points {get; set;}
}