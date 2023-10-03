using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarcketPlace.Infra.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Desativado = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CodigoResetarSenha = table.Column<string>(type: "CHAR(64)", nullable: true),
                    CodigoResetarSenhaExpiraEm = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NomeSocial = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desativado = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CodigoResetarSenha = table.Column<string>(type: "CHAR(64)", nullable: true),
                    CodigoResetarSenhaExpiraEm = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CriadoPor = table.Column<int>(type: "int", nullable: true),
                    CriadoPorAdmin = table.Column<bool>(type: "bit", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: true),
                    AtualizadoPorAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    CodigoResetarSenha = table.Column<string>(type: "CHAR(64)", nullable: true),
                    CodigoResetarSenhaExpiraEm = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Desativado = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Responsavel = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnuncioPago = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DataPagamentoAnuncio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExpiracaoAnuncio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CriadoPor = table.Column<int>(type: "int", nullable: true),
                    CriadoPorAdmin = table.Column<bool>(type: "bit", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: true),
                    AtualizadoPorAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoServicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    Foto2 = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    Foto3 = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    Foto4 = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    Foto5 = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    PrecoDesconto = table.Column<double>(type: "float", nullable: false),
                    Desativado = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caracteristica = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    AnuncioPago = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DataPagamentoAnuncio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExpiracaoAnuncio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CriadoPor = table.Column<int>(type: "int", nullable: true),
                    CriadoPorAdmin = table.Column<bool>(type: "bit", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: true),
                    AtualizadoPorAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoServicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoServicos_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoServicoCaracteristicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Chave = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdutoServicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoServicoCaracteristicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoServicoCaracteristicas_ProdutoServicos_ProdutoServicoId",
                        column: x => x.ProdutoServicoId,
                        principalTable: "ProdutoServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoServicoCaracteristicas_ProdutoServicoId",
                table: "ProdutoServicoCaracteristicas",
                column: "ProdutoServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoServicos_FornecedorId",
                table: "ProdutoServicos",
                column: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "ProdutoServicoCaracteristicas");

            migrationBuilder.DropTable(
                name: "ProdutoServicos");

            migrationBuilder.DropTable(
                name: "Fornecedores");
        }
    }
}
