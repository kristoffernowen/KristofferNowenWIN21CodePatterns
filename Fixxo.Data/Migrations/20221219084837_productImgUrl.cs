using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fixxo.Data.Migrations
{
    /// <inheritdoc />
    public partial class productImgUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Shoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Jackets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Jackets");
        }
    }
}
