using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayDessertStore.Migrations
{
    /// <inheritdoc />
    public partial class AddDessertQuantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Desserts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3128d6be-9e9b-4357-8dd3-51f83d2b636a", "AQAAAAIAAYagAAAAENJVGVNRj2IaVsvy3BZS00s7SA6nduKu/p4vw4zxe0ikrcriKz7e2s+Z8LNK9E9Vpw==", "95617d82-19b9-4e37-9a56-6044c6bc85da" });

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Quantity",
                value: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Desserts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2751561d-9ffa-43c2-b815-b5b65cc7f736", "AQAAAAIAAYagAAAAEOoaIPBy0uCN7ATgmoZOZGvqR/7oVhf4j4+i1sF55hVmcLNgEEfmyvpUWjqDJvPz9A==", "81bd5f42-7acd-4fc2-a4f0-8b5fe74bb988" });
        }
    }
}
