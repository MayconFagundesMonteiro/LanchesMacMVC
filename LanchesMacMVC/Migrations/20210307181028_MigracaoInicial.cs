﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMacMVC.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoriaNome = table.Column<string>(maxLength: 100, nullable: true),
                    Descricao = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Lanches",
                columns: table => new
                {
                    LancheId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    DescricaoCurta = table.Column<string>(maxLength: 100, nullable: true),
                    DescricaoDetalhada = table.Column<string>(maxLength: 255, nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagemUrl = table.Column<string>(maxLength: 200, nullable: true),
                    ImagemThumbnailUrl = table.Column<string>(maxLength: 200, nullable: true),
                    IsLanchePreferido = table.Column<bool>(nullable: false),
                    EmEstoque = table.Column<bool>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanches", x => x.LancheId);
                    table.ForeignKey(
                        name: "FK_Lanches_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lanches_CategoriaId",
                table: "Lanches",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lanches");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
