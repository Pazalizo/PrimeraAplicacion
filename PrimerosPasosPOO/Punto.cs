using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasosPOO
{
    internal class Punto
    {
        public int x;
        public int y;
        public Punto(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        //Predeterminado
        public Punto() 
        {
            x = 0;
            y = 0;
        }

        public void MostrarValores()
        {
            Console.WriteLine($"({x},{y})");
        }

        public double CalcularDistancia(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.x - otroPunto.y;
            return xDif * yDif; 
        }

    }
}
