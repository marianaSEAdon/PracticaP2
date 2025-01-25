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

        public decimal SalarioMesual
        {
            get
            {
                return salarioMesual;
            } 
            set
            {
                salarioMesual = ((value >= 0) ? value : 0); 
            } 
        }

        public override decimal CalcularSalarioMensual()
        {
            return SalarioMesual;
        }

        public override string ToString()
        {
            return string.Format("empleado Fijo: {0}\n{1}: {2:C}", 
                base.ToString(), "salario mensual", SalarioMesual);
        }


    }
}