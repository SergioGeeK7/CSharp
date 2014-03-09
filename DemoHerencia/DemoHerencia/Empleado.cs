using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    abstract class Empleado 
     // ES ABSTRACTA PORQUE NO EXISTE UN EMPLEADO... EXISTE EMPLEADO ASALARIADO EMPLEADO POR NOMINA EMPLEADO FIJO
    // MAS NO UN SIMPLE EMPLEADO.. ADEMAS CADA UNO TIENE UN METODO DIFERENTE QUE ES EL DEL SALARIO. EL QUE LOS DEFINE
    {

        // Atributos
        private string nombres;
        private string cedula;
        private string apellidos;



        // Propiedades
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

        // Constructor
        public Empleado(String cedula, String nombres, String apellidos) 
        {

            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;

        }


        // metodos

        public override string ToString()
        {
            return String.Format("{0} {1}\n\tCedula.............: {2}\n",nombres,apellidos,cedula);
        }

        // METODO ABSTRACTO ... CUALQUIER CLASE QUE HERE DE EMPLEADO TIENE QUE IMPLEMENTAR ESTE METODO
        public abstract decimal Ingresos(); 
       
       
       




    }
}
