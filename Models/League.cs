namespace TradeAnalyzer.Models;

public class League
{
    public int Id {get; set;}
    public string Name {get; set;} = "";
    public int NumberOfTeams {get; set;} = 12;

    public double PointsPerPassingYard {get; set;} = 0.04;
    public double PointsPerPassingTd {get; set;} = 4;
    public double PointsPerInterception {get; set;} = -2;
    public double PointsPerRushingYard {get; set;} = 0.1;
    public double PointsPerRushingTd {get; set;} = 6;
    public double PointsPerFumblesLost {get; set;} = -2;
    public double PointsPerReceivingYard {get; set;} = 0.1;
    public double PointsPerReception {get; set;} = 1;
    public double PointsPerReceivingTd {get; set;} = 6;
    public double PointsPerExtraPoint {get; set;} = 1;
    public double PointsPerFieldGoal0to39 {get; set;} = 3;
    public double PointsPerFieldGoal40to49 {get; set;} = 4;
    public double PointsPerFieldGoal50Plus {get; set;} = 5;
    public double PointsPerDefensiveSack {get; set;} = 1;
    public double PointsPerDefensiveInterception {get; set;} = 2;
    public double PointsPerDefensiveFumbleRecovery {get; set;} = 2;
    public double PointsPerDefensiveTouchdown {get; set;} = 6;
    public double PointsPerDefensiveSafety {get; set;} = 2;
    public double DefensivePointsAllowed0 {get; set;} = 10;
    public double DefensivePointsAllowed1to6 {get; set;} = 7;
    public double DefensivePointsAllowed7to13 {get; set;} = 4;
    public double DefensivePointsAllowed14to20 {get; set;} = 1;
    public double DefensivePointsAllowed21to27 {get; set;} = 0;
    public double DefensivePointsAllowed28to34 {get; set;} = -1;
    public double DefensivePointsAllowed35Plus {get; set;} = -4;

    public int QbSlots {get; set;} = 1;
    public int RbSlots {get; set;} = 2;
    public int WrSlots {get; set;} = 2;
    public int TeSlots {get; set;} = 1;
    public int KSlots {get; set;} = 1;
    public int DefSlots {get; set;} = 1;
    public int FlexSlots {get; set;} = 1;
    public int BenchSlots {get; set;} = 6;
}
    