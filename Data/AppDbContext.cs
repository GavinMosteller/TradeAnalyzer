using Microsoft.EntityFrameworkCore;
using TradeAnalyzer.Models;

namespace TradeAnalyzer.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Player> Players => Set<Player>();

    public DbSet<League> Leagues => Set<League>();

    public DbSet<Projection> Projections => Set<Projection>();
}
