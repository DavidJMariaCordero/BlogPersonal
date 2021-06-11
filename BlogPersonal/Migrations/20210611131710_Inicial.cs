using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPersonal.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Contenido = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: true),
                    Resumen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 1, "Deportes" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 2, "Tecnologia" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 3, "Novedades" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 4, "Salud" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[] { 5, "Politica" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Post");
        }
    }
}
