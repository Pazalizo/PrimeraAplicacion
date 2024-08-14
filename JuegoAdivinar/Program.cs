internal class Program
{
    static int solicitarNumero(int numeroMenor, int numeroMayor)
    {
        Console.WriteLine($"Ingrese un numero del {numeroMenor} al {numeroMayor}");
        int numero = int.Parse(Console.ReadLine());
        return numero;
    }
    static int generarNumeroAleatorio()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        return randomNumber;
    }
    static void juegoAdivinar()
    {
        Console.WriteLine("Bienvenido al juego");
        //int numero = solicitarNumero();
        int numeroAleatorio = generarNumeroAleatorio();
        int contador = 0;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}