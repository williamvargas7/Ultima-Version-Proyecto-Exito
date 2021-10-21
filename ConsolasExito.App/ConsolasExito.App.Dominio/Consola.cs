namespace ConsolasExito.App.Dominio
{
    public class Consola
    {

        public Consola() 
        {
             
        }
       
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Version {get; set;}
        public string Fabricante {get; set;}
        public int CapAlmacenamiento {get; set;}
        public TipoAlmacenamiento TipoAlmacenamiento {get; set;} //Agregacion TipoAlmacenamiento
        public int VelocidadRam {get; set;}
        public int VelocidadProcesador {get; set;}
        public string NumControles {get; set;}
        public double PrecioCompra {get; set;}
        public double PrecioVenta {get; set;}
        public Control controlc {get; set;}
        public Videojuego videojuegosc {get; set;}
        
    }
}