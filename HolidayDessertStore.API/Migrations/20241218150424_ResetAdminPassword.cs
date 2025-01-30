using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayDessertStore.API.Migrations
{
    /// <inheritdoc />
    public partial class ResetAdminPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "50d0ba35-9cb3-4505-90ba-8dac33b7e043");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2565c6b1-31e2-4ee2-8332-52d108d4e86b", "AQAAAAIAAYagAAAAEAdqXKA9JUuG4EnFrIljXcf1eGMsicu+UiPm7r7/mwi5rVVRZwcD+nM38zSGFu1r7g==", "b86aebfa-0913-40a3-92e7-bd78e5fd58be" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
