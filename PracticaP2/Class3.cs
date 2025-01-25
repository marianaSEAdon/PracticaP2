using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    public class EmpleadoPorHora : Empleado
    {
        public decimal salario;
        public decimal horas;
        public EmpleadoPorHora(string nombre, string seguro, decimal salarioPorHora, decimal horasTrabajadas) : base(nombre, seguro)
        {
            salario = salarioPorHora;
            horas = horasTrabajadas;
         }

        public decimal Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = ((value >= 0) ? value : 0);
            }
        }


        public decimal Horas
        {
            get
            {
                return horas;
            }
            set
            {
                horas = ((value >= 0) && (value <= 168)) ?
                    value : 0;
            }
        }

        public override decimal CalcularSalarioMensual()
        {
            return Salario * Horas;
        }

        public override string ToString()
        {
            return string.Format("empleado Por horas: {0}\n{1}: {2:C}; {3}: {4:F2}",
                base.ToString(), "salario por horas", Salario, "Horas trabajadas", Horas);
        }


    }
}
