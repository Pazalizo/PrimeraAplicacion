using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasosPOO
{
    internal class Persona
    {
        private string nombrePersona;
        private int edad;
        private int cedula;
        public Persona(string nombrePersona, int edad, int cedula)
        {
            this.nombrePersona = nombrePersona;
            this.edad = edad;
            this.cedula = cedula;
        }
    }
}
