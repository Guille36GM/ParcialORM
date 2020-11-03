using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Departamento = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Valor = table.Column<int>(nullable: false),
                    Fecha = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Identificacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
