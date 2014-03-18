using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaz
{
    class Factura : PorPagar // implementa la interface
    {
        private string codigo;
        private string descripcion;
        private double cantidad;
        private decimal precio;



        public Factura(string codigo, string descripcion, double cantidad, decimal precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
        }


        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

       

        public override string ToString()
        {
            return String.Format("Factura codigo: {0}\n\tDescripcion........: {1}\n\t"+
                                "Precio.............${2,12:N0}\n\t" +
                                "Cantidad...........${3,10:N0}\n\t" +
                                "Monto Pago.........${4,10:N0}\n\t",
                                codigo,descripcion,precio,cantidad,ObtenerMontoPago());
        }


        public decimal ObtenerMontoPago()
        {
            return (decimal)cantidad * precio;
        }
    }
}
