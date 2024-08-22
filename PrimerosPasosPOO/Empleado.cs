using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasosPOO
{
    internal class Empleado
    {
        // Constructor Predeterminado
        public Empleado() 
        {
            
        }

        public void HojaDeVida()
        {
            Persona Felipe = new Persona("Felipe",22,1006231312);
            Console.WriteLine(Felipe.ToString());
        }
    }
}
