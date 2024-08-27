using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Circulo: FiguraGeometrica
    {
        private double radio;
        public Circulo(string nombre,double radio): base(nombre)  
        {
            this.radio = radio;
        }
        public override double area()
        {  
            return Math.PI * radio *radio;
        }
    }
}
