using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TradeAnalyzer.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedPlayers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ByeWeek", "Name", "Position", "Team" },
                values: new object[,]
                {
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
                table: "Projections",
                columns: new[] { "Id", "DefInterceptions", "DefTouchdowns", "ExtraPoints", "FieldGoals0to39", "FieldGoals40to49", "FieldGoals50Plus", "FumbleRecoveries", "FumblesLost", "Interceptions", "PassingTd", "PassingYards", "PlayerId", "PointsAllowed", "ReceivingTd", "ReceivingYards", "Receptions", "RushingTd", "RushingYards", "Sacks", "Safeties", "Week" },
                values: new object[,]
                {
                    { 7, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 2.0, 1.0, 250.0, 7, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 8, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 8, 0.0, 0.0, 0.0, 0.0, 2.0, 120.0, 0.0, 0.0, 1 },
                    { 9, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 9, 0.0, 1.0, 90.0, 6.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 10, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 10, 0.0, 0.0, 70.0, 3.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 11, 0.0, 0.0, 4.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 11, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 12, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 12, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 2.0, 0.0, 1 },
                    { 13, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 3.0, 280.0, 13, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 14, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 14, 0.0, 0.0, 0.0, 0.0, 1.0, 110.0, 0.0, 0.0, 1 },
                    { 15, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 15, 0.0, 1.0, 85.0, 4.0, 0.0, 0.0, 0.0, 0.0, 1 },
                    { 16, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 16, 0.0, 0.0, 65.0, 2.0, 0.0, 0.0, 0.0, 0.0, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
