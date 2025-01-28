namespace PracticaP2
{
    public class EmpleadoFijo : Empleado
    {
        public decimal salarioMensual { get; set; }
        public bool metas { get; set; }
        public decimal bonificaciones;


        public EmpleadoFijo(string nombre, string seguro, decimal salario, bool metasAlcanzadas) : base(nombre, seguro)
        {
            salarioMensual = salario;
            metas = metasAlcanzadas;

        }



        public override decimal CalcularSalarioMensual()
        {
            if (metas)
            {
                bonificaciones = salarioMensual / 10;

                return salarioMensual + bonificaciones;

            }
            else
            {
                return salarioMensual / 2;
            }

        }

        public override string ToString()
        {
            return $"Empleado Fijo: {primerNombre}, Seguro Social: {SeguroSocial}, " +
                   $"Salario Mensual: {CalcularSalarioMensual()}";
        }



    }
}