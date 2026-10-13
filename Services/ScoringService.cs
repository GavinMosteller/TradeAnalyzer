using TradeAnalyzer.Models;

namespace TradeAnalyzer.Services;

public class ScoringService
{
    public double CalculatePoints(Projection p, League l)
    {
        double points = 0;

        //Passing
        points += p.PassingYards * l.PointsPerPassingYard;
        points += p.PassingTd * l.PointsPerPassingTd;
        points += p.Interceptions * l.PointsPerInterception;

        //Rushing
        points += p.RushingYards * l.PointsPerRushingYard;
        points += p.RushingTd * l.PointsPerRushingTd;
        points += p.FumblesLost * l.PointsPerFumblesLost;

        //Receiving
        points += p.ReceivingYards * l.PointsPerReceivingYard;
        points += p.Receptions * l.PointsPerReception;
        points += p.ReceivingTd * l.PointsPerReceivingTd;

        //Kicking
        points += p.ExtraPoints * l.PointsPerExtraPoint;
        points += p.FieldGoals0to39 * l.PointsPerFieldGoal0to39;
        points += p.FieldGoals40to49 * l.PointsPerFieldGoal40to49;
        points += p.FieldGoals50Plus * l.PointsPerFieldGoal50Plus;

        //Defense
        points += p.Sacks * l.PointsPerDefensiveSack;
        points += p.DefInterceptions * l.PointsPerDefensiveInterception;
        points += p.FumbleRecoveries * l.PointsPerDefensiveFumbleRecovery;
        points += p.DefTouchdowns * l.PointsPerDefensiveTouchdown;
        points += p.Safeties * l.PointsPerDefensiveSafety;

        //Points allowed
        if (p.Player.Position == "DEF")
        {
            points += Math.Round(p.PointsAllowed) switch
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
        
        return points;
    }
}