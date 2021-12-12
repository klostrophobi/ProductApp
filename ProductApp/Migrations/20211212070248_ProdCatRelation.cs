using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductApp.Migrations
{
    public partial class ProdCatRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "TB_PRODUCTS",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUCTS_CategoryID",
                table: "TB_PRODUCTS",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_CATEGORIES_CategoryID",
                table: "TB_PRODUCTS",
                column: "CategoryID",
                principalTable: "TB_CATEGORIES",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_CATEGORIES_CategoryID",
                table: "TB_PRODUCTS");

            migrationBuilder.DropIndex(
                name: "IX_TB_PRODUCTS_CategoryID",
                table: "TB_PRODUCTS");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "TB_PRODUCTS");
        }
    }
}
