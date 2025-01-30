using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayDessertStore.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "83d7ca38-ef39-4961-92c0-f9bbd6545e47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45338823-de06-42c9-ae6e-e263419955cb", "AQAAAAIAAYagAAAAEH+PUleZFluckTuXCcnMKxM7/KntXPpoN240FiQ19TpzgiCfUBWUMT8fI2RZTtcncQ==", "3c28a33d-79f6-4c42-955d-19139784cb0a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
