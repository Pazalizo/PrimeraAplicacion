using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaInterfaces
{
    public interface Deudas
    {
        public void Registrar(string descripcion, double valor, DateTime fecha, double identificacion);
        public void Quitar(int id_deuda);
    }
}
