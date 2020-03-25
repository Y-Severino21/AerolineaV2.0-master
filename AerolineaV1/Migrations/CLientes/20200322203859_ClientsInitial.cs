using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AerolineaV1.Migrations.CLientes
{
    public partial class ClientsInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLientes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Destino = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    DIreccion = table.Column<string>(nullable: true),
                    FechaDeVuelo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLientes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLientes");
        }
    }
}
