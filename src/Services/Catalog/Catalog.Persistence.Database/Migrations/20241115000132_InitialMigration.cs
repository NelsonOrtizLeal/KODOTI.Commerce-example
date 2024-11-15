using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description 1", "Product 1", 890m },
                    { 73, "Description 73", "Product 73", 405m },
                    { 72, "Description 72", "Product 72", 282m },
                    { 71, "Description 71", "Product 71", 406m },
                    { 70, "Description 70", "Product 70", 189m },
                    { 69, "Description 69", "Product 69", 209m },
                    { 68, "Description 68", "Product 68", 625m },
                    { 67, "Description 67", "Product 67", 903m },
                    { 66, "Description 66", "Product 66", 336m },
                    { 65, "Description 65", "Product 65", 924m },
                    { 64, "Description 64", "Product 64", 904m },
                    { 63, "Description 63", "Product 63", 203m },
                    { 62, "Description 62", "Product 62", 208m },
                    { 61, "Description 61", "Product 61", 248m },
                    { 60, "Description 60", "Product 60", 235m },
                    { 59, "Description 59", "Product 59", 576m },
                    { 58, "Description 58", "Product 58", 400m },
                    { 57, "Description 57", "Product 57", 912m },
                    { 56, "Description 56", "Product 56", 665m },
                    { 55, "Description 55", "Product 55", 235m },
                    { 54, "Description 54", "Product 54", 751m },
                    { 53, "Description 53", "Product 53", 512m },
                    { 74, "Description 74", "Product 74", 123m },
                    { 52, "Description 52", "Product 52", 745m },
                    { 75, "Description 75", "Product 75", 863m },
                    { 77, "Description 77", "Product 77", 768m },
                    { 98, "Description 98", "Product 98", 651m },
                    { 97, "Description 97", "Product 97", 967m },
                    { 96, "Description 96", "Product 96", 108m },
                    { 95, "Description 95", "Product 95", 930m },
                    { 94, "Description 94", "Product 94", 126m },
                    { 93, "Description 93", "Product 93", 820m },
                    { 92, "Description 92", "Product 92", 892m },
                    { 91, "Description 91", "Product 91", 239m },
                    { 90, "Description 90", "Product 90", 797m },
                    { 89, "Description 89", "Product 89", 181m },
                    { 88, "Description 88", "Product 88", 634m },
                    { 87, "Description 87", "Product 87", 523m },
                    { 86, "Description 86", "Product 86", 902m },
                    { 85, "Description 85", "Product 85", 126m },
                    { 84, "Description 84", "Product 84", 884m },
                    { 83, "Description 83", "Product 83", 664m },
                    { 82, "Description 82", "Product 82", 140m },
                    { 81, "Description 81", "Product 81", 355m },
                    { 80, "Description 80", "Product 80", 504m },
                    { 79, "Description 79", "Product 79", 721m },
                    { 78, "Description 78", "Product 78", 283m },
                    { 76, "Description 76", "Product 76", 306m },
                    { 51, "Description 51", "Product 51", 502m },
                    { 50, "Description 50", "Product 50", 390m },
                    { 49, "Description 49", "Product 49", 774m },
                    { 22, "Description 22", "Product 22", 324m },
                    { 21, "Description 21", "Product 21", 377m },
                    { 20, "Description 20", "Product 20", 980m },
                    { 19, "Description 19", "Product 19", 202m },
                    { 18, "Description 18", "Product 18", 566m },
                    { 17, "Description 17", "Product 17", 579m },
                    { 16, "Description 16", "Product 16", 600m },
                    { 15, "Description 15", "Product 15", 242m },
                    { 14, "Description 14", "Product 14", 573m },
                    { 13, "Description 13", "Product 13", 842m },
                    { 12, "Description 12", "Product 12", 289m },
                    { 11, "Description 11", "Product 11", 272m },
                    { 10, "Description 10", "Product 10", 572m },
                    { 9, "Description 9", "Product 9", 433m },
                    { 8, "Description 8", "Product 8", 378m },
                    { 7, "Description 7", "Product 7", 548m },
                    { 6, "Description 6", "Product 6", 868m },
                    { 5, "Description 5", "Product 5", 772m },
                    { 4, "Description 4", "Product 4", 432m },
                    { 3, "Description 3", "Product 3", 733m },
                    { 2, "Description 2", "Product 2", 231m },
                    { 23, "Description 23", "Product 23", 319m },
                    { 24, "Description 24", "Product 24", 433m },
                    { 25, "Description 25", "Product 25", 856m },
                    { 26, "Description 26", "Product 26", 637m },
                    { 48, "Description 48", "Product 48", 680m },
                    { 47, "Description 47", "Product 47", 382m },
                    { 46, "Description 46", "Product 46", 451m },
                    { 45, "Description 45", "Product 45", 711m },
                    { 44, "Description 44", "Product 44", 135m },
                    { 43, "Description 43", "Product 43", 556m },
                    { 42, "Description 42", "Product 42", 170m },
                    { 41, "Description 41", "Product 41", 217m },
                    { 40, "Description 40", "Product 40", 178m },
                    { 39, "Description 39", "Product 39", 261m },
                    { 99, "Description 99", "Product 99", 211m },
                    { 38, "Description 38", "Product 38", 396m },
                    { 36, "Description 36", "Product 36", 152m },
                    { 35, "Description 35", "Product 35", 463m },
                    { 34, "Description 34", "Product 34", 317m },
                    { 33, "Description 33", "Product 33", 385m },
                    { 32, "Description 32", "Product 32", 936m },
                    { 31, "Description 31", "Product 31", 648m },
                    { 30, "Description 30", "Product 30", 528m },
                    { 29, "Description 29", "Product 29", 275m },
                    { 28, "Description 28", "Product 28", 439m },
                    { 27, "Description 27", "Product 27", 720m },
                    { 37, "Description 37", "Product 37", 293m },
                    { 100, "Description 100", "Product 100", 475m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 83 },
                    { 73, 73, 35 },
                    { 72, 72, 79 },
                    { 71, 71, 8 },
                    { 70, 70, 39 },
                    { 69, 69, 76 },
                    { 68, 68, 59 },
                    { 67, 67, 47 },
                    { 66, 66, 74 },
                    { 65, 65, 88 },
                    { 64, 64, 55 },
                    { 63, 63, 24 },
                    { 62, 62, 67 },
                    { 61, 61, 78 },
                    { 60, 60, 12 },
                    { 59, 59, 67 },
                    { 58, 58, 41 },
                    { 57, 57, 9 },
                    { 56, 56, 86 },
                    { 55, 55, 37 },
                    { 54, 54, 30 },
                    { 53, 53, 38 },
                    { 74, 74, 99 },
                    { 52, 52, 83 },
                    { 75, 75, 16 },
                    { 77, 77, 90 },
                    { 98, 98, 51 },
                    { 97, 97, 21 },
                    { 96, 96, 51 },
                    { 95, 95, 88 },
                    { 94, 94, 75 },
                    { 93, 93, 93 },
                    { 92, 92, 20 },
                    { 91, 91, 22 },
                    { 90, 90, 35 },
                    { 89, 89, 84 },
                    { 88, 88, 99 },
                    { 87, 87, 99 },
                    { 86, 86, 31 },
                    { 85, 85, 86 },
                    { 84, 84, 13 },
                    { 83, 83, 73 },
                    { 82, 82, 36 },
                    { 81, 81, 76 },
                    { 80, 80, 45 },
                    { 79, 79, 76 },
                    { 78, 78, 58 },
                    { 76, 76, 87 },
                    { 51, 51, 35 },
                    { 50, 50, 52 },
                    { 49, 49, 65 },
                    { 22, 22, 96 },
                    { 21, 21, 33 },
                    { 20, 20, 34 },
                    { 19, 19, 65 },
                    { 18, 18, 23 },
                    { 17, 17, 40 },
                    { 16, 16, 69 },
                    { 15, 15, 72 },
                    { 14, 14, 98 },
                    { 13, 13, 81 },
                    { 12, 12, 77 },
                    { 11, 11, 11 },
                    { 10, 10, 3 },
                    { 9, 9, 77 },
                    { 8, 8, 90 },
                    { 7, 7, 6 },
                    { 6, 6, 84 },
                    { 5, 5, 96 },
                    { 4, 4, 9 },
                    { 3, 3, 63 },
                    { 2, 2, 98 },
                    { 23, 23, 88 },
                    { 24, 24, 22 },
                    { 25, 25, 41 },
                    { 26, 26, 83 },
                    { 48, 48, 70 },
                    { 47, 47, 7 },
                    { 46, 46, 96 },
                    { 45, 45, 46 },
                    { 44, 44, 29 },
                    { 43, 43, 6 },
                    { 42, 42, 45 },
                    { 41, 41, 18 },
                    { 40, 40, 66 },
                    { 39, 39, 88 },
                    { 99, 99, 41 },
                    { 38, 38, 61 },
                    { 36, 36, 32 },
                    { 35, 35, 22 },
                    { 34, 34, 21 },
                    { 33, 33, 29 },
                    { 32, 32, 37 },
                    { 31, 31, 15 },
                    { 30, 30, 22 },
                    { 29, 29, 66 },
                    { 28, 28, 38 },
                    { 27, 27, 6 },
                    { 37, 37, 61 },
                    { 100, 100, 72 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
