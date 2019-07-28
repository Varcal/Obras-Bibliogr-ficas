using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuideInvestimentos.Infra_Dados.Migrations
{
    public partial class _01_CriandoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.Id);
                });

            var sql = new StringBuilder();
            sql.AppendLine("INSERT INTO Autor(Nome)");
            sql.AppendLine("VALUES('ademir'), ('Carlos   drummond DE Andrade'), ('João da SilVA'), ('Maria das NeVes'), ('Ana LIMA SOBRinha'),");
            sql.AppendLine("('JOSÉ Silva Neto'), ('André Luis da Silva Neto'), ('Ulisses Ezequiel Junior'), ('JoÃo Neto'), ('NEto')");

            migrationBuilder.Sql(sql.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autor");
        }
    }
}
