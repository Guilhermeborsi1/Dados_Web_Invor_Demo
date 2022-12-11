using Microsoft.EntityFrameworkCore.Migrations;

namespace Testes_Invor_Dados_Web.Migrations
{
    public partial class Produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fornecedor",
                table: "Produto",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fornecedor",
                table: "Produto");
        }
    }
}
