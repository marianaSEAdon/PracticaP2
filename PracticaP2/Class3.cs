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

        public decimal Salario { get; set; }


        public decimal Horas { get; set; }

        public override decimal CalcularSalarioMensual()
        {
            return Salario * Horas;
        }

  


    }
}
