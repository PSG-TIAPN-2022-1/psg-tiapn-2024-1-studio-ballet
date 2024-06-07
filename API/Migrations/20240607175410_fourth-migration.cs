using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIJessicaOliveira2.Migrations
{
    /// <inheritdoc />
    public partial class fourthmigration : Migration
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

            migrationBuilder.DropColumn(
                name: "AlunoCpf",
                table: "Horario");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Telefone_Aluno",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SalaDeAula",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PlanoDeAula",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Nota",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Horario",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Financeiro",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Endereço_Professor",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Endereço_Aluno",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Endereço",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Disciplina",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Financeiro",
                table: "Financeiro",
                column: "Id");

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
                name: "FK_Horario_Aluno_CpfsAlunosCpf",
                table: "Horario",
                column: "CpfsAlunosCpf",
                principalTable: "Aluno",
                principalColumn: "CPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Aluno",
                table: "Telefone_Aluno",
                column: "CPF",
                principalTable: "Aluno",
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
                name: "FK_Horario_Aluno_CpfsAlunosCpf",
                table: "Horario");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Aluno",
                table: "Telefone_Aluno");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Financeiro",
                table: "Financeiro");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Telefone_Aluno");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SalaDeAula");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlanoDeAula");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Nota");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Horario");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Financeiro");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Endereço_Professor");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Endereço_Aluno");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Endereço");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Disciplina");

            migrationBuilder.AddColumn<string>(
                name: "AlunoCpf",
                table: "Horario",
                type: "nchar(11)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Horario_AlunoCpf",
                table: "Horario",
                column: "AlunoCpf");

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
    }
}
