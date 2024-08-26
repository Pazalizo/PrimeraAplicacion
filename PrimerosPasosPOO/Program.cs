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

        int[] primerArray = {4};
        Persona[] arrayPersonas = new Persona[2];

        arrayPersonas[0] = new Persona("Felipe",321412123,212312313);
        arrayPersonas[1] = new Persona("Conan", 421312412, 123123);

        
        for (int i = 0; i < arrayPersonas.Length; i++) 
        {
            Console.WriteLine(arrayPersonas[i]);
        }

    }
    
}