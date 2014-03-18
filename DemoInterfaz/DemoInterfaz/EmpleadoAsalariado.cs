using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaz
{
    class EmpleadoAsalariado:Empleado
    {

        private decimal salario;


        public EmpleadoAsalariado(string cedula, string apellidos, string nombres,decimal salario)
            :base(cedula,nombres,apellidos) // CONSTRUCTOR DEL EMPLEADO ASALARIADO
        {
            this.salario = salario;
        }

        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }



        public override decimal ObtenerMontoPago()
        {
            return salario;
        }


        public override string ToString()
        {
            return String.Format("Empleado Asalariado: {0}\n\tMonto Pago..: ${1,10:N2}\n",
                                  base.ToString(),ObtenerMontoPago());
        }

        //44.14
    }
}
