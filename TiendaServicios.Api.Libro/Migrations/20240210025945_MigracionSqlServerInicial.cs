﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaServicios.Api.Libro.Migrations
{
    public partial class MigracionSqlServerInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibreriaMaterial",
                columns: table => new
                {
                    LibreriaMaterialId = table.Column<Guid>(nullable: false),
                    titulo = table.Column<string>(nullable: true),
                    FechaPublicacion = table.Column<DateTime>(nullable: false),
                    AutorLibro = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibreriaMaterial", x => x.LibreriaMaterialId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibreriaMaterial");
        }
    }
}
