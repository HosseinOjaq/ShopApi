using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SetProductTitleToIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_Title",
                table: "Products",
                column: "Title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_Title",
                table: "Products");
        }
    }
}
