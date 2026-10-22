namespace TradeAnalyzer.Models;

public class FantasyTeam
{
    public int Id {get; set;}
    public string Name {get; set;} = "";

    public int LeagueId {get; set;}
    public League League {get; set;} = null!;
}