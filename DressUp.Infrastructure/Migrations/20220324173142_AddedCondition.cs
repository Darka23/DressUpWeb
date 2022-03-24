using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DressUp.Infrastructure.Migrations
{
    public partial class AddedCondition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "Shoes",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "Clothes",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "Bags",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Bags");
        }
    }
}
