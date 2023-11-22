using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace concessionária.Migrations
{
    public partial class ImagemCarro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "car_img",
                table: "Carros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "car_img",
                table: "Carros");
        }
    }
}
