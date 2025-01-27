using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    public abstract class Empleado
    {
        public string primerNombre { get; set; }
        private string seguroSocial;

        public Empleado(string nombre, string seguro)
        {
            primerNombre = nombre;
            seguroSocial = seguro;
        }

        public string SeguroSocial
        {
            get
            {
                return seguroSocial;
            } 
              
        } 

        public abstract decimal CalcularSalarioMensual();

    }
}
