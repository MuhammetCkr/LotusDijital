using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusDijital.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageGalleries_Products_ProductId",
                table: "ImageGalleries");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageGalleries_Products_ProductId",
                table: "ImageGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageGalleries_Products_ProductId",
                table: "ImageGalleries");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageGalleries_Products_ProductId",
                table: "ImageGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
