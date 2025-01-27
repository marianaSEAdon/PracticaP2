 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    public class Administrativo : Empleado
    {
        public decimal SalarioBase;
        public Administrativo (string nombre, string seguro) : base(nombre, seguro)
        {
            
        }

        public override decimal CalcularSalarioMensual()
        {
            throw new NotImplementedException();
        }



    }
}
