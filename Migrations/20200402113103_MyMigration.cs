using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OurProduct.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PName = table.Column<string>(nullable: true),
                    PDesc = table.Column<string>(nullable: true),
                    PPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.PId);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "PId", "PDesc", "PName", "PPrice" },
                values: new object[,]
                {
                    { 1, "Stationery", "Pen", 10 },
                    { 2, "Gadget", "Mobile", 500 },
                    { 3, "Gadget", "Watch", 500 },
                    { 4, "Stationery", "NoteBook", 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
