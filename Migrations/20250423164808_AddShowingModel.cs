using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThriveHavenMovies.Migrations
{
    /// <inheritdoc />
    public partial class AddShowingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Showings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowingDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuditoriumId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Showings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Showings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Showings_MovieId",
                table: "Showings",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Showings");
        }
    }
}
