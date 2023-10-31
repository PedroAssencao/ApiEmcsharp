using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTarefas.Migrations
{
    public partial class VincluloTarefa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "usuarioID",
                table: "tarefas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tarefas_usuarioID",
                table: "tarefas",
                column: "usuarioID");
             
            migrationBuilder.AddForeignKey(
                name: "FK_tarefas_Usuarios_usuarioID",
                table: "tarefas",
                column: "usuarioID",
                principalTable: "Usuarios",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tarefas_Usuarios_usuarioID",
                table: "tarefas");

            migrationBuilder.DropIndex(
                name: "IX_tarefas_usuarioID",
                table: "tarefas");

            migrationBuilder.DropColumn(
                name: "usuarioID",
                table: "tarefas");
        }
    }
}
