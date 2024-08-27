using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class FiguraGeometrica
    {
        private string nombre;
        public FiguraGeometrica(string nombre)
        {
            this.nombre = nombre;
        }
        public abstract double area();

        public static double areaPromedio(FiguraGeometrica[] figuras)
        {
            double suma = 0;
            for (int i = 0;i<figuras.Length;i++)
            {
                suma += figuras[i].area();
            }
            return suma/figuras.Length;
        }
    }
}
