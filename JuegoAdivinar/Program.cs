internal class Program
{
    static int solicitarNumero(int numeroMenor, int numeroMayor)
    {
        Console.WriteLine($"El numero esta entre {numeroMenor} y {numeroMayor}");
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
        int numeroMenor = 1;
        int numero = 0;
        int numeroMayor = 100;
        int numeroAleatorio = generarNumeroAleatorio();
        int contador = 0;
        do
        {
            numero = solicitarNumero(numeroMenor, numeroMayor);
            contador++;
            if (numero == numeroAleatorio)
            {
                Console.WriteLine($"Ganaste el juego el numero era {numero}, ganaste con {contador} intentos");
            }
            else if (numero < numeroAleatorio)
            {
                numeroMenor = numero;
            }
            else
            {
                numeroMayor = numero;
            }
        }
        while (numero != numeroAleatorio);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        juegoAdivinar();
    }
}