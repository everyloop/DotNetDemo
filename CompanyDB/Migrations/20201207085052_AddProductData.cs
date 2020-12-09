using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyDB.Migrations
{
    public partial class AddProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "order_details",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "Discontinued", "ProductName", "QuantityPerUnit", "ReorderLevel", "SupplierId", "UnitPrice", "UnitsInStock", "UnitsOnOrder" },
                values: new object[,]
                {
                    { 1, null, null, "Chai", null, null, null, null, null, null },
                    { 2, null, null, "Chang", null, null, null, null, null, null },
                    { 3, null, null, "Aniseed Syrup", null, null, null, null, null, null },
                    { 4, null, null, "Chef Anton's Cajun Seasoning", null, null, null, null, null, null },
                    { 5, null, null, "Chef Anton's Gumbo Mix", null, null, null, null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "order_details",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);
        }
    }
}
