using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoProdutos.Migrations
{
    public partial class NomeDaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Produtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
