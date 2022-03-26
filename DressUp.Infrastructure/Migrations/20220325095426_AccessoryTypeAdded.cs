using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Infrastructure.Migrations
{
    public partial class AccessoryTypeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccessoryType",
                table: "Accessories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessoryType",
                table: "Accessories");
        }
    }
}
