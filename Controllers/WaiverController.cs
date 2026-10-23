using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TradeAnalyzer.Data;
using TradeAnalyzer.Models;
using TradeAnalyzer.Services;

namespace TradeAnalyzer.Controllers;

public class WaiverController : Controller
{
    private readonly AppDbContext _context;
    private readonly ScoringService _service;
    
    public WaiverController (AppDbContext context, ScoringService service)
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
        
        var rosteredIds = _context.RosterSpots
            .Select(pi => pi.PlayerId)
            .ToList();
        
        var filteredFreeAgent = projections
            .Where(p => !rosteredIds.Contains(p.PlayerId))
            .ToList();
    
        var rows = new List<WaiverViewModel>();

        foreach (var projection in filteredFreeAgent)
        {
            rows.Add(new WaiverViewModel
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