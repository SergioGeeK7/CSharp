using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaz
{
    abstract class Empleado : PorPagar // NO TENGO QUE IMPLEMENTAR LOS METODOS POR PAGAR PORQUE ESTA CLASE ES ABSTRACTA
    {


        private string cedula;
        private string apellidos;
        private string nombres;


        public Empleado(string cedula, string apellidos, string nombres)
        {
            this.cedula = cedula;
            this.apellidos = apellidos;
            this.nombres = nombres;
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }


        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }


        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        // NO TENGO QUE IMPLEMENTAR LA INTERFAZ MONTOPAGO
        public abstract decimal ObtenerMontoPago();


        public override string ToString()
        {
            return String.Format("{0} {1}\n\tCedula......: {2}",nombres,apellidos,cedula);
        }



    }
}
