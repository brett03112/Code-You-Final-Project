using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HolidayDessertStore.API.Migrations
{
    /// <inheritdoc />
    public partial class SyncDessertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Smooth cheesecake topped with orange glaze and fresh orange slices, decorated with whipped cream rosettes");

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Classic key lime tart with graham cracker crust and whipped cream border");

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "Id", "Description", "ImagePath", "IsAvailable", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 3, "Traditional rhubarb pie with lattice top crust and crystallized sugar finish", "/images/desserts/strawberry_rhubarb_pie.jpg", true, "Rhubarb Pie", 32.99m, 10 },
                    { 4, "Three-layer vanilla cake with fresh strawberries and whipped cream frosting", "/images/desserts/strawberry_shortcake.jpg", true, "Strawberry Layer Cake", 48.99m, 10 },
                    { 5, "Chocolate bundt cake filled with coconut-pecan filling and topped with shredded coconut", "/images/desserts/German_chocolate_bundt_cake.jpg", true, "German Chocolate Bundt Cake", 39.99m, 10 },
                    { 6, "Rich, gooey brownies with melted chocolate centers, perfect for chocolate lovers", "/images/desserts/brownies.jpg", true, "Double Chocolate Fudge Brownies", 24.99m, 10 },
                    { 7, "Classic cinnamon-sugar cookies with a festive twist, perfect with hot cocoa", "/images/desserts/snickerdoodle_cookies.jpg", true, "Holiday Snickerdoodle Cookies", 18.99m, 10 },
                    { 8, "Warm, flaky crust filled with sweet peaches and spices, served with candlelight ambiance", "/images/desserts/peach_cobbler.jpg", true, "Fresh Peach Cobbler", 28.99m, 10 },
                    { 9, "Traditional lattice-topped apple pie with cinnamon and spices, surrounded by fall decorations", "/images/desserts/apple_pie.jpg", true, "Classic Apple Pie", 32.99m, 10 },
                    { 10, "Creamy vanilla pudding layered with fresh bananas, vanilla wafers, and caramel drizzle", "/images/desserts/banana_pudding.jpg", true, "Banana Pudding Delight", 22.99m, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 10);

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

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Smooth cheesecake topped with orange glaze and fresh orange slices");

            migrationBuilder.UpdateData(
                table: "Desserts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Classic key lime tart with graham cracker crust");
        }
    }
}
