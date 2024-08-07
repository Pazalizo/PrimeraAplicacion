internal class Program
{
    static void pruebaBucles()
    {
        //Bucle for
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("el valor de i:" + i);
        }
    }

    static void pruebaEstructuraControl()
    {
        //
    }

    static void pruebaVariables()
    {
        //
    }
    private static void Main(string[] args)
    {
        // Bucle do-while
        int k = 0;
        do
        {
            Console.WriteLine("Do-While loop, k = " + k);
            k++;
        } while (k < 5);

        k = 0;
        
        while(k < 5)
        {
            Console.WriteLine("el valor de k es = " + k);
            k++;
        }

        double temperatura = 32.5;

        int temperaturaVillavo;

        temperaturaVillavo = (int)temperatura;

        Console.WriteLine(temperaturaVillavo);
        Console.WriteLine(temperatura);
    }
}