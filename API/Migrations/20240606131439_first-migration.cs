using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIJessicaOliveira2.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    CPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Nota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Disciplina = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Faltas = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.CPF);
                });

            migrationBuilder.CreateTable(
                name: "Disciplina",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplina", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Escola",
                columns: table => new
                {
                    CPNJ = table.Column<string>(type: "nchar(14)", fixedLength: true, maxLength: 14, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Endereço = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escola", x => x.CPNJ);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    CPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Disciplina = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.CPF);
                });

            migrationBuilder.CreateTable(
                name: "SalaDeAula",
                columns: table => new
                {
                    NumeroSala = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaDeAula_1", x => x.NumeroSala);
                });

            migrationBuilder.CreateTable(
                name: "Endereço_Aluno",
                columns: table => new
                {
                    Logradouro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Estado = table.Column<string>(type: "nchar(2)", fixedLength: true, maxLength: 2, nullable: true),
                    CPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Endereço_Aluno",
                        column: x => x.CPF,
                        principalTable: "Aluno",
                        principalColumn: "CPF");
                });

            migrationBuilder.CreateTable(
                name: "Financeiro",
                columns: table => new
                {
                    ValorBoleto = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DataBoleto = table.Column<DateTime>(type: "date", nullable: false),
                    CPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: true),
                    SituacaoPagamento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Financeiro_Aluno",
                        column: x => x.CPF,
                        principalTable: "Aluno",
                        principalColumn: "CPF");
                });

            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Nota_Aluno",
                        column: x => x.CPF,
                        principalTable: "Aluno",
                        principalColumn: "CPF");
                });

            migrationBuilder.CreateTable(
                name: "Telefone_Aluno",
                columns: table => new
                {
                    Numero = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Telefone_Aluno",
                        column: x => x.CPF,
                        principalTable: "Aluno",
                        principalColumn: "CPF");
                });

            migrationBuilder.CreateTable(
                name: "Endereço",
                columns: table => new
                {
                    Logradouro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Estado = table.Column<string>(type: "nchar(2)", fixedLength: true, maxLength: 2, nullable: true),
                    CNPJ = table.Column<string>(type: "nchar(14)", fixedLength: true, maxLength: 14, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Escola_Endereço",
                        column: x => x.CNPJ,
                        principalTable: "Escola",
                        principalColumn: "CPNJ");
                });

            migrationBuilder.CreateTable(
                name: "Endereço_Professor",
                columns: table => new
                {
                    Logradouro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPF = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Estado = table.Column<string>(type: "nchar(2)", fixedLength: true, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Professor_Endereço",
                        column: x => x.CPF,
                        principalTable: "Professor",
                        principalColumn: "CPF");
                });

            migrationBuilder.CreateTable(
                name: "Horario",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    CodigoDisciplina = table.Column<int>(type: "int", nullable: false),
                    NumeroSala = table.Column<int>(type: "int", nullable: false),
                    CPFAluno = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: true),
                    CPFProfessor = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Horario_Aluno",
                        column: x => x.CPFAluno,
                        principalTable: "Aluno",
                        principalColumn: "CPF");
                    table.ForeignKey(
                        name: "FK_Horario_CPF_Professor",
                        column: x => x.CPFProfessor,
                        principalTable: "Professor",
                        principalColumn: "CPF");
                    table.ForeignKey(
                        name: "FK_Horario_Disciplina",
                        column: x => x.Codigo,
                        principalTable: "Disciplina",
                        principalColumn: "Codigo");
                    table.ForeignKey(
                        name: "FK_Horario_NumeroSala",
                        column: x => x.NumeroSala,
                        principalTable: "SalaDeAula",
                        principalColumn: "NumeroSala");
                });

            migrationBuilder.CreateTable(
                name: "PlanoDeAula",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    CPFprofessor = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: true),
                    NumeroSala = table.Column<int>(type: "int", nullable: false),
                    Musica = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoDeAula", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_PlanoDeAula_NumeroSala",
                        column: x => x.NumeroSala,
                        principalTable: "SalaDeAula",
                        principalColumn: "NumeroSala");
                    table.ForeignKey(
                        name: "FK_PlanodeAula_Professor",
                        column: x => x.CPFprofessor,
                        principalTable: "Professor",
                        principalColumn: "CPF");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereço_CNPJ",
                table: "Endereço",
                column: "CNPJ");

            migrationBuilder.CreateIndex(
                name: "IX_Endereço_Aluno_CPF",
                table: "Endereço_Aluno",
                column: "CPF");

            migrationBuilder.CreateIndex(
                name: "IX_Endereço_Professor_CPF",
                table: "Endereço_Professor",
                column: "CPF");

            migrationBuilder.CreateIndex(
                name: "IX_Financeiro_CPF",
                table: "Financeiro",
                column: "CPF");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_CPFAluno",
                table: "Horario",
                column: "CPFAluno");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_CPFProfessor",
                table: "Horario",
                column: "CPFProfessor");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_NumeroSala",
                table: "Horario",
                column: "NumeroSala");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_CPF",
                table: "Nota",
                column: "CPF");

            migrationBuilder.CreateIndex(
                name: "IX_PlanoDeAula_CPFprofessor",
                table: "PlanoDeAula",
                column: "CPFprofessor");

            migrationBuilder.CreateIndex(
                name: "IX_PlanoDeAula_NumeroSala",
                table: "PlanoDeAula",
                column: "NumeroSala");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_Aluno_CPF",
                table: "Telefone_Aluno",
                column: "CPF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereço");

            migrationBuilder.DropTable(
                name: "Endereço_Aluno");

            migrationBuilder.DropTable(
                name: "Endereço_Professor");

            migrationBuilder.DropTable(
                name: "Financeiro");

            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropTable(
                name: "Nota");

            migrationBuilder.DropTable(
                name: "PlanoDeAula");

            migrationBuilder.DropTable(
                name: "Telefone_Aluno");

            migrationBuilder.DropTable(
                name: "Escola");

            migrationBuilder.DropTable(
                name: "Disciplina");

            migrationBuilder.DropTable(
                name: "SalaDeAula");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
