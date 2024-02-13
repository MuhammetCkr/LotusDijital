using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusDijital.Data.Migrations
{
    /// <inheritdoc />
    public partial class InnerPageConfig : Migration
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
                name: "FK_ImageGalleries_InnerPages_InnerPageId",
                table: "ImageGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGalleries_InnerPages_InnerPageId",
                table: "VideoGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGalleries_Products_ProductId",
                table: "VideoGalleries");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentGalleries_InnerPages_InnerPageId",
                table: "DocumentGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentGalleries_Products_ProductId",
                table: "DocumentGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageGalleries_InnerPages_InnerPageId",
                table: "ImageGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGalleries_InnerPages_InnerPageId",
                table: "VideoGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGalleries_Products_ProductId",
                table: "VideoGalleries",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
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
                name: "FK_ImageGalleries_InnerPages_InnerPageId",
                table: "ImageGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGalleries_InnerPages_InnerPageId",
                table: "VideoGalleries");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoGalleries_Products_ProductId",
                table: "VideoGalleries");

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
                name: "FK_ImageGalleries_InnerPages_InnerPageId",
                table: "ImageGalleries",
                column: "InnerPageId",
                principalTable: "InnerPages",
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
    }
}
