using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsolasExito.App.Persistencia.Migrations
{
    public partial class ActualizarTablaEmpleado2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimerIngreso",
                table: "Empleados");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PrimerIngreso",
                table: "Empleados",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
