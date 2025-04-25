using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThriveHavenMovies.Migrations
{
    /// <inheritdoc />
    public partial class AddMoviesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Genre", "ImageUrl", "Name", "Rating", "TimeFrame", "Year" },
                values: new object[,]
                {
                    { 1, "Musical/Romance", "/Images/MovieList/La La Land.jpg", "La La Land", "PG-13", "2h 8m", "2016" },
                    { 2, "Action", "/Images/MovieList/Oceans8.png", "Ocean's 8", "PG-13", "1hr 51m", "2018" },
                    { 3, "Romance/Drama", "/Images/MovieList/she's all that.jpg", "She's all that", "PG-13", "1h 35m", "1999" },
                    { 4, "Sci-Fi/Thriller", "/Images/MovieList/Arrival.jpg", "Arrival", "PG-13", "1h 56m", "2016" },
                    { 5, "Action/Thriller", "/Images/MovieList/Baby driver.jpg", "Baby Driver", "PG-13", "1h 55m", "2017" },
                    { 6, "Action/Sci-Fi", "/Images/MovieList/Civil war.jpg", "Captain America: Civil War", "PG-13", "2h 28m", "2016" },
                    { 7, "Romance/Drama", "/Images/MovieList/Crazy Rich Asians.jpg", "Crazy Rich Asians", "PG-13", "2h 1m", "2018" },
                    { 8, "Action", "/Images/MovieList/Fast and Furious 6.jpg", "Fast and Furious 6", "PG-13", "2h 10m", "2013" },
                    { 9, "Drama/Comedy", "/Images/MovieList/Grown Ups.jpg", "Grown ups", "PG-13", "1h 42m", "2010" },
                    { 10, "Musical", "/Images/MovieList/HairSpray.jpg", "Hairspray", "PG-13", "1h 57m", "2007" },
                    { 11, "Musical/Drama", "/Images/MovieList/Hamilton.jpg", "Hamilton", "PG-13", "2h 40m", "2020" },
                    { 12, "Action", "/Images/MovieList/Hunger Games.jpg", "Hunger Games", "PG-13", "2h 56m", "2012" },
                    { 13, "Drama", "/Images/MovieList/Mrs.Doubtfire.jpg", "Mrs.Doubtfire", "PG-13", "2h 6m", "1993" },
                    { 14, "Action/Thriller", "/Images/MovieList/Rush Hour.jpg", "Rush Hour", "PG-13", "1h 35m", "1998" },
                    { 15, "Sci-Fi/Action", "/Images/MovieList/Star wars.jpg", "Star Wars: The Rise of SkyWalker", "PG-13", "2h 22m", "2019" },
                    { 16, "Romance/Drama", "/Images/MovieList/The Great Gatsby.jpg", "The Great Gatsby", "PG-13", "2h 22m", "2013" },
                    { 17, "Sci-Fi", "/Images/MovieList/The Martian.jpg", "The Martian", "PG-13", "2h 31m", "2015" },
                    { 18, "Action", "/Images/MovieList/Tower Heist.jpg", "Tower Heist", "PG-13", "1h 44m", "2011" },
                    { 19, "Musical/Romance", "/Images/MovieList/West Side Story.jpg", "West side Story", "PG-13", "2h 36m", "2021" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 19);
        }
    }
}
