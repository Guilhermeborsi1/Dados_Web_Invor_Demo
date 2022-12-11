using Microsoft.EntityFrameworkCore.Migrations;

namespace Testes_Invor_Dados_Web.Migrations
{
    public partial class Clientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Funcionario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Cliente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Cliente");
        }
    }
}
