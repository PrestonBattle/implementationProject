using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThriveHavenMovies.Migrations
{
    /// <inheritdoc />
    public partial class ConcessionOrderFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConcessionOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcessionOrders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_ConcessionOrders_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConcessionOrders_Concessions_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Concessions",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConcessionOrders_CartID",
                table: "ConcessionOrders",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_ConcessionOrders_ItemID",
                table: "ConcessionOrders",
                column: "ItemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConcessionOrders");
        }
    }
}
