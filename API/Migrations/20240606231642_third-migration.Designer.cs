﻿// <auto-generated />
using System;
using APIJessicaOliveira2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIJessicaOliveira2.Migrations
{
    [DbContext(typeof(STUDIO_JESSICA_OLIVEIRA2Context))]
    [Migration("20240606231642_third-migration")]
    partial class thirdmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIJessicaOliveira2.Models.Aluno", b =>
                {
                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPF")
                        .IsFixedLength();

                    b.Property<DateOnly>("DataDeNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Disciplina")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Faltas")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nota")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Senha")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Cpf");

                    b.ToTable("Aluno", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Disciplina", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Codigo");

                    b.ToTable("Disciplina", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Endereço", b =>
                {
                    b.Property<string>("Cidade")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(14)
                        .HasColumnType("nchar(14)")
                        .HasColumnName("CNPJ")
                        .IsFixedLength();

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("nchar(2)")
                        .IsFixedLength();

                    b.Property<string>("Logradouro")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasIndex(new[] { "Cnpj" }, "IX_Endereço_CNPJ");

                    b.ToTable("Endereço", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.EndereçoAluno", b =>
                {
                    b.Property<string>("Cidade")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPF")
                        .IsFixedLength();

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("nchar(2)")
                        .IsFixedLength();

                    b.Property<string>("Logradouro")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasIndex(new[] { "Cpf" }, "IX_Endereço_Aluno_CPF");

                    b.ToTable("Endereço_Aluno", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.EndereçoProfessor", b =>
                {
                    b.Property<string>("Cidade")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPF")
                        .IsFixedLength();

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("nchar(2)")
                        .IsFixedLength();

                    b.Property<string>("Logradouro")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasIndex(new[] { "Cpf" }, "IX_Endereço_Professor_CPF");

                    b.ToTable("Endereço_Professor", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Escola", b =>
                {
                    b.Property<string>("Cpnj")
                        .HasMaxLength(14)
                        .HasColumnType("nchar(14)")
                        .HasColumnName("CPNJ")
                        .IsFixedLength();

                    b.Property<string>("Endereço")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Cpnj");

                    b.ToTable("Escola", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Financeiro", b =>
                {
                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPF")
                        .IsFixedLength();

                    b.Property<DateOnly>("DataBoleto")
                        .HasColumnType("date");

                    b.Property<string>("SituacaoPagamento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ValorBoleto")
                        .HasColumnType("decimal(10, 2)");

                    b.HasIndex(new[] { "Cpf" }, "IX_Financeiro_CPF");

                    b.ToTable("Financeiro", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Horario", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("AlunoCpf")
                        .HasColumnType("nchar(11)");

                    b.Property<int>("CodigoDisciplina")
                        .HasColumnType("int");

                    b.Property<string>("Cpfaluno")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPFAluno")
                        .IsFixedLength();

                    b.Property<string>("Cpfprofessor")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPFProfessor")
                        .IsFixedLength();

                    b.Property<string>("CpfsAlunosCpf")
                        .HasColumnType("nchar(11)");

                    b.Property<int>("NumeroSala")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("AlunoCpf");

                    b.HasIndex("CodigoDisciplina");

                    b.HasIndex("CpfsAlunosCpf");

                    b.HasIndex(new[] { "Cpfaluno" }, "IX_Horario_CPFAluno");

                    b.HasIndex(new[] { "Cpfprofessor" }, "IX_Horario_CPFProfessor");

                    b.HasIndex(new[] { "NumeroSala" }, "IX_Horario_NumeroSala");

                    b.ToTable("Horario", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Notas", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPF")
                        .IsFixedLength();

                    b.Property<string>("Nota")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Codigo");

                    b.HasIndex(new[] { "Cpf" }, "IX_Nota_CPF");

                    b.ToTable("Nota");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.PlanoDeAula", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("Cpfprofessor")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPFprofessor")
                        .IsFixedLength();

                    b.Property<string>("Musica")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumeroSala")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex(new[] { "Cpfprofessor" }, "IX_PlanoDeAula_CPFprofessor");

                    b.HasIndex(new[] { "NumeroSala" }, "IX_PlanoDeAula_NumeroSala");

                    b.ToTable("PlanoDeAula", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Professor", b =>
                {
                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPF")
                        .IsFixedLength();

                    b.Property<string>("Disciplina")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Cpf");

                    b.ToTable("Professor", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.SalaDeAula", b =>
                {
                    b.Property<int>("NumeroSala")
                        .HasColumnType("int");

                    b.HasKey("NumeroSala")
                        .HasName("PK_SalaDeAula_1");

                    b.ToTable("SalaDeAula", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.TelefoneAluno", b =>
                {
                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .HasColumnName("CPF")
                        .IsFixedLength();

                    b.Property<string>("Numero")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasIndex(new[] { "Cpf" }, "IX_Telefone_Aluno_CPF");

                    b.ToTable("Telefone_Aluno", (string)null);
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Endereço", b =>
                {
                    b.HasOne("APIJessicaOliveira2.Models.Escola", "Cnpjs")
                        .WithMany()
                        .HasForeignKey("Cnpj")
                        .HasConstraintName("FK_Escola_Endereço");

                    b.Navigation("Cnpjs");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.EndereçoAluno", b =>
                {
                    b.HasOne("APIJessicaOliveira2.Models.Professor", "Cpfs")
                        .WithMany()
                        .HasForeignKey("Cpf")
                        .HasConstraintName("FK_Endereço_Aluno");

                    b.Navigation("Cpfs");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.EndereçoProfessor", b =>
                {
                    b.HasOne("APIJessicaOliveira2.Models.Professor", "Cpfs")
                        .WithMany()
                        .HasForeignKey("Cpf")
                        .HasConstraintName("FK_Professor_Endereço");

                    b.Navigation("Cpfs");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Financeiro", b =>
                {
                    b.HasOne("APIJessicaOliveira2.Models.Professor", "Cpfs")
                        .WithMany()
                        .HasForeignKey("Cpf")
                        .HasConstraintName("FK_Financeiro_Aluno");

                    b.Navigation("Cpfs");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Horario", b =>
                {
                    b.HasOne("APIJessicaOliveira2.Models.Aluno", null)
                        .WithMany("Horarios")
                        .HasForeignKey("AlunoCpf");

                    b.HasOne("APIJessicaOliveira2.Models.Disciplina", "Disciplina")
                        .WithMany("Horarios")
                        .HasForeignKey("CodigoDisciplina")
                        .IsRequired()
                        .HasConstraintName("FK_Horario_Disciplina");

                    b.HasOne("APIJessicaOliveira2.Models.Professor", "Cpfsprofessor")
                        .WithMany("Horarios")
                        .HasForeignKey("Cpfprofessor")
                        .HasConstraintName("FK_Horario_CPF_Professor");

                    b.HasOne("APIJessicaOliveira2.Models.Professor", "CpfsAlunos")
                        .WithMany()
                        .HasForeignKey("CpfsAlunosCpf");

                    b.HasOne("APIJessicaOliveira2.Models.SalaDeAula", "NumeroSalas")
                        .WithMany("Horarios")
                        .HasForeignKey("NumeroSala")
                        .IsRequired()
                        .HasConstraintName("FK_Horario_NumeroSala");

                    b.Navigation("CpfsAlunos");

                    b.Navigation("Cpfsprofessor");

                    b.Navigation("Disciplina");

                    b.Navigation("NumeroSalas");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Notas", b =>
                {
                    b.HasOne("APIJessicaOliveira2.Models.Aluno", "CpfsAlunos")
                        .WithMany("Notas")
                        .HasForeignKey("Cpf")
                        .HasConstraintName("FK_Nota_Aluno");

                    b.Navigation("CpfsAlunos");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.PlanoDeAula", b =>
                {
                    b.HasOne("APIJessicaOliveira2.Models.Professor", "Cpfsprofessor")
                        .WithMany("PlanoDeAulas")
                        .HasForeignKey("Cpfprofessor")
                        .HasConstraintName("FK_PlanodeAula_Professor");

                    b.HasOne("APIJessicaOliveira2.Models.SalaDeAula", "NumeroSalas")
                        .WithMany("PlanoDeAulas")
                        .HasForeignKey("NumeroSala")
                        .IsRequired()
                        .HasConstraintName("FK_PlanoDeAula_NumeroSala");

                    b.Navigation("Cpfsprofessor");

                    b.Navigation("NumeroSalas");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.TelefoneAluno", b =>
                {
                    b.HasOne("APIJessicaOliveira2.Models.Professor", "CpfsAlunos")
                        .WithMany()
                        .HasForeignKey("Cpf")
                        .HasConstraintName("FK_Telefone_Aluno");

                    b.Navigation("CpfsAlunos");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Aluno", b =>
                {
                    b.Navigation("Horarios");

                    b.Navigation("Notas");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Disciplina", b =>
                {
                    b.Navigation("Horarios");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.Professor", b =>
                {
                    b.Navigation("Horarios");

                    b.Navigation("PlanoDeAulas");
                });

            modelBuilder.Entity("APIJessicaOliveira2.Models.SalaDeAula", b =>
                {
                    b.Navigation("Horarios");

                    b.Navigation("PlanoDeAulas");
                });
#pragma warning restore 612, 618
        }
    }
}
