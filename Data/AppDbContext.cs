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
            new Player { Id = 6, Name = "DEF1", Position = "DEF", Team = "TeamF", ByeWeek = 10 },
            new Player { Id = 7, Name = "QB2", Position = "QB", Team = "TeamG", ByeWeek = 5 },
            new Player { Id = 8, Name = "RB2", Position = "RB", Team = "TeamH", ByeWeek = 6 },
            new Player { Id = 9, Name = "WR2", Position = "WR", Team = "TeamI", ByeWeek = 7 },
            new Player { Id = 10, Name = "TE2", Position = "TE", Team = "TeamJ", ByeWeek = 8 },
            new Player { Id = 11, Name = "K2", Position = "K", Team = "TeamK", ByeWeek = 9 },
            new Player { Id = 12, Name = "DEF2", Position = "DEF", Team = "TeamL", ByeWeek = 10 },
            new Player { Id = 13, Name = "QB3", Position = "QB", Team = "TeamM", ByeWeek = 5 },
            new Player { Id = 14, Name = "RB3", Position = "RB", Team = "TeamN", ByeWeek = 6 },
            new Player { Id = 15, Name = "WR3", Position = "WR", Team = "TeamO", ByeWeek = 7 },
            new Player { Id = 16, Name = "TE3", Position = "TE", Team = "TeamP", ByeWeek = 8 }
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
            new Projection { Id = 6, PlayerId = 6, Week = 1, Sacks = 3, DefInterceptions = 1 },
            new Projection { Id = 7, PlayerId = 7, Week = 1, PassingYards = 250, PassingTd = 1, Interceptions = 2 },
            new Projection { Id = 8, PlayerId = 8, Week = 1, RushingYards = 120, RushingTd = 2, FumblesLost = 1 },
            new Projection { Id = 9, PlayerId = 9, Week = 1, ReceivingYards = 90, Receptions = 6, ReceivingTd = 1 },
            new Projection { Id = 10, PlayerId = 10, Week = 1, ReceivingYards = 70, Receptions = 3, ReceivingTd = 0 },
            new Projection { Id = 11, PlayerId = 11, Week = 1, ExtraPoints = 4, FieldGoals0to39 = 1 },
            new Projection { Id = 12, PlayerId = 12, Week = 1, Sacks = 2, DefInterceptions = 0 },
            new Projection { Id = 13, PlayerId = 13, Week = 1, PassingYards = 280, PassingTd = 3, Interceptions = 0 },
            new Projection { Id = 14, PlayerId = 14, Week = 1, RushingYards = 110, RushingTd = 1, FumblesLost = 0 },
            new Projection { Id = 15, PlayerId = 15, Week = 1, ReceivingYards = 85, Receptions = 4, ReceivingTd = 1 },
            new Projection { Id = 16, PlayerId = 16, Week = 1, ReceivingYards = 65, Receptions = 2, ReceivingTd = 0 }
        );
    }
}

