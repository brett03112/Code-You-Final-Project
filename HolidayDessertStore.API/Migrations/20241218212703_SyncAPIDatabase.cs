using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayDessertStore.API.Migrations
{
    /// <inheritdoc />
    public partial class SyncAPIDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0b825e0b-c7be-4a15-8016-248b82ad60c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "490aa355-1bd3-4e9d-ae7f-0a872f008a0c", "AQAAAAIAAYagAAAAEMKu6S+vpTdLWL3hnPJzXiqbhUemhDEnImYgzFopP8Ms5W7ZBOnrQkUT1as0IHgPcQ==", "884d4079-6138-43fb-92d6-58d122779856" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4d3ab39a-ac16-4b54-86cc-86f2dac8c2df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0f63764-2fe6-4cd9-91dd-ff4132c72ded", "AQAAAAIAAYagAAAAEOYVvVHhVsIjowlJwFrk5Fa70OH5OZjMKBPunBhfklPHw/BlIt8svZodJtMBznBPZg==", "95575f54-2f38-4d4f-8c27-922ba0dea075" });
        }
    }
}
