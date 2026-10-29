using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TradeAnalyzer.Data;
using TradeAnalyzer.Models;
using TradeAnalyzer.Services;

namespace TradeAnalyzer.Controllers;

public class TradeController : Controller
{
    private readonly AppDbContext _context;
    private readonly ScoringService _service;
    
    // ReSharper disable once ConvertToPrimaryConstructor
    public TradeController (AppDbContext context, ScoringService service)
    {
        _context = context;
        _service = service;
    }

    public IActionResult Index()
    {
        var league = _context.Leagues.First();

        var projections = _context.Projections
            .Include(p => p.Player)
            .ToList();

        var myPlayerIds = _context.RosterSpots
            .Where(rs => rs.FantasyTeamId == 1)
            .Select(rs => rs.PlayerId)
            .ToList();

        var theirPlayerIds = _context.RosterSpots
            .Where(rs => rs.FantasyTeamId == 2)
            .Select(rs => rs.PlayerId)
            .ToList();

        var myProjections = projections
            .Where(p => myPlayerIds.Contains(p.PlayerId))
            .ToList();
        
        var theirProjections = projections
            .Where(p => theirPlayerIds.Contains(p.PlayerId))
            .ToList();
        
        var myRows = new List<PlayerScoreViewModel>();
        var theirRows = new List<PlayerScoreViewModel>();

        foreach (var projection in myProjections)
        {
            var points = _service.CalculatePoints(projection, league);

            myRows.Add(new PlayerScoreViewModel
            {
                Id = projection.Player.Id,
                Name = projection.Player.Name,
                Position = projection.Player.Position,
                Team = projection.Player.Team,
                Points = points
            });
        }

        foreach (var projection in theirProjections)
        {
            var points = _service.CalculatePoints(projection, league);
            
            theirRows.Add(new PlayerScoreViewModel
            {
                Id = projection.Player.Id,
                Name = projection.Player.Name,
                Position = projection.Player.Position,
                Team = projection.Player.Team,
                Points = points
            });
        }

        var form = new TradeFormViewModel
        {
            MyPlayers = myRows,
            TheirPlayers = theirRows
        };

        return View(form);
    }

    [HttpPost]
    public IActionResult Result(List<int> givingIds, List<int> receivingIds)
    {
        var league = _context.Leagues.First();
        
        var givingProjections = _context.Projections
            .Where(p => givingIds.Contains(p.PlayerId))
            .Include(p => p.Player)
            .ToList();

        var receivingProjections = _context.Projections
            .Where(p => receivingIds.Contains(p.PlayerId))
            .Include(p => p.Player)
            .ToList();

        var givingRows = new List<PlayerScoreViewModel>();
        var receivingRows = new List<PlayerScoreViewModel>();

        foreach (var projection in givingProjections)
        {
            var points = _service.CalculatePoints(projection, league);

            givingRows.Add(new PlayerScoreViewModel
            {
                Id = projection.Player.Id,
                Name = projection.Player.Name,
                Position = projection.Player.Position,
                Team = projection.Player.Team,
                Points = points
            });
        }

        foreach (var projection in receivingProjections)
        {
            var points = _service.CalculatePoints(projection, league);

            receivingRows.Add(new PlayerScoreViewModel
            {
                Id = projection.Player.Id,
                Name = projection.Player.Name,
                Position = projection.Player.Position,
                Team = projection.Player.Team,
                Points = points
            });
        }

        var result = new TradeResultViewModel
        {
            Giving = givingRows,
            Receiving = receivingRows
        };
        return View(result);
    }
}