namespace TradeAnalyzer.Models;

public class RosterSpot
{
    public int Id {get; set;}
    
    public int FantasyTeamId {get; set;}
    public FantasyTeam FantasyTeam {get; set;} = null!;

    public int PlayerId {get; set;}
    public Player Player {get; set;} = null!;
}
