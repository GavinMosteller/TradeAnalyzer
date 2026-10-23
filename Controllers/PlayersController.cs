using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TradeAnalyzer.Data;
using TradeAnalyzer.Models;
using TradeAnalyzer.Services;

namespace TradeAnalyzer.Controllers;

public class PlayersController : Controller
{
    private readonly AppDbContext _context;
    private readonly ScoringService _service;

    public PlayersController (AppDbContext context, ScoringService service)
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

        var rows = new List<PlayerScoreViewModel>();

        foreach (var projection in projections)
        {
            rows.Add(new PlayerScoreViewModel
            {
                Id = projection.Player.Id,
                Name = projection.Player.Name,
                Position = projection.Player.Position,
                Team = projection.Player.Team,
                Points = _service.CalculatePoints(projection, league)
            });
        }

        rows = rows.OrderByDescending(r => r.Points).ToList();

        return View(rows);
    }
}