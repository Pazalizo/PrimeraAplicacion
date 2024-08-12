using System.Diagnostics;
using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        string pase = "no";
        Console.WriteLine("Ingrese su edad");
        int edad = int.Parse(Console.ReadLine());
        if (edad > 18)
        {
            Console.WriteLine("Tienes Pase?");
            pase = Console.ReadLine();
            int comparar = String.Compare(pase, "si", true);
            if (comparar == 1)
            {
                Console.WriteLine("Ya le colaboro");
                Console.Beep();
                string url = "https://www.ceadelllano.com/";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            else Console.WriteLine("No necesita");
        }
        else Console.WriteLine("Espere unos years");
        
    }
}