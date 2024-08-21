internal class Program
{
    class Circulo
    {
        private const double pi = Math.PI;
        public double CalcularArea(int radio)
        {
            return pi * radio*radio;
        }
    }

    class Persona
    {
        private string nombrePersona;
        private int edad;
        private int cedula;
        public Persona()
        {
            this.edad = edad;
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
        Console.WriteLine("Hello, World!");
        Circulo circulo1 = new Circulo();
        Carro carro = new Carro();
        Console.WriteLine(circulo1.CalcularArea(53));
        Console.WriteLine(carro.infoCarro());
    }
}