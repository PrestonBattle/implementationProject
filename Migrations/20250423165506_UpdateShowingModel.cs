using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThriveHavenMovies.Migrations
{
    /// <inheritdoc />
    public partial class UpdateShowingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Showings_Movies_MovieId",
                table: "Showings");

            migrationBuilder.DropIndex(
                name: "IX_Showings_MovieId",
                table: "Showings");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Showings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Showings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Showings_MovieId",
                table: "Showings",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Showings_Movies_MovieId",
                table: "Showings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
