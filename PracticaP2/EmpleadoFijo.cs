namespace PracticaP2
{
    public class EmpleadoFijo : Empleado
    {
        public decimal salarioMesual { get; set; }
        public decimal bonificaciones { get; set; }

        public bool metas { get; set; }



        public EmpleadoFijo(string nombre, string seguro, decimal salario, bool metasAlcanzadas) : base(nombre, seguro)
        {
            salarioMesual = salario;
            metas = metasAlcanzadas;

        }



        public override decimal CalcularSalarioMensual()
        {
            if (metas)
            {
                bonificaciones = salarioMesual / 10;

                return salarioMesual + bonificaciones;

            }
            else
            {

                return salarioMesual / 2;

            }

        }

    }
}