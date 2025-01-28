using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoFijo empleadoFijo = new EmpleadoFijo("Mariana", "P1-4023", 16000, true);
            Console.WriteLine(empleadoFijo.ToString() );

            Empleado empleadoPorHora = new EmpleadoPorHora("Juan", "P2-1230", 4);
            Console.WriteLine(empleadoPorHora.ToString());

            Empleado administrativo = new Administrativo("Alicia", "P3-0123", false);
            Console.WriteLine(administrativo.ToString());

        }
    }
}

//Se debe crear una aplicación que realice el cálculo del salario mensual
//de los docentes por hora, los docentes de contrato fijo y los empleados administrativos.
//En el caso de los docentes por hora, se asignará una tarifa de 800 por cada hora trabajada.
//Asimismo, la aplicación deberá contemplar el cálculo de bonificaciones para los empleados
//administrativos y los docentes de contrato fijo, tomando en cuenta que si empleado o docente
//alcanzo la meta entonces se le paga un salario en caso contrario se le paga la mitad.



