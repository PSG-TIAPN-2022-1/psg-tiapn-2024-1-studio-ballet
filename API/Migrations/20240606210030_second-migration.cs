using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIJessicaOliveira2.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Disciplina",
                table: "Horario");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_CodigoDisciplina",
                table: "Horario",
                column: "CodigoDisciplina");

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Disciplina",
                table: "Horario",
                column: "CodigoDisciplina",
                principalTable: "Disciplina",
                principalColumn: "Codigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Disciplina",
                table: "Horario");

            migrationBuilder.DropIndex(
                name: "IX_Horario_CodigoDisciplina",
                table: "Horario");

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Disciplina",
                table: "Horario",
                column: "Codigo",
                principalTable: "Disciplina",
                principalColumn: "Codigo");
        }
    }
}
