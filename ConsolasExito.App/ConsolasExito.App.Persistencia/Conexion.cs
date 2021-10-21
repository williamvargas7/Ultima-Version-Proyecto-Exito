using Microsoft.EntityFrameworkCore;
using ConsolasExito.App.Dominio;

namespace ConsolasExito.App.Persistencia
{public class Conexion : DbContext
    {
        public DbSet<Empleado> Empleados {get; set;}
        public DbSet<Consola> Consolas {get; set;}
        public DbSet<Control> Controles {get; set;}
        public DbSet<Sucursal> Sucursales {get; set;}
        public DbSet<Videojuego> Videojuegos {get; set;}
        public DbSet<Venta> Ventas {get; set;}
        public DbSet<Administrador> Administradores {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder conn){
           if(!conn.IsConfigured){
                conn.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoExitoV1");
           }
       }
    }
}