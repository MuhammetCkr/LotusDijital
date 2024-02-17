using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusDijital.Data.Migrations
{
    /// <inheritdoc />
    public partial class SettingsEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Favicon",
                table: "Settings",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Favicon",
                table: "Settings");
        }
    }
}
