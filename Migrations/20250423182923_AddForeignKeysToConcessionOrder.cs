using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Haven.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeysToConcessionOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Concession",
                table: "Concession");

            migrationBuilder.RenameTable(
                name: "Concession",
                newName: "Concessions");

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "ConcessionOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Cart",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concessions",
                table: "Concessions",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ConcessionOrder_ItemID",
                table: "ConcessionOrder",
                column: "ItemID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ConcessionOrder_Concessions_ItemID",
                table: "ConcessionOrder",
                column: "ItemID",
                principalTable: "Concessions",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_ConcessionOrder_OrderID",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_ConcessionOrder_Concessions_ItemID",
                table: "ConcessionOrder");

            migrationBuilder.DropIndex(
                name: "IX_ConcessionOrder_ItemID",
                table: "ConcessionOrder");

            migrationBuilder.DropIndex(
                name: "IX_Cart_OrderID",
                table: "Cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Concessions",
                table: "Concessions");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "ConcessionOrder");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "Concessions",
                newName: "Concession");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concession",
                table: "Concession",
                column: "ItemID");
        }
    }
}
