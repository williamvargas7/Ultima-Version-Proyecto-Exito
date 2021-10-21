namespace ConsolasExito.App.Dominio
{
    public class Videojuego
    {
        
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Version {get; set;}
        public string Fabricante {get; set;}
        public double PrecioCompra {get; set;}
        public double PrecioVenta {get; set;}
        public bool Multiplataforma {get; set;}
    }
}