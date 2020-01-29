using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShopSite.Migrations
{
    public partial class column_name_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pies",
                table: "Pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "IsPieOfWeek",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "PieId",
                table: "Pies",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsPieOfTheWeek",
                table: "Pies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Pies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Categories",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pies",
                table: "Pies",
                column: "PieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Fruit pies", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cheese cakes", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal pies", null });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. ", "Apple Pie", 12.95m, "Our famous apple pies!" },
                    { 4, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. ", "Cherry Pie", 15.95m, "A summer classic!" },
                    { 7, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", false, false, "Icing carrot cake jelly-o cheesecake. ", "Peach Pie", 15.95m, "Sweet as peach" },
                    { 9, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. ", "Rhubarb Pie", 15.95m, "My God, so sweet!" },
                    { 10, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. ", "Strawberry Pie", 15.95m, "Our delicious strawberry pie!" },
                    { 2, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. ", "Blueberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 3, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. ", "Cheese Cake", 18.95m, "Plain cheese cake. Plain pleasure." },
                    { 11, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", false, false, "Icing carrot cake jelly-o cheesecake. ", "Strawberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 5, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. ", "Christmas Apple Pie", 13.95m, "Happy holidays with this pie!" },
                    { 6, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. ", "Cranberry Pie", 17.95m, "A Christmas favorite" },
                    { 8, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. ", "Pumpkin Pie", 12.95m, "Our Halloween favorite" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pies",
                table: "Pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PieId",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "IsPieOfTheWeek",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Pies",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPieOfWeek",
                table: "Pies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pies",
                table: "Pies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
