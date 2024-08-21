internal class Program
{
    static int solicitarNumero(int numeroMenor, int numeroMayor)
    {
        Console.WriteLine($"El numero esta entre {numeroMenor} y {numeroMayor}");
        int numero = int.Parse(Console.ReadLine());
        return numero;
    }
    static int generarNumeroAleatorio(int numeroMenor, int numeroMayor)
    {
        Random random = new Random();
        int randomNumber = random.Next(numeroMenor, numeroMayor +1);
        return randomNumber;
    }
    static void juegoAdivinar()
    {
        int opcionRepeticion = 0;
        do
        {
            Console.WriteLine("Bienvenido al juego");
            int numeroMenor = 1;
            int numero = 0;
            int numeroMayor = 10;
            int numeroAleatorio = generarNumeroAleatorio(numeroMenor, numeroMayor);
            int contador = 0;
            do
            {
                try
                {
                    numero = solicitarNumero(numeroMenor, numeroMayor);
                    contador++;
                }
                catch (Exception e) when (e.GetType()!=typeof(FormatException))
                {
                    Console.WriteLine("hubo un error en el codigo");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresaste una letra, tiene que ser un numero");
                }
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
            Console.WriteLine("Desea volver a ejecutar el juego?");
            string respuestaRepeticion = Console.ReadLine();
            opcionRepeticion = String.Compare(respuestaRepeticion, "si", true);
        }
        while (opcionRepeticion == 0);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        juegoAdivinar();
    }
}