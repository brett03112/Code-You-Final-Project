using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayDessertStore.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "87c58e32-0185-4987-a2c8-00eff360dffc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06993cc3-ce0c-4e3f-a1c6-7ad8f943c74c", "AQAAAAIAAYagAAAAEBeKUFR39s5mLbk/vLYl6eR2kPVWGK0V7ZN28ogXMC6R/31aEzxqXVguXT/QwOb+cw==", "2138eeb8-78b6-4e96-aefc-ab0954dd16ba" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "19826870-154d-4470-a13b-f06cc489d077");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba13813d-c060-4047-9114-60f1c22125b4", "AQAAAAIAAYagAAAAEMaqzq+jWt6KUvh7OFgBgWH9+oiT6EiQzkqJk7F209qHOiUjrLskrWTwH3dabca6zw==", "0d883f25-d373-445f-a4bd-deb3d18cf7af" });
        }
    }
}
