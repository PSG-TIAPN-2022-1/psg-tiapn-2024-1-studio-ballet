using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIJessicaOliveira2.Migrations
{
    /// <inheritdoc />
    public partial class thirdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereço_Aluno",
                table: "Endereço_Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Financeiro_Aluno",
                table: "Financeiro");

            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Aluno",
                table: "Horario");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Aluno",
                table: "Telefone_Aluno");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Professor",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "AlunoCpf",
                table: "Horario",
                type: "nchar(11)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CpfsAlunosCpf",
                table: "Horario",
                type: "nchar(11)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Horario_AlunoCpf",
                table: "Horario",
                column: "AlunoCpf");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_CpfsAlunosCpf",
                table: "Horario",
                column: "CpfsAlunosCpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereço_Aluno",
                table: "Endereço_Aluno",
                column: "CPF",
                principalTable: "Professor",
                principalColumn: "CPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Financeiro_Aluno",
                table: "Financeiro",
                column: "CPF",
                principalTable: "Professor",
                principalColumn: "CPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Aluno_AlunoCpf",
                table: "Horario",
                column: "AlunoCpf",
                principalTable: "Aluno",
                principalColumn: "CPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Professor_CpfsAlunosCpf",
                table: "Horario",
                column: "CpfsAlunosCpf",
                principalTable: "Professor",
                principalColumn: "CPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Aluno",
                table: "Telefone_Aluno",
                column: "CPF",
                principalTable: "Professor",
                principalColumn: "CPF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereço_Aluno",
                table: "Endereço_Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Financeiro_Aluno",
                table: "Financeiro");

            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Aluno_AlunoCpf",
                table: "Horario");

            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Professor_CpfsAlunosCpf",
                table: "Horario");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Aluno",
                table: "Telefone_Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Horario_AlunoCpf",
                table: "Horario");

            migrationBuilder.DropIndex(
                name: "IX_Horario_CpfsAlunosCpf",
                table: "Horario");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "AlunoCpf",
                table: "Horario");

            migrationBuilder.DropColumn(
                name: "CpfsAlunosCpf",
                table: "Horario");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereço_Aluno",
                table: "Endereço_Aluno",
                column: "CPF",
                principalTable: "Aluno",
                principalColumn: "CPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Financeiro_Aluno",
                table: "Financeiro",
                column: "CPF",
                principalTable: "Aluno",
                principalColumn: "CPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Aluno",
                table: "Horario",
                column: "CPFAluno",
                principalTable: "Aluno",
                principalColumn: "CPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Aluno",
                table: "Telefone_Aluno",
                column: "CPF",
                principalTable: "Aluno",
                principalColumn: "CPF");
        }
    }
}
