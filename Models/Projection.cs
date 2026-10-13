namespace TradeAnalyzer.Models;

public class Projection
{
    public int Id {get; set;}

    //Link to the player this projection belongs to
    public int PlayerId {get; set;}
    public Player Player {get; set;} = null!;

    public int Week {get; set;}

    //Passing
    public double PassingYards {get; set;}
    public double PassingTd {get; set;}
    public double Interceptions {get; set;}

    //Rushing
    public double RushingYards {get; set;}
    public double RushingTd {get; set;}
    public double FumblesLost {get; set;}

    //Receiving
    public double ReceivingYards {get; set;}
    public double Receptions {get; set;}
    public double ReceivingTd {get; set;}

    //Kicking
    public double ExtraPoints {get; set;}
    public double FieldGoals0to39 {get; set;}
    public double FieldGoals40to49 {get; set;}
    public double FieldGoals50Plus {get; set;}

    //Defense
    public double Sacks {get; set;}
    public double DefInterceptions {get; set;}
    public double FumbleRecoveries {get; set;}
    public double DefTouchdowns {get; set;}
    public double Safeties {get; set;}
    public double PointsAllowed {get; set;}

}