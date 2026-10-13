using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TradeAnalyzer.Migrations
{
    /// <inheritdoc />
    public partial class IntitileCreate : Migration
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
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Position = table.Column<string>(type: "TEXT", nullable: false),
                    Team = table.Column<string>(type: "TEXT", nullable: false),
                    ByeWeek = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "BenchSlots", "DefSlots", "DefensivePointsAllowed0", "DefensivePointsAllowed14to20", "DefensivePointsAllowed1to6", "DefensivePointsAllowed21to27", "DefensivePointsAllowed28to34", "DefensivePointsAllowed35Plus", "DefensivePointsAllowed7to13", "FlexSlots", "KSlots", "Name", "NumberOfTeams", "PointsPerDefensiveFumbleRecovery", "PointsPerDefensiveInterception", "PointsPerDefensiveSack", "PointsPerDefensiveSafety", "PointsPerDefensiveTouchdown", "PointsPerExtraPoint", "PointsPerFieldGoal0to39", "PointsPerFieldGoal40to49", "PointsPerFieldGoal50Plus", "PointsPerFumblesLost", "PointsPerInterception", "PointsPerPassingTd", "PointsPerPassingYard", "PointsPerReceivingTd", "PointsPerReceivingYard", "PointsPerReception", "PointsPerRushingTd", "PointsPerRushingYard", "QbSlots", "RbSlots", "TeSlots", "WrSlots" },
                values: new object[] { 1, 6, 1, 10.0, 1.0, 7.0, 0.0, -1.0, -4.0, 4.0, 1, 1, "Default League", 12, 2.0, 2.0, 1.0, 2.0, 6.0, 1.0, 3.0, 4.0, 5.0, -2.0, -2.0, 4.0, 0.040000000000000001, 6.0, 0.10000000000000001, 1.0, 6.0, 0.10000000000000001, 1, 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ByeWeek", "Name", "Position", "Team" },
                values: new object[,]
                {
                    { 1, 5, "QB1", "QB", "TeamA" },
                    { 2, 6, "RB1", "RB", "TeamB" },
                    { 3, 7, "WR1", "WR", "TeamC" },
                    { 4, 8, "TE1", "TE", "TeamD" },
                    { 5, 9, "K1", "K", "TeamE" },
                    { 6, 10, "DEF1", "DEF", "TeamF" }
                });

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "DefInterceptions", "DefTouchdowns", "ExtraPoints", "FieldGoals0to39", "FieldGoals40to49", "FieldGoals50Plus", "FumbleRecoveries", "FumblesLost", "Interceptions", "PassingTd", "PassingYards", "PlayerId", "PointsAllowed", "ReceivingTd", "ReceivingYards", "Receptions", "RushingTd", "RushingYards", "Sacks", "Safeties", "Week" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 2.0, 300.0, 1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 2, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 2, 0.0, 0.0, 0.0, 0.0, 1.0, 100.0, 0.0, 0.0, 1 },
                    { 3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 3, 0.0, 1.0, 80.0, 5.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 4, 0.0, 0.0, 60.0, 4.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 5, 0.0, 0.0, 3.0, 2.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 5, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 6, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 6, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 3.0, 0.0, 1 }
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

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
