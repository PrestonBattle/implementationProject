using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThriveHavenMovies.Migrations
{
    /// <inheritdoc />
    public partial class updatedConcessionOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConcessionOrders_Cart_CartID",
                table: "ConcessionOrders");

            migrationBuilder.AlterColumn<int>(
                name: "CartID",
                table: "ConcessionOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ConcessionOrders_Cart_CartID",
                table: "ConcessionOrders",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConcessionOrders_Cart_CartID",
                table: "ConcessionOrders");

            migrationBuilder.AlterColumn<int>(
                name: "CartID",
                table: "ConcessionOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ConcessionOrders_Cart_CartID",
                table: "ConcessionOrders",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
