using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TradeAnalyzer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                name: "FantasyTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LeagueId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FantasyTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FantasyTeams_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "RosterSpots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FantasyTeamId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RosterSpots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RosterSpots_FantasyTeams_FantasyTeamId",
                        column: x => x.FantasyTeamId,
                        principalTable: "FantasyTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RosterSpots_Players_PlayerId",
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
                    { 6, 10, "DEF1", "DEF", "TeamF" },
                    { 7, 5, "QB2", "QB", "TeamG" },
                    { 8, 6, "RB2", "RB", "TeamH" },
                    { 9, 7, "WR2", "WR", "TeamI" },
                    { 10, 8, "TE2", "TE", "TeamJ" },
                    { 11, 9, "K2", "K", "TeamK" },
                    { 12, 10, "DEF2", "DEF", "TeamL" },
                    { 13, 5, "QB3", "QB", "TeamM" },
                    { 14, 6, "RB3", "RB", "TeamN" },
                    { 15, 7, "WR3", "WR", "TeamO" },
                    { 16, 8, "TE3", "TE", "TeamP" }
                });

            migrationBuilder.InsertData(
                table: "FantasyTeams",
                columns: new[] { "Id", "LeagueId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Team One" },
                    { 2, 1, "Team Two" }
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
                    { 6, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 6, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 3.0, 0.0, 1 },
                    { 7, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 2.0, 1.0, 250.0, 7, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 8, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 8, 0.0, 0.0, 0.0, 0.0, 2.0, 120.0, 0.0, 0.0, 1 },
                    { 9, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 9, 0.0, 1.0, 90.0, 6.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 10, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 10, 0.0, 0.0, 70.0, 3.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 11, 0.0, 0.0, 4.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 11, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 12, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 12, 17.0, 0.0, 0.0, 0.0, 0.0, 0.0, 2.0, 0.0, 1 },
                    { 13, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 3.0, 280.0, 13, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 14, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 14, 0.0, 0.0, 0.0, 0.0, 1.0, 110.0, 0.0, 0.0, 1 },
                    { 15, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 15, 0.0, 1.0, 85.0, 4.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 16, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 16, 0.0, 0.0, 65.0, 2.0, 0.0, 0.0, 0.0, 0.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "RosterSpots",
                columns: new[] { "Id", "FantasyTeamId", "PlayerId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 2, 7 },
                    { 8, 2, 8 },
                    { 9, 2, 9 },
                    { 10, 2, 10 },
                    { 11, 2, 11 },
                    { 12, 2, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FantasyTeams_LeagueId",
                table: "FantasyTeams",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_PlayerId",
                table: "Projections",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_RosterSpots_FantasyTeamId",
                table: "RosterSpots",
                column: "FantasyTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_RosterSpots_PlayerId",
                table: "RosterSpots",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projections");

            migrationBuilder.DropTable(
                name: "RosterSpots");

            migrationBuilder.DropTable(
                name: "FantasyTeams");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Leagues");
        }
    }
}
