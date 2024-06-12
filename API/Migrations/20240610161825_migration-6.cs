using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIJessicaOliveira2.Migrations
{
    /// <inheritdoc />
    public partial class migration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Nota",
                table: "Nota");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlanoDeAula");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Horario");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Disciplina");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Nota");

            migrationBuilder.RenameTable(
                name: "Nota",
                newName: "Notas");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CPF",
                table: "Notas",
                newName: "IX_Notas_CPF");

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "PlanoDeAula",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Horario",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Disciplina",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Notas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notas",
                table: "Notas",
                column: "Codigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "PlanoDeAula",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PlanoDeAula",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Horario",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Horario",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Disciplina",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Disciplina",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Nota",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Nota",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nota",
                table: "Nota",
                column: "Codigo");
        }
    }
}
