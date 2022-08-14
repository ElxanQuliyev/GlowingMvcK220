using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlowingMvcK220.Migrations
{
    public partial class seedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "PhotoUrl" },
                values: new object[] { 1, "EyeLiner", "" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "PhotoUrl" },
                values: new object[] { 2, "HairCream", "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "IsFavorite", "IsFeatured", "IsNew", "Name", "PhotoUrl", "Price", "Rating" },
                values: new object[] { 1, 1, "Niacinamide and Vitamin C are two anti-aging superstars but not usually formulated together because of their different pH levels.", null, false, true, true, "Natural Coconut Cleansing Oil", "http://templates.g5plus.net/glowing/images/product-07.jpg", 200m, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "IsFavorite", "IsFeatured", "IsNew", "Name", "PhotoUrl", "Price", "Rating" },
                values: new object[] { 2, 2, "Niacinamide 2 and Vitamin C are two anti-aging superstars but not usually formulated together because of their different pH levels.", 190.99m, true, false, false, "Natural 2", "http://templates.g5plus.net/glowing/images/product-9.jpg", 400m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
