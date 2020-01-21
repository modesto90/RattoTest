using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ratto.Infra.Migrations
{
    public partial class Rattov2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Cliente");

            migrationBuilder.AddColumn<string>(
                name: "Idade",
                table: "Cliente",
                type: "varchar(3)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Cliente");

            migrationBuilder.AddColumn<DateTime>(
                name: "Nascimento",
                table: "Cliente",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
