using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fixxo.Data.Migrations
{
    /// <inheritdoc />
    public partial class size : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxSize",
                table: "Shoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AvailableSizes",
                table: "Jackets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxSize",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "AvailableSizes",
                table: "Jackets");
        }
    }
}
