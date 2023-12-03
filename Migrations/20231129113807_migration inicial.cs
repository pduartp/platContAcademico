using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabConteudoAcademico.Migrations
{
    public partial class migrationinicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Postagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdUsuario = table.Column<int>(type: "INTEGER", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postagem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Postagem",
                columns: new[] { "Id", "Descricao", "IdUsuario" },
                values: new object[] { 1001, "teste", 1 });

            migrationBuilder.InsertData(
                table: "Postagem",
                columns: new[] { "Id", "Descricao", "IdUsuario" },
                values: new object[] { 1002, "teste", 1 });

            migrationBuilder.InsertData(
                table: "Postagem",
                columns: new[] { "Id", "Descricao", "IdUsuario" },
                values: new object[] { 1003, "teste", 1 });

            migrationBuilder.InsertData(
                table: "Postagem",
                columns: new[] { "Id", "Descricao", "IdUsuario" },
                values: new object[] { 1004, "teste", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Postagem");
        }
    }
}
