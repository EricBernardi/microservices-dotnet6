using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 4L, "One jusadusavds ad", "It is a long establaisbdjas dsa hdasdasj dbsad ", "http://nagdhsvdhasvbds.com.br", "Camisa no Internet", 69.9m },
                    { 5L, "One jusadusavds ad", "It is a long establaisbdjas dsa hdasdasj dbsad ", "http://nagdhsvdhasvbds.com.br", "Camisa no Internet", 69.9m },
                    { 6L, "One jusadusavds ad", "It is a long establaisbdjas dsa hdasdasj dbsad ", "http://nagdhsvdhasvbds.com.br", "Camisa no Internet", 69.9m },
                    { 7L, "One jusadusavds ad", "It is a long establaisbdjas dsa hdasdasj dbsad ", "http://nagdhsvdhasvbds.com.br", "Camisa no Internet", 69.9m },
                    { 8L, "One jusadusavds ad", "It is a long establaisbdjas dsa hdasdasj dbsad ", "http://nagdhsvdhasvbds.com.br", "Camisa no Internet", 69.9m },
                    { 9L, "One jusadusavds ad", "It is a long establaisbdjas dsa hdasdasj dbsad ", "http://nagdhsvdhasvbds.com.br", "Camisa no Internet", 69.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);
        }
    }
}
