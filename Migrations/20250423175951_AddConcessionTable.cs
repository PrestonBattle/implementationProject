using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Haven.Migrations
{
    /// <inheritdoc />
    public partial class AddConcessionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Concessions",
                table: "Concessions");

            migrationBuilder.RenameTable(
                name: "Concessions",
                newName: "Concession");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concession",
                table: "Concession",
                column: "ItemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Concession",
                table: "Concession");

            migrationBuilder.RenameTable(
                name: "Concession",
                newName: "Concessions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concessions",
                table: "Concessions",
                column: "ItemID");
        }
    }
}
