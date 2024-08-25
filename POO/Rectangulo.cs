using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Rectangulo: FiguraGeometrica
    {
        private double lado;
        private double altura;

        public Rectangulo(string nombre, double lado, double altura): base(nombre)
        {
            this.lado = lado;
            this.altura = altura;
        }

        public override double area()
        {
            return lado * altura;
        }
    }
}
