 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    public class Administrativo : Empleado
    {
        private decimal SalarioBase { get; set; }
        public bool metas { get; set; }


        public Administrativo (string nombre, string seguro,decimal salario, bool metasAlcanzadas) : base(nombre, seguro)
        {
            metas = metasAlcanzadas;
            SalarioBase = salario;
        }

        
        public override decimal CalcularSalarioMensual()
        {

            throw new NotImplementedException();
        
        }



    }
}
