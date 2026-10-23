using TradeAnalyzer.Models;

namespace TradeAnalyzer.Services;

public class ScoringService
{
    public double CalculatePoints(Projection p, League l)
    {
        double Points = 0;

        //Passing
        Points += p.PassingYards * l.PointsPerPassingYard;
        Points += p.PassingTd * l.PointsPerPassingTd;
        Points += p.Interceptions * l.PointsPerInterception;

        //Rushing
        Points += p.RushingYards * l.PointsPerRushingYard;
        Points += p.RushingTd * l.PointsPerRushingTd;
        Points += p.FumblesLost * l.PointsPerFumblesLost;

        //Receiving
        Points += p.ReceivingYards * l.PointsPerReceivingYard;
        Points += p.Receptions * l.PointsPerReception;
        Points += p.ReceivingTd * l.PointsPerReceivingTd;

        //Kicking
        Points += p.ExtraPoints * l.PointsPerExtraPoint;
        Points += p.FieldGoals0to39 * l.PointsPerFieldGoal0to39;
        Points += p.FieldGoals40to49 * l.PointsPerFieldGoal40to49;
        Points += p.FieldGoals50Plus * l.PointsPerFieldGoal50Plus;

        //Defense
        Points += p.Sacks * l.PointsPerDefensiveSack;
        Points += p.DefInterceptions * l.PointsPerDefensiveInterception;
        Points += p.FumbleRecoveries * l.PointsPerDefensiveFumbleRecovery;
        Points += p.DefTouchdowns * l.PointsPerDefensiveTouchdown;
        Points += p.Safeties * l.PointsPerDefensiveSafety;

        //Points allowed
        if (p.Player.Position == "DEF")
        {
            Points += Math.Round(p.PointsAllowed) switch
            {
                0 => l.DefensivePointsAllowed0,
                >= 1 and <= 6 => l.DefensivePointsAllowed1to6,
                >= 7 and <= 13 => l.DefensivePointsAllowed7to13,
                >= 14 and <= 20 => l.DefensivePointsAllowed14to20,
                >= 21 and <= 27 => l.DefensivePointsAllowed21to27,
                >= 28 and <= 34 => l.DefensivePointsAllowed28to34,
                _ => l.DefensivePointsAllowed35Plus
            };
        }
        
        return Points;
    }
}