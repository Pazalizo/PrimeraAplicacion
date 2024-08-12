using System.Diagnostics;
using System.Net.NetworkInformation;

internal class Program
{
    static void Pase()
    {
        string pase = "no";
        Console.WriteLine("Ingrese su edad");
        int edad = int.Parse(Console.ReadLine());
        if (edad > 18)
        {
            Console.WriteLine("Tienes Pase?");
            pase = Console.ReadLine();
            int comparar = String.Compare(pase, "si", true);
            if (comparar == 0) Console.WriteLine("No necesita");
            else
            {
                Console.WriteLine("Ya le colaboro");
                Console.Beep();
                string url = "https://www.ceadelllano.com/";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }

        }
        else Console.WriteLine("Espere unos years");
    }

    static void usoSwitchCase(int opcion, double numero1, double numero2)
    {
        switch (opcion)
        {
            case 0:
                Console.WriteLine($"el resultado de la suma es {numero1 + numero2}");
                break;
            case 1:
                Console.WriteLine($"el resultado de la resta es {numero1 - numero2}");
                break;
            case 2:
                Console.WriteLine($"el resultado de la multiplicacion es {numero1 * numero2}");
                break;
            case 3:
                Console.WriteLine($"el resultado de la division es {numero1 / numero2}");
                break;
        }
    }

    static int seleccion()
    {
        int opcion;
        Console.WriteLine("Bienvenido");
        Console.WriteLine("escriba 0 para sumar");
        Console.WriteLine("escriba 1 para restar");
        Console.WriteLine("escriba 2 para multiplicar");
        Console.WriteLine("escriba 3 para dividir");
        Console.WriteLine("escriba 4 para salir");
        return opcion = int.Parse(Console.ReadLine());
    }

    static double solicitarNumero()
    {
        double numero;
        Console.WriteLine("Ingrese un numero");
        return numero = double.Parse(Console.ReadLine());
    }

    static void CalculadoraVersion1()
    {
        int opcion;
        do
        {
            opcion = seleccion();
            double numero1 = solicitarNumero();
            double numero2 = solicitarNumero();
            
        }
        while (opcion != 4);
    }
    private static void Main(string[] args)
    {
        CalculadoraVersion1();
    }
}