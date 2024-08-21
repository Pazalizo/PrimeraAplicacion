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
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Circulo circulo1 = new Circulo();
        Console.WriteLine($"{circulo1.CalcularArea(53)}");
    }
}