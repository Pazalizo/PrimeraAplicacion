internal class Program
{
    private static void Main(string[] args)
    {

        // Filtrar los pares y multiplicar por 2
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var filtrado = from n in numeros
                       where n % 2 == 0
                       select n * 2;

        foreach(var numero in filtrado)
        {
            Console.WriteLine(numero);
        }


        // Filtrar Ordernar la lista alfabeticamente y seleccionar las 3 primeras
        List<string> nombres = new List<string> { "Juan", "Ana", "Carlos", "Beatriz", "Sofia" };

        var resultado = nombres.OrderBy(x => x).Take(3);
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
        // Agrupar una lista de enteros por su paridad (pares e impares) y contar cuántos hay en cada grupo
        var resultado2 = numeros.GroupBy(n => n % 2 == 0).Select(selector => selector.Key);

        Console.WriteLine(resultado2);
        foreach (var item in resultado2)
        {
            Console.WriteLine($"Par: {item}");
        }

        Salario salarioFelipe = new Salario();

        salarioFelipe.SALARIO = 1200;

        Console.WriteLine(salarioFelipe.SALARIO);

    }

    class Salario()
    {
        private double cantidadSalario;
        void establecerSalario(double cantidadSalario)
        {
            if (cantidadSalario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo, se pondra 0");
                this.cantidadSalario = 0;
            }
            else this.cantidadSalario = cantidadSalario;
        }

        public double SALARIO
        {
            get => this.cantidadSalario;
            set => this.establecerSalario(value);
        }

    }
}