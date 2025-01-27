using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    public class EmpleadoFijo : Empleado
    {
        public decimal salarioMesual;
        public EmpleadoFijo(string nombre, string seguro, decimal salario) : base(nombre, seguro)
        {
            salarioMesual = salario;
        }

        public decimal SalarioMesual { get; set; }
        public override decimal CalcularSalarioMensual()
        {
            return SalarioMesual;
        }

    }
}