using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradeAnalyzer.Migrations
{
    /// <inheritdoc />
    public partial class AddLeagueAndProjection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    NumberOfTeams = table.Column<int>(type: "INTEGER", nullable: false),
                    PointsPerPassingYard = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerPassingTd = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerInterception = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerRushingYard = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerRushingTd = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerFumblesLost = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerReceivingYard = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerReception = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerReceivingTd = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerExtraPoint = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerFieldGoal0to39 = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerFieldGoal40to49 = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerFieldGoal50Plus = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerDefensiveSack = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerDefensiveInterception = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerDefensiveFumbleRecovery = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerDefensiveTouchdown = table.Column<double>(type: "REAL", nullable: false),
                    PointsPerDefensiveSafety = table.Column<double>(type: "REAL", nullable: false),
                    DefensivePointsAllowed0 = table.Column<double>(type: "REAL", nullable: false),
                    DefensivePointsAllowed1to6 = table.Column<double>(type: "REAL", nullable: false),
                    DefensivePointsAllowed7to13 = table.Column<double>(type: "REAL", nullable: false),
                    DefensivePointsAllowed14to20 = table.Column<double>(type: "REAL", nullable: false),
                    DefensivePointsAllowed21to27 = table.Column<double>(type: "REAL", nullable: false),
                    DefensivePointsAllowed28to34 = table.Column<double>(type: "REAL", nullable: false),
                    DefensivePointsAllowed35Plus = table.Column<double>(type: "REAL", nullable: false),
                    QbSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    RbSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    WrSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    TeSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    KSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    DefSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    FlexSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    BenchSlots = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false),
                    LeagueId = table.Column<int>(type: "INTEGER", nullable: false),
                    Week = table.Column<int>(type: "INTEGER", nullable: false),
                    PassingYards = table.Column<double>(type: "REAL", nullable: false),
                    PassingTd = table.Column<double>(type: "REAL", nullable: false),
                    Interceptions = table.Column<double>(type: "REAL", nullable: false),
                    RushingYards = table.Column<double>(type: "REAL", nullable: false),
                    RushingTd = table.Column<double>(type: "REAL", nullable: false),
                    FumblesLost = table.Column<double>(type: "REAL", nullable: false),
                    ReceivingYards = table.Column<double>(type: "REAL", nullable: false),
                    Receptions = table.Column<double>(type: "REAL", nullable: false),
                    ReceivingTd = table.Column<double>(type: "REAL", nullable: false),
                    ExtraPoints = table.Column<double>(type: "REAL", nullable: false),
                    FieldGoals0to39 = table.Column<double>(type: "REAL", nullable: false),
                    FieldGoals40to49 = table.Column<double>(type: "REAL", nullable: false),
                    FieldGoals50Plus = table.Column<double>(type: "REAL", nullable: false),
                    Sacks = table.Column<double>(type: "REAL", nullable: false),
                    DefInterceptions = table.Column<double>(type: "REAL", nullable: false),
                    FumbleRecoveries = table.Column<double>(type: "REAL", nullable: false),
                    DefTouchdowns = table.Column<double>(type: "REAL", nullable: false),
                    Safeties = table.Column<double>(type: "REAL", nullable: false),
                    PointsAllowed = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projections_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projections_PlayerId",
                table: "Projections",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "Projections");
        }
    }
}
