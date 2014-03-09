using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class EmpleadoPorComision:Empleado
    {
        private float tarifaComision;
        private decimal ventasBrutas;


        public float TarifaComision
        {
            get { return tarifaComision; }
            set { tarifaComision = value; }
        }
        

        public decimal VentasBrutas
        {
            get { return ventasBrutas; }
            set { ventasBrutas = value; }
        }


        
        public EmpleadoPorComision(string cedula, string nombres,
            string apellidos,float tarifaComision,decimal ventasBrutas)
            : base(cedula, nombres, apellidos) 
        {
            this.tarifaComision = tarifaComision;
            this.ventasBrutas = ventasBrutas;
            
        }

        public override decimal Ingresos()
        {
            return  ventasBrutas * (decimal)tarifaComision;
        }


        public override string ToString()
        {
            // estoy reutilizando el toString de la clase base... 
            // si estamos trabajando programacion orientada objetos y no estoy reutilizando codigo
            // no estamos haciendo nada
            return String.Format("Empleado Por Comision : {0}\n\tSalario Mencial : ${1,10:N2}",
                base.ToString(), Ingresos());
        }

        public void tteesstt()
        { 
            
        
        }



    }
}
