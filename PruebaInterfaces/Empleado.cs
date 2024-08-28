using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInterfaces
{
    internal class Empleado : Persona, Deudas
    {
        private String cargo;
        private DateTime fechaIngreso;

        public Empleado(string nombre, string apellido, double id,string cargo, DateTime fechaIngreso): base(id,nombre,apellido)
        {
            this.cargo = cargo;
            this.fechaIngreso = fechaIngreso;
        }

        public void Quitar(int id_deuda)
        { 
            Console.WriteLine("Quitando deuda");
        }
    }
}
