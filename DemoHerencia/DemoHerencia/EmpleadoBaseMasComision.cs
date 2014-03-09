using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class EmpleadoBaseMasComision:EmpleadoPorComision
    {

        private decimal salarioBase;

        public decimal SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }



        public EmpleadoBaseMasComision(string cedula, string nombres,
            string apellidos,float tarifaComision,decimal ventasBrutas,decimal salarioBase)
            : base(cedula, nombres, apellidos,tarifaComision,ventasBrutas) 
        {
            this.salarioBase = salarioBase;
        }


        // NO TENGO QUE OVERRIDE EL METODO INGRESOS
        // PORQUE NO ESTOY HEREDANDO DIRECTAMENTE DE LA CLASE ABSTRACTA

        public override decimal Ingresos()
        {

            return base.Ingresos()+salarioBase;
        }

        public override string ToString()
        {
            // estoy reutilizando el toString de la clase base... 
            // si estamos trabajando programacion orientada objetos y no estoy reutilizando codigo
            // no estamos haciendo nada
            return String.Format("Empleado Base Mas Comision: {0} {1}\n\tCedula............: {2}\n\tSalario Mencial : ${3,10:N2}",
                Nombres, Apellidos,Cedula,Ingresos());
        }


    }
}
