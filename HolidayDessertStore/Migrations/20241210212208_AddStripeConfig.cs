using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayDessertStore.Migrations
{
    /// <inheritdoc />
    public partial class AddStripeConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2751561d-9ffa-43c2-b815-b5b65cc7f736", "AQAAAAIAAYagAAAAEOoaIPBy0uCN7ATgmoZOZGvqR/7oVhf4j4+i1sF55hVmcLNgEEfmyvpUWjqDJvPz9A==", "81bd5f42-7acd-4fc2-a4f0-8b5fe74bb988" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "982c5d88-3d3a-4aa5-93b2-f07b5a4c3e49", "AQAAAAIAAYagAAAAEGYEBkH+CO8uZrqe2kDRHMcLok3Y7RhErBh6dFwZbtW4pQjxZAJ8EcgLdlo6K57Bhg==", "752c7638-a9e6-4dc3-9817-21463783ec39" });
        }
    }
}
