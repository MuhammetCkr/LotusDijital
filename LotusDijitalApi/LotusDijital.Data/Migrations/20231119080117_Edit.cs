using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusDijital.Data.Migrations
{
    /// <inheritdoc />
    public partial class Edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageGalleries_InnerPages_InnerPageId",
                table: "ImageGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageGalleries_Products_ProductId",
                table: "ImageGalleries");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ImageGalleries",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "InnerPageId",
                table: "ImageGalleries",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageGalleries_InnerPages_InnerPageId",
                table: "ImageGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageGalleries_Products_ProductId",
                table: "ImageGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageGalleries_InnerPages_InnerPageId",
                table: "ImageGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageGalleries_Products_ProductId",
                table: "ImageGalleries");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ImageGalleries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InnerPageId",
                table: "ImageGalleries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageGalleries_InnerPages_InnerPageId",
                table: "ImageGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageGalleries_Products_ProductId",
                table: "ImageGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
