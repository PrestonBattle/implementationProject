using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThriveHavenMovies.Migrations
{
    /// <inheritdoc />
    public partial class changeConcessionURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValue: 1,
                column: "ImageUrl",
                value: "/ThriveHavenMovies/wwwroot/Images/Concessions/Popcorn.jpg");

            migrationBuilder.UpdateData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValue: 2,
                column: "ImageUrl",
                value: "/ThriveHavenMovies/wwwroot/Images/Concessions/Soda.jpg");

            migrationBuilder.UpdateData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValue: 3,
                column: "ImageUrl",
                value: "/ThriveHavenMovies/wwwroot/Images/Concessions/M&M.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValue: 1,
                column: "ImageUrl",
                value: "C:\\Users\\colec\\source\\repos\\ThriveHavenMovies\\ThriveHavenMovies\\wwwroot\\Images\\Concessions\\Popcorn.jpg");

            migrationBuilder.UpdateData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValue: 2,
                column: "ImageUrl",
                value: "C:\\Users\\colec\\source\\repos\\ThriveHavenMovies\\ThriveHavenMovies\\wwwroot\\Images\\Concessions\\Soda.jpg");

            migrationBuilder.UpdateData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValue: 3,
                column: "ImageUrl",
                value: "C:\\Users\\colec\\source\\repos\\ThriveHavenMovies\\ThriveHavenMovies\\wwwroot\\Images\\Concessions\\M&M.jpg");
        }
    }
}
