using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void pruebaBucles()
    {
        // Bucle for
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("el valor de i: " + i);
        }

        // Bucle While
        int k = 0;
        while (k < 5)
        {
            Console.WriteLine($"el valor de k: {k}");
        }

        // Bucle Do While
        int d = 0;
        do
        {
            Console.WriteLine($"el valor de i: {d}");
            d++;
        }
        while (d < 5);

    }
    static void pruebaEstructuraControl()
    {
            // if
            int i = 0;
            if (i < 5)
            {
                Console.WriteLine(i);
            }
            switch (i)
            {
                case 0:
                    Console.WriteLine("el numero de i es 0");
                    break;
                case 1:
                    Console.WriteLine("el numero de i es 1");
                    break;
                default:
                    Console.WriteLine("el numero no es ni 0 ni 1");
                    break;
            }
    }

    static int suma(int numero1, int numero2)
    {
        int resultado = numero1+numero2 ;
        return resultado ;
    }

    static void segundoMetodo()
    {
        Console.WriteLine("hello world");
    }
    

    private static void Main(string[] args)
    {
        Console.WriteLine("Introduce el primer numero");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo numero");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = suma(num1,num2);

        Console.WriteLine($"El resultado de la suma es: {resultado}");
    }
}