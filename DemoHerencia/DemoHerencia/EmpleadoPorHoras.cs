using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class EmpleadoPorHoras :Empleado // hereda de empleado
    {

        private float numeroHoras;
        private decimal valorHora;



        public float NumeroHoras
        {
            get { return numeroHoras; }
            set { numeroHoras = value; }
        }
       

        public decimal ValorHora
        {
            get { return valorHora; }
            set { valorHora = value; }
        }



        public EmpleadoPorHoras(string cedula, string nombres,
            string apellidos, float numeroHoras,decimal valorHora)
            : base(cedula, nombres, apellidos) 
        {
            this.numeroHoras = numeroHoras;
            this.valorHora = valorHora;
            
        }

        public override decimal Ingresos()
        {
            // casting .... o sino un Convert.to
            // no puede multiplicar  float * decimal
            return (decimal)numeroHoras * valorHora;

        }


        public override string ToString()
        {
            // estoy reutilizando el toString de la clase base... 
            // si estamos trabajando programacion orientada objetos y no estoy reutilizando codigo
            // no estamos haciendo nada
            return String.Format("Empleado Por Horas : {0}\n\tSalario Mencial : ${1,10:N2}",
                base.ToString(), Ingresos());
        }




    }
}
