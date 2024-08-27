using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Cuadrado: FiguraGeometrica
    {
        private double lado;
        public Cuadrado(string nombre, double lado):base(nombre)
        {
            this.lado = lado;
        }
        public override double area()
        {
            return lado * lado;
        }
    }
}
