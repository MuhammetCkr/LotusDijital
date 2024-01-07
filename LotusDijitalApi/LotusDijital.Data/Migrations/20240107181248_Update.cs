using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusDijital.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentGalleries_InnerPages_InnerPageId",
                table: "DocumentGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentGalleries_Products_ProductId",
                table: "DocumentGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_ImageGalleries_ImageGalleryId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_InnerPages_Pages_PageId",
                table: "InnerPages");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGalleries_InnerPages_InnerPageId",
                table: "VideoGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGalleries_Products_ProductId",
                table: "VideoGalleries");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "VideoGalleries",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "InnerPageId",
                table: "VideoGalleries",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PageId",
                table: "InnerPages",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ImageGalleryId",
                table: "Images",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "DocumentGalleries",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "InnerPageId",
                table: "DocumentGalleries",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentGalleries_InnerPages_InnerPageId",
                table: "DocumentGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentGalleries_Products_ProductId",
                table: "DocumentGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ImageGalleries_ImageGalleryId",
                table: "Images",
                column: "ImageGalleryId",
                principalTable: "ImageGalleries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InnerPages_Pages_PageId",
                table: "InnerPages",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGalleries_InnerPages_InnerPageId",
                table: "VideoGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGalleries_Products_ProductId",
                table: "VideoGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentGalleries_InnerPages_InnerPageId",
                table: "DocumentGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentGalleries_Products_ProductId",
                table: "DocumentGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_ImageGalleries_ImageGalleryId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_InnerPages_Pages_PageId",
                table: "InnerPages");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGalleries_InnerPages_InnerPageId",
                table: "VideoGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGalleries_Products_ProductId",
                table: "VideoGalleries");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "VideoGalleries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InnerPageId",
                table: "VideoGalleries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PageId",
                table: "InnerPages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImageGalleryId",
                table: "Images",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "DocumentGalleries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InnerPageId",
                table: "DocumentGalleries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentGalleries_InnerPages_InnerPageId",
                table: "DocumentGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentGalleries_Products_ProductId",
                table: "DocumentGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ImageGalleries_ImageGalleryId",
                table: "Images",
                column: "ImageGalleryId",
                principalTable: "ImageGalleries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InnerPages_Pages_PageId",
                table: "InnerPages",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGalleries_InnerPages_InnerPageId",
                table: "VideoGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGalleries_Products_ProductId",
                table: "VideoGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
