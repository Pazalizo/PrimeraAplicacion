using POO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Circulo circulo = new Circulo("Circulo1",5);
        Cuadrado cuadrado = new Cuadrado("Cuadrado1", 12);
        Rectangulo rectangulo = new Rectangulo("Rectangulo1", 12, 3);

        Console.WriteLine(circulo.area());
        Console.WriteLine(cuadrado.area());
        Console.WriteLine(rectangulo.area());

        FiguraGeometrica[] arrayFiguras = new FiguraGeometrica[3];
        arrayFiguras[0] = circulo;
        arrayFiguras[1] = cuadrado;
        arrayFiguras[2] = rectangulo;
        //Console.WriteLine(arrayFiguras);
        Console.WriteLine(FiguraGeometrica.areaPromedio(arrayFiguras));
    }
}