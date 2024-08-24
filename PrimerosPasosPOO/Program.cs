using PrimerosPasosPOO;

internal class Program
{
    class Circulo
    {
        private const double pi = Math.PI;
        public double CalcularArea(int radio)
        {
            return pi * radio * radio;
        }
    }

    class Carro
    {
        private int cantidadllantas;
        private int cantidadPuertas;
        public Carro()
        {
            cantidadllantas = 4;
            cantidadPuertas = 2;
        }

        public String infoCarro()
        {
            return $"el carro tiene {cantidadllantas} llantas y tiene {cantidadPuertas} puertas";
        }
    }
    private static void Main(string[] args)
    {
        Punto puntico = new Punto(32,45);
        puntico.MostrarValores();
        Punto puntico2 = new Punto(23, 17);
        Console.WriteLine(puntico.CalcularDistancia(puntico2));
        Persona Laura = new Persona("Laura", 25, 1121960568);


    }
    
}