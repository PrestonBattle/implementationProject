using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThriveHavenMovies.Migrations
{
    /// <inheritdoc />
    public partial class ChangeConcessionEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Cost",
                table: "Concessions",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Concessions",
                columns: new[] { "ItemID", "Cost", "ImageUrl", "ItemName" },
                values: new object[,]
                {
                    { 1, 6.9900000000000002, "C:\\Users\\colec\\source\\repos\\ThriveHavenMovies\\ThriveHavenMovies\\wwwroot\\Images\\Concessions\\Popcorn.jpg", "Popcorn" },
                    { 2, 4.5800000000000001, "C:\\Users\\colec\\source\\repos\\ThriveHavenMovies\\ThriveHavenMovies\\wwwroot\\Images\\Concessions\\Soda.jpg", "Soda" },
                    { 3, 3.3999999999999999, "C:\\Users\\colec\\source\\repos\\ThriveHavenMovies\\ThriveHavenMovies\\wwwroot\\Images\\Concessions\\M&M.jpg", "M&M" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Concessions",
                keyColumn: "ItemID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "Cost",
                table: "Concessions",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
