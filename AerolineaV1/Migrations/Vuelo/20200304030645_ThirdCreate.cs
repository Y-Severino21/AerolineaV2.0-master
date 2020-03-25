using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AerolineaV1.Migrations.Vuelo
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vuelos",
                columns: table => new
                {
                    VueloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destino = table.Column<string>(type: "varchar(30)", nullable: false),
                    Piloto = table.Column<string>(type: "varchar(25)", nullable: false),
                    ModeloAvion = table.Column<string>(type: "varchar(30)", nullable: false),
                    Pasajeros = table.Column<int>(type: "int", nullable: false),
                    FechaAbordaje = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelos", x => x.VueloID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vuelos");
        }
    }
}
