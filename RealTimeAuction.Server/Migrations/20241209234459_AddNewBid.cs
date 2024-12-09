using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealTimeAuction.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddNewBid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "NewBid",
                table: "Desserts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08d3ec11-d29f-4754-b6be-8d8701c7249e", "AQAAAAIAAYagAAAAEJrg9BPFff2TH/EgIgfCrqzMYVLxA2Vn3gTyX9EVfBpICv0N4cdF3KVja37zuGib8Q==", "a3d5ee85-c25f-449e-ae42-14733703053b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewBid",
                table: "Desserts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a20f5052-33e1-47db-bbf2-417cd1223364", "AQAAAAIAAYagAAAAEKU+Mlw1zfcvbWTLzNtTEhDpzb4LcRRwZxrSBhJytKHWpyjDdROkyUAAj3TMSdWcTg==", "9369edc8-c281-4038-83c5-e73b9fb47e20" });
        }
    }
}
