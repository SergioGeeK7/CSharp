using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class EmpleadoAsalariado: Empleado // :Empleado hereda de la clase empleado
    {

        // Ctrl + R,E
        // atributo
        private decimal salario;



        // propiedad
        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }


        public EmpleadoAsalariado(string cedula, string nombres,
            string apellidos, decimal salario)
            :base(cedula,nombres,apellidos) // llama al constructor de Empleado y establese las variables
        {   // porque yo estoy heredando de ese constructor

            this.salario = salario;
        }




        public override decimal Ingresos()
        {
            //  lanza una excepcion para mientras mi programa compile
            //  si el metodo ingresar es muy extenso de implementar asi de una
            //  throw new NotImplementedException();

            return salario;
        }


        public override string ToString()
        {
            // estoy reutilizando el toString de la clase base... 
            // si estamos trabajando programacion orientada objetos y no estoy reutilizando codigo
            // no estamos haciendo nada
            return String.Format("Empleado Asalariado : {0}\n\tSalario Mencial : ${1,10:N2}",
                base.ToString(),Ingresos());
        }





    }
}
