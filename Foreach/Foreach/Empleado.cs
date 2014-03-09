using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Empleado
    {


        #region "Propiedades"
        // propiedades MAYUSCULAS INICIALES
        public string IDEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContratacion { get; set; }

        #endregion


        public Empleado(string idEmpleado, string nombres, string apellidos, decimal salario, DateTime fechaContratacion) 
        {
            IDEmpleado = idEmpleado;
            Nombres = nombres;
            Apellidos = apellidos;
            Salario= salario;
            FechaContratacion= fechaContratacion;
        }

        public override string ToString()
        {
            // 10 caracteres 2 decimales
            return String.Format("ID {0}, {1} {2} \n   Salario : ${3,10:N2}\n   Fecha Contrato{4:d} ",
                IDEmpleado,Nombres,Apellidos,Salario,FechaContratacion);
        }




    }
}
