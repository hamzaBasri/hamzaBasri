using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MoveCosteToPropertyOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Property");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "PropertyOption",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "PropertyOption");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "Property",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
