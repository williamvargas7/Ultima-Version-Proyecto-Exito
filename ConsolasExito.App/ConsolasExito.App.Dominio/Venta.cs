namespace ConsolasExito.App.Dominio
{
    public class Venta
    {
        public int Id {get; set;}
        public int NumeroFactura {get; set;}
        public Empleado empleadoventa {get; set;}
        public double ValorVenta {get; set;}
        public Sucursal SucursalVenta {get; set;}
    }
}