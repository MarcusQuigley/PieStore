using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShopSite.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, null, "Fruit pies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, null, "Cheese cakes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, null, "Seasonal pies" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "Id", "AllergyInformation", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfWeek", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, true, "Apple Pie", 12.95m, "Our famous apple pies!" },
                    { 4, "", 1, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, false, "Cherry Pie", 15.95m, "A summer classic!" },
                    { 7, "", 1, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", false, false, "Peach Pie", 15.95m, "Sweet as peach" },
                    { 9, "", 1, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", true, true, "Rhubarb Pie", 15.95m, "My God, so sweet!" },
                    { 10, "", 1, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, false, "Strawberry Pie", 15.95m, "Our delicious strawberry pie!" },
                    { 2, "", 2, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", true, false, "Blueberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 3, "", 2, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "Cheese Cake", 18.95m, "Plain cheese cake. Plain pleasure." },
                    { 11, "", 2, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", false, false, "Strawberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 5, "", 3, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", true, false, "Christmas Apple Pie", 13.95m, "Happy holidays with this pie!" },
                    { 6, "", 3, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", true, false, "Cranberry Pie", 17.95m, "A Christmas favorite" },
                    { 8, "", 3, "Icing carrot cake jelly-o cheesecake. ", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, true, "Pumpkin Pie", 12.95m, "Our Halloween favorite" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
