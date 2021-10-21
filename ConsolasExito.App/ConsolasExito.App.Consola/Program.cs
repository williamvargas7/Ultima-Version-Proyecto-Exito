using System;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;
using System.Linq;



namespace ConsolasExito.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioEmpleado repositorioEmpleados = new RepositorioEmpleado();
            Empleado empleados = new Empleado();
           
            //Guardar empleado
           /* empleados.Nombres ="Pepito";
            empleados.Apellidos ="Perez";
            empleados.Edad ="29";
            empleados.Identidad ="515151";
            empleados.Usuario ="Charlie";
            empleados.Password ="151526548";
            //empleados.sucursal ="";
            empleados.RolPerson =NombreRol.VENDEDOR;
            empleados.accesoReportes =true;*/
            //repositorioEmpleados.guardarEmpleado(empleados);
            

            //Eliminar Empleado
            //repositorioEmpleados.eliminarEmpleado(4);
            

            //Buscar Empleado Nombre
            //repositorioEmpleados.consultarEmpleadoNombre("William");
            
            
            //Buscar Empleados Rol 
            //repositorioEmpleados.consultarEmpleadoRol(NombreRol.ADMINISTRADOR_COMPRAS);
           
            //Actualizar Empleados
           Empleado empleado1 = new Empleado();
   
            empleado1.Nombres ="Alex";
            empleado1.Apellidos ="Lopez";
            empleado1.Edad ="29";
            empleado1.Identidad ="111111";
            empleado1.Usuario ="Plopez";
            empleado1.Password ="zerthf334";
            //empleado1.sucursal ="";
            empleado1.RolPerson =NombreRol.VENDEDOR;
            empleado1.accesoReportes =true;

            //repositorioEmpleados.actualizarEmpleado(empleado1,6);

            //Console.WriteLine ("El empleado es: "+empleado1.Nombres +" "+empleado1.Apellidos);


            /*
            empleados.Nombres ="William";
            empleados.Apellidos ="Sanchez";
            empleados.Edad ="32";
            empleados.Identidad ="6666";
            empleados.Usuario ="Charlie";
            empleados.Password ="151526548";
            //empleados.sucursal ="";
            //empleados.RolPerson ="";
            empleados.accesoReportes =false;
            repositorioEmpleados.actualizarEmpleado(empleados);*/

            

            /*
            ConsolasExito.App.Dominio.Consola cs = new ConsolasExito.App.Dominio.Consola ();
            cs.Nombre="Xbox";
            cs.Version="xs";
            cs.Fabricante="Microsoft";
            cs.CapAlmacenamiento=500;
            cs.TipoAlmacenamiento=TipoAlmacenamiento.SSD; // Solucion con un if Cajon
            cs.VelocidadRam=16;
            cs.VelocidadProcesador=1024;
            cs.NumControles="2";
            cs.PrecioCompra=163.45;
            cs.PrecioVenta=190.45;
            

            ConsolasExito.App.Dominio.Empleado cs1 = new ConsolasExito.App.Dominio.Empleado ();
            cs1.Nombres="William";
            cs1.Apellidos="Vargas";
            cs1.Edad="12";
            cs1.Identidad="1234";
            cs1.Usuario="WilVar"; 
            cs1.Password="16AWD434";
            cs1.accesoReportes=true;
            

            ConsolasExito.App.Dominio.Control cs2 = new ConsolasExito.App.Dominio.Control ();
            cs2.PrecioCompra=50.4;
            cs2.PrecioVenta=45.6;


            ConsolasExito.App.Dominio.Sucursal cs3 = new ConsolasExito.App.Dominio.Sucursal ();
            cs3.Nombre="Manizales";
            cs3.Nit="123456";


            ConsolasExito.App.Dominio.Venta cs4 = new ConsolasExito.App.Dominio.Venta ();
            cs4.NumeroFactura=234;
            cs4.ValorVenta=234567.45;
            */
         
            /*
            Conexion conn = new Conexion();
            */
            /*
            conn.Consolas.Add(cs);
            conn.Empleados.Add(cs1);
            conn.Controles.Add(cs2);
            conn.Sucursales.Add(cs3);
            conn.Ventas.Add(cs4);
            conn.SaveChanges();
            */
        }
    }
}
