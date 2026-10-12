namespace TradeAnalyzer.Models;

public enum Position
{
    QB,
    RB,
    WR,
    TE,
    K,
    DEF
}
public class Player
{
    public int Id {get; set;}
    public string Name {get; set;} = "";
    public string Position {get; set;} = "";
    public string Team {get; set;} = "";
    public int ByeWeek {get; set;}
}