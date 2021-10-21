using ConsolasExito.App.Dominio;
using System.Collections.Generic;
// CRUD
namespace ConsolasExito.App.Persistencia
{
    public interface IRepositorioEmpleado
    {
        public void guardarEmpleado(Empleado empleado);

        public void eliminarEmpleado(int id);

        public void actualizarEmpleado(Empleado empleado,int id);

        public Empleado consultarEmpleadoNombre(string nombres);

        public void consultarEmpleadoRol(NombreRol rol);

               
    }
}