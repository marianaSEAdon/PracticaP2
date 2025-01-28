 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    public class Administrativo : Empleado
    {
        private decimal SalarioBase = 38000;
        public bool metas { get; set; }


        public Administrativo (string nombre, string seguro, bool metasAlcanzadas) : base(nombre, seguro)
        {
            metas = metasAlcanzadas;
        }

        
        public override decimal CalcularSalarioMensual()
        {

            if (metas)
            {
                SalarioBase = SalarioBase * 1.10m;
                return SalarioBase;
            }
            else
            {
                return SalarioBase /  2;
            }
        
        }

        public override string ToString()
        {
            return $"Empleado Administrativo: {primerNombre}, Seguro Social: {SeguroSocial}, " +
                   $"Salario Mensual: {CalcularSalarioMensual()}";
        }


    }
}
