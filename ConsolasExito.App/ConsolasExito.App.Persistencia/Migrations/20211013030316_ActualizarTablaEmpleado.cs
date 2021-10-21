using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsolasExito.App.Persistencia.Migrations
{
    public partial class ActualizarTablaEmpleado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Sucursales_sucursalId",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "sucursalId",
                table: "Empleados",
                newName: "SucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_sucursalId",
                table: "Empleados",
                newName: "IX_Empleados_SucursalId");

            migrationBuilder.AddColumn<bool>(
                name: "PrimerIngreso",
                table: "Empleados",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "sucursal",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Sucursales_SucursalId",
                table: "Empleados",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Sucursales_SucursalId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "PrimerIngreso",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "sucursal",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "SucursalId",
                table: "Empleados",
                newName: "sucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_SucursalId",
                table: "Empleados",
                newName: "IX_Empleados_sucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Sucursales_sucursalId",
                table: "Empleados",
                column: "sucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
