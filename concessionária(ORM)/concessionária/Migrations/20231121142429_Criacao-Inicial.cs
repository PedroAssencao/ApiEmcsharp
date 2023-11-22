using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace concessionária.Migrations
{
    public partial class CriacaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    car_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    car_cor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    car_modelo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.car_id);
                });

            migrationBuilder.CreateTable(
                name: "Motos",
                columns: table => new
                {
                    mot_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mot_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    mot_cor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    mot_modelo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motos", x => x.mot_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Motos");
        }
    }
}
