using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    public class EmpleadoPorHora : Empleado
    {
        public decimal horas;
        public EmpleadoPorHora(string nombre, string seguro, decimal horasTrabajadas) : base(nombre, seguro)
        {
            horas = horasTrabajadas;
         }

        public decimal Salario = 800;


        public decimal Horas { get; set; }

        public override decimal CalcularSalarioMensual()
        {
            return Salario * Horas;
        }

  


    }
}
