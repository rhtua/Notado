using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Notado.Migrations
{
    public partial class InitialMigration_home : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    cpf = table.Column<long>(nullable: false),
                    dtnasc = table.Column<DateTime>(nullable: false),
                    telefone = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    rua = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    numero = table.Column<int>(nullable: false),
                    complemento = table.Column<string>(nullable: true),
                    cep = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    Bimestre = table.Column<int>(nullable: false),
                    Prova = table.Column<float>(nullable: false),
                    Recuperacao = table.Column<float>(nullable: false),
                    Trabalho = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    cpf = table.Column<long>(nullable: false),
                    dtnasc = table.Column<DateTime>(nullable: false),
                    telefone = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    rua = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    numero = table.Column<int>(nullable: false),
                    complemento = table.Column<string>(nullable: true),
                    cep = table.Column<int>(nullable: false),
                    Formacao = table.Column<string>(nullable: true),
                    Disciplina = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ensino = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Divisor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Autorizacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    cpf = table.Column<long>(nullable: false),
                    dtnasc = table.Column<DateTime>(nullable: false),
                    telefone = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    rua = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    numero = table.Column<int>(nullable: false),
                    complemento = table.Column<string>(nullable: true),
                    cep = table.Column<int>(nullable: false),
                    vinculo = table.Column<string>(nullable: true),
                    profissao_responsavel_1 = table.Column<string>(nullable: true),
                    profissao_responsavel_2 = table.Column<string>(nullable: true),
                    dtnasc_responsavel_1 = table.Column<DateTime>(nullable: false),
                    estadoCivil_responsavel_1 = table.Column<string>(nullable: true),
                    escolaridade_responsavel_1 = table.Column<string>(nullable: true),
                    telefone_responsavel_1 = table.Column<string>(nullable: true),
                    telefone2_responsavel_1 = table.Column<string>(nullable: true),
                    telefone_responsavel_2 = table.Column<string>(nullable: true),
                    telefone2_responsavel_2 = table.Column<string>(nullable: true),
                    escolaridade_responsavel_2 = table.Column<string>(nullable: true),
                    estadoCivil_responsavel_2 = table.Column<string>(nullable: true),
                    dtnasc_responsavel_2 = table.Column<DateTime>(nullable: false),
                    vinculo2 = table.Column<string>(nullable: true),
                    nome_responsavel_1 = table.Column<string>(nullable: true),
                    email_responsavel_1 = table.Column<string>(nullable: true),
                    rg_responsavel_1 = table.Column<string>(nullable: true),
                    cpf_responsavel_1 = table.Column<long>(nullable: false),
                    nome_responsavel_2 = table.Column<string>(nullable: true),
                    email_responsavel_2 = table.Column<string>(nullable: true),
                    rg_responsavel_2 = table.Column<string>(nullable: true),
                    cpf_responsavel_2 = table.Column<string>(nullable: true),
                    TurmaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Turmas_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false),
                    TurmaId = table.Column<int>(nullable: false),
                    CargaHoraria = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Turmas_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
                    Nota = table.Column<float>(nullable: false),
                    DisciplinaID = table.Column<int>(nullable: false),
                    Bimestre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Provas_Disciplinas_DisciplinaID",
                        column: x => x.DisciplinaID,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recuperacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
                    Nota = table.Column<float>(nullable: false),
                    DisciplinaID = table.Column<int>(nullable: false),
                    Bimestre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recuperacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recuperacoes_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recuperacoes_Disciplinas_DisciplinaID",
                        column: x => x.DisciplinaID,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trabalhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: false),
                    Nota = table.Column<float>(nullable: false),
                    DisciplinaID = table.Column<int>(nullable: false),
                    Bimestre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabalhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trabalhos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trabalhos_Disciplinas_DisciplinaID",
                        column: x => x.DisciplinaID,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TurmaId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false),
                    ProvaId = table.Column<int>(nullable: true),
                    RecuperacaoId = table.Column<int>(nullable: true),
                    TrabalhoId = table.Column<int>(nullable: true),
                    AlunoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Provas_ProvaId",
                        column: x => x.ProvaId,
                        principalTable: "Provas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Recuperacoes_RecuperacaoId",
                        column: x => x.RecuperacaoId,
                        principalTable: "Recuperacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Trabalhos_TrabalhoId",
                        column: x => x.TrabalhoId,
                        principalTable: "Trabalhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Turmas_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TurmaId",
                table: "Alunos",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_AlunoId",
                table: "Avaliacoes",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_DisciplinaId",
                table: "Avaliacoes",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_ProvaId",
                table: "Avaliacoes",
                column: "ProvaId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_RecuperacaoId",
                table: "Avaliacoes",
                column: "RecuperacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_TrabalhoId",
                table: "Avaliacoes",
                column: "TrabalhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_TurmaId",
                table: "Avaliacoes",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_TurmaId",
                table: "Disciplinas",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Provas_AlunoId",
                table: "Provas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Provas_DisciplinaID",
                table: "Provas",
                column: "DisciplinaID");

            migrationBuilder.CreateIndex(
                name: "IX_Recuperacoes_AlunoId",
                table: "Recuperacoes",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recuperacoes_DisciplinaID",
                table: "Recuperacoes",
                column: "DisciplinaID");

            migrationBuilder.CreateIndex(
                name: "IX_Trabalhos_AlunoId",
                table: "Trabalhos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Trabalhos_DisciplinaID",
                table: "Trabalhos",
                column: "DisciplinaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adms");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Nota");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Provas");

            migrationBuilder.DropTable(
                name: "Recuperacoes");

            migrationBuilder.DropTable(
                name: "Trabalhos");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Turmas");
        }
    }
}
