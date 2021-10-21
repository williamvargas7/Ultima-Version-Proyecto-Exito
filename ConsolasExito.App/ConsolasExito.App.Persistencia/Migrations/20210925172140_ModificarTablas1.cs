using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsolasExito.App.Persistencia.Migrations
{
    public partial class ModificarTablas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Controles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioCompra = table.Column<double>(type: "float", nullable: false),
                    PrecioVenta = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videojuegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioCompra = table.Column<double>(type: "float", nullable: false),
                    PrecioVenta = table.Column<double>(type: "float", nullable: false),
                    Multiplataforma = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videojuegos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sucursalId = table.Column<int>(type: "int", nullable: true),
                    RolPerson = table.Column<int>(type: "int", nullable: false),
                    accesoReportes = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Sucursales_sucursalId",
                        column: x => x.sucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consolas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapAlmacenamiento = table.Column<int>(type: "int", nullable: false),
                    TipoAlmacenamiento = table.Column<int>(type: "int", nullable: false),
                    VelocidadRam = table.Column<int>(type: "int", nullable: false),
                    VelocidadProcesador = table.Column<int>(type: "int", nullable: false),
                    NumControles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioCompra = table.Column<double>(type: "float", nullable: false),
                    PrecioVenta = table.Column<double>(type: "float", nullable: false),
                    controlcId = table.Column<int>(type: "int", nullable: true),
                    videojuegoscId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consolas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consolas_Controles_controlcId",
                        column: x => x.controlcId,
                        principalTable: "Controles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consolas_Videojuegos_videojuegoscId",
                        column: x => x.videojuegoscId,
                        principalTable: "Videojuegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroFactura = table.Column<int>(type: "int", nullable: false),
                    empleadoventaId = table.Column<int>(type: "int", nullable: true),
                    ValorVenta = table.Column<double>(type: "float", nullable: false),
                    SucursalVentaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_Empleados_empleadoventaId",
                        column: x => x.empleadoventaId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Sucursales_SucursalVentaId",
                        column: x => x.SucursalVentaId,
                        principalTable: "Sucursales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consolas_controlcId",
                table: "Consolas",
                column: "controlcId");

            migrationBuilder.CreateIndex(
                name: "IX_Consolas_videojuegoscId",
                table: "Consolas",
                column: "videojuegoscId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_sucursalId",
                table: "Empleados",
                column: "sucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_empleadoventaId",
                table: "Ventas",
                column: "empleadoventaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_SucursalVentaId",
                table: "Ventas",
                column: "SucursalVentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consolas");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Controles");

            migrationBuilder.DropTable(
                name: "Videojuegos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Sucursales");
        }
    }
}
