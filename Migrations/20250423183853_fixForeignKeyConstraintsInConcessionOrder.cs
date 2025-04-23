using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Haven.Migrations
{
    /// <inheritdoc />
    public partial class fixForeignKeyConstraintsInConcessionOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_ConcessionOrder_OrderID",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_OrderID",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Cart");

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "ConcessionOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ConcessionOrder_CartID",
                table: "ConcessionOrder",
                column: "CartID");

            migrationBuilder.AddForeignKey(
                name: "FK_ConcessionOrder_Cart_CartID",
                table: "ConcessionOrder",
                column: "CartID",
                principalTable: "Cart",
                principalColumn: "CartID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConcessionOrder_Cart_CartID",
                table: "ConcessionOrder");

            migrationBuilder.DropIndex(
                name: "IX_ConcessionOrder_CartID",
                table: "ConcessionOrder");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "ConcessionOrder");

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Cart",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_OrderID",
                table: "Cart",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_ConcessionOrder_OrderID",
                table: "Cart",
                column: "OrderID",
                principalTable: "ConcessionOrder",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
