using Microsoft.EntityFrameworkCore;
using TradeAnalyzer.Models;

namespace TradeAnalyzer.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Player> Players => Set<Player>();

    public DbSet<League> Leagues => Set<League>();

    public DbSet<Projection> Projections => Set<Projection>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Player>().HasData(
            new Player { Id = 1, Name = "QB1", Position = "QB", Team = "TeamA", ByeWeek = 5 },
            new Player { Id = 2, Name = "RB1", Position = "RB", Team = "TeamB", ByeWeek = 6 },
            new Player { Id = 3, Name = "WR1", Position = "WR", Team = "TeamC", ByeWeek = 7 },
            new Player { Id = 4, Name = "TE1", Position = "TE", Team = "TeamD", ByeWeek = 8 },
            new Player { Id = 5, Name = "K1", Position = "K", Team = "TeamE", ByeWeek = 9 },
            new Player { Id = 6, Name = "DEF1", Position = "DEF", Team = "TeamF", ByeWeek = 10 }
        );

        modelBuilder.Entity<League>().HasData(
            new League { Id = 1, Name = "Default League", NumberOfTeams = 12 }
        );

        modelBuilder.Entity<Projection>().HasData(
            new Projection { Id = 1, PlayerId = 1, Week = 1, PassingYards = 300, PassingTd = 2, Interceptions = 1 },
            new Projection { Id = 2, PlayerId = 2, Week = 1, RushingYards = 100, RushingTd = 1, FumblesLost = 0 },
            new Projection { Id = 3, PlayerId = 3, Week = 1, ReceivingYards = 80, Receptions = 5, ReceivingTd = 1 },
            new Projection { Id = 4, PlayerId = 4, Week = 1, ReceivingYards = 60, Receptions = 4, ReceivingTd = 0 },
            new Projection { Id = 5, PlayerId = 5, Week = 1, ExtraPoints = 3, FieldGoals0to39 = 2 },
            new Projection { Id = 6, PlayerId = 6, Week = 1, Sacks = 3, DefInterceptions = 1 }
        );
    }
}

