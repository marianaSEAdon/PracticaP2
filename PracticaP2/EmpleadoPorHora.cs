using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    public class EmpleadoPorHora : Empleado
    {
        
        public EmpleadoPorHora(string nombre, string seguro, decimal horasTrabajadas) : base(nombre, seguro)
        {
            Horas = horasTrabajadas;
         }
        public int TarifaPorHora = 800;
        public decimal Salario;
        public decimal Horas { get; set; }

        public override decimal CalcularSalarioMensual()
        {
            Salario = TarifaPorHora * Horas;
            return Salario;
        }

        public override string ToString()
        {
            return $"Empleado Por Hora: {primerNombre}, Seguro Social: {SeguroSocial}, " +
                   $"Salario Mensual: {CalcularSalarioMensual()}";
        }


    }
}
