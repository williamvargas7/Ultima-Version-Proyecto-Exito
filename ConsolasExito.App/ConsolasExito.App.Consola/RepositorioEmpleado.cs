using System;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;
using System.Linq;

namespace ConsolasExito.App.Consola
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        Conexion conexion = new Conexion();


        public void guardarEmpleado(Empleado empleado){
            conexion.Empleados.Add(empleado);
            conexion.SaveChanges();
        }

        public void eliminarEmpleado(int id){
            var empleado = conexion.Empleados.First(e => e.Id == id);
            conexion.Empleados.Remove(empleado);
            conexion.SaveChanges();
        }

        public void actualizarEmpleado(Empleado empleado1,int id){
            var empleadoBusqueda = conexion.Empleados.First(e => e.Id == id);
            Console.WriteLine ("El empleado es: "+empleado1.Nombres +" "+empleado1.Apellidos);
            empleadoBusqueda.Nombres = empleado1.Nombres;
            empleadoBusqueda.Apellidos = empleado1.Apellidos;
            empleadoBusqueda.Identidad = empleado1.Identidad;
            empleadoBusqueda.Edad = empleado1.Edad;
            empleadoBusqueda.Usuario = empleado1.Usuario;
            empleadoBusqueda.Password = empleado1.Password;
            empleadoBusqueda.sucursal = empleado1.sucursal;
            empleadoBusqueda.RolPerson = empleado1.RolPerson;
            empleadoBusqueda.accesoReportes = empleado1.accesoReportes;
            Console.WriteLine ("El empleado es: "+empleadoBusqueda.Nombres +" "+empleadoBusqueda.Apellidos);
            conexion.SaveChanges();
           
        }


        public Empleado consultarEmpleadoNombre(string nombres){
            var empleadoBusqueda = conexion.Empleados.First(e => e.Nombres == nombres);
            Console.WriteLine ("El empleado es: "+empleadoBusqueda.Nombres +" "+empleadoBusqueda.Apellidos);
            return empleadoBusqueda;
        }

        public void consultarEmpleadoRol(NombreRol rol){
            var listaEmpleados = conexion.Empleados.Where(u => u.RolPerson == rol).ToList();
            foreach (Empleado u in listaEmpleados)
            Console.WriteLine ("Rol de empleado: "+rol+" "+u.Nombres +" "+u.Apellidos);
        }

    }
}