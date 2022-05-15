using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestEDM.Infra.Migrations
{
    public partial class migration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotasDeDez = table.Column<int>(type: "int", nullable: false),
                    NotasDeVinte = table.Column<int>(type: "int", nullable: false),
                    NotasDeCinquenta = table.Column<int>(type: "int", nullable: false),
                    NotasDeCem = table.Column<int>(type: "int", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notas");
        }
    }
}
