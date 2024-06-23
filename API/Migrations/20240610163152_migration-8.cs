using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIJessicaOliveira2.Migrations
{
    /// <inheritdoc />
    public partial class migration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Notas",
                table: "Notas");

            migrationBuilder.RenameTable(
                name: "Notas",
                newName: "Nota");

            migrationBuilder.RenameIndex(
                name: "IX_Notas_CPF",
                table: "Nota",
                newName: "IX_Nota_CPF");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefone_Aluno",
                table: "Telefone_Aluno",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nota",
                table: "Nota",
                column: "Codigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefone_Aluno",
                table: "Telefone_Aluno");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nota",
                table: "Nota");

            migrationBuilder.RenameTable(
                name: "Nota",
                newName: "Notas");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CPF",
                table: "Notas",
                newName: "IX_Notas_CPF");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notas",
                table: "Notas",
                column: "Codigo");
        }
    }
}
