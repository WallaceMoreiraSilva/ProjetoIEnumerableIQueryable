using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_Estudo_Das_Interfaces.Migrations
{
    public partial class SeedDataTestes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Id", "Idade", "Nome" },
                values: new object[,]
                {
                    { 1, 30, "Maria" },
                    { 2, 25, "José" },
                    { 3, 28, "Amanda" },
                    { 4, 19, "Paulo" },
                    { 5, 20, "Fernanda" },
                    { 6, 18, "Camila" },
                    { 7, 21, "Ana" },
                    { 8, 23, "Germano" },
                    { 9, 17, "Selma" },
                    { 10, 22, "Vitor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
