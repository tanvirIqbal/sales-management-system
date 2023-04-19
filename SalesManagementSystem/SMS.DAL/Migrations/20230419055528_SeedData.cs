using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Name", "State" },
                values: new object[,]
                {
                    { 1, "New York Building 1", 31 },
                    { 2, "California Hotel AJK", 4 }
                });

            migrationBuilder.InsertData(
                table: "Windows",
                columns: new[] { "Id", "Name", "OrderId", "QuantityOfWindows", "TotalSubElements" },
                values: new object[,]
                {
                    { 1, "A51", 1, 4, 0 },
                    { 2, "C Zone 5", 1, 2, 0 },
                    { 3, "GLB", 2, 3, 0 },
                    { 4, "OHF", 2, 10, 0 }
                });

            migrationBuilder.InsertData(
                table: "SubElements",
                columns: new[] { "Id", "Element", "Height", "Type", "Width", "WindowId" },
                values: new object[,]
                {
                    { 1, 1, 1850, 0, 1200, 1 },
                    { 2, 2, 1850, 1, 800, 1 },
                    { 3, 3, 1850, 1, 700, 1 },
                    { 4, 1, 2000, 1, 1500, 2 },
                    { 5, 1, 2200, 0, 1400, 3 },
                    { 6, 2, 2200, 1, 600, 3 },
                    { 7, 1, 2000, 1, 1500, 4 },
                    { 8, 1, 2000, 1, 1500, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubElements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubElements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubElements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubElements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubElements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubElements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubElements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubElements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Windows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Windows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Windows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Windows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
