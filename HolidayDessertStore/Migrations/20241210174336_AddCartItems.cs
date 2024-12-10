using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayDessertStore.Migrations
{
    /// <inheritdoc />
    public partial class AddCartItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CartId = table.Column<string>(type: "TEXT", nullable: false),
                    DessertId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Desserts_DessertId",
                        column: x => x.DessertId,
                        principalTable: "Desserts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "982c5d88-3d3a-4aa5-93b2-f07b5a4c3e49", "AQAAAAIAAYagAAAAEGYEBkH+CO8uZrqe2kDRHMcLok3Y7RhErBh6dFwZbtW4pQjxZAJ8EcgLdlo6K57Bhg==", "752c7638-a9e6-4dc3-9817-21463783ec39" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_DessertId",
                table: "CartItems",
                column: "DessertId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98d6ff40-bced-4b82-96df-5adab002745d", "AQAAAAIAAYagAAAAEGt0KPSiqMddENzt7mpDcN6PoHxB4FsBp15FI86I1Cj/Hkh7y41tczTx2Eo41Q0cIw==", "75464afd-ac4f-403d-9e83-e8044f2820f0" });
        }
    }
}
