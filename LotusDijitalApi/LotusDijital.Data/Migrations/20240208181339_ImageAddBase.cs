using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusDijital.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImageAddBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Images",
                newName: "Url");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Images",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Images",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Images",
                newName: "ImageUrl");
        }
    }
}
