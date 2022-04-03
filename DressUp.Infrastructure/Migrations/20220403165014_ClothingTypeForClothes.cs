using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Infrastructure.Migrations
{
    public partial class ClothingTypeForClothes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClothingType",
                table: "Clothes",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClothingType",
                table: "Clothes");
        }
    }
}
