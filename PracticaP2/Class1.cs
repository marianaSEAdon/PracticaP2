using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaP2
{
    public abstract class Empleado
    {
        private string primerNombre;
        private string seguroSocial;

        public Empleado(string nombre, string seguro)
        {
            primerNombre = nombre;
            seguroSocial = seguro;
        }

        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }
        }
        public string SeguroSocial
        {
            get
            {
                return seguroSocial;
            } 
              
        } 


        public override string ToString()
        {
            return string.Format("{0} {1}\nseguroSocial: {2}",
            PrimerNombre, SeguroSocial);
        }


        public abstract decimal CalcularSalarioMensual();



    }
}
