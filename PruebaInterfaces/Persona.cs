using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInterfaces
{
    internal class Persona
    {
        
        private double identificacion { get; set; }
        private string nombres { get; set; }
        private string apellidos { get; set; }
        public Persona(double identificacion, string nombres, string apellidos)
        {
            this.identificacion = identificacion;
            this.nombres = nombres;
            this.apellidos = apellidos;
        }
    }
}
