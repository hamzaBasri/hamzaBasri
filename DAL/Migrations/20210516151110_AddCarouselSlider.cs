using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddCarouselSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "ProductProperty");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "ProductProperty");

            migrationBuilder.AddColumn<int>(
                name: "OptionId",
                table: "ProductProperty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Carousel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carousel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperty_OptionId",
                table: "ProductProperty",
                column: "OptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProperty_PropertyOption_OptionId",
                table: "ProductProperty",
                column: "OptionId",
                principalTable: "PropertyOption",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProperty_PropertyOption_OptionId",
                table: "ProductProperty");

            migrationBuilder.DropTable(
                name: "Carousel");

            migrationBuilder.DropIndex(
                name: "IX_ProductProperty_OptionId",
                table: "ProductProperty");

            migrationBuilder.DropColumn(
                name: "OptionId",
                table: "ProductProperty");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "ProductProperty",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "ProductProperty",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
