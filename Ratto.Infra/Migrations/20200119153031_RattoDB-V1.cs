using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ratto.Infra.Migrations
{
    public partial class RattoDBV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cpf_Numero = table.Column<string>(nullable: true),
                    Cpf_Tipo = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(30)", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logradouro_Valor = table.Column<string>(nullable: true),
                    Bairro_Valor = table.Column<string>(nullable: true),
                    Cidade_Valor = table.Column<string>(nullable: true),
                    Estado_Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
