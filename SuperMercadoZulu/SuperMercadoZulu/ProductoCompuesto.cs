using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercadoZulu
{
    class ProductoCompuesto:Producto
    {

        // atributo privado
        private Producto[] productos;

        public ProductoCompuesto(string id, string descripcion, double tarifaIVA, Producto[] productos)
            :base(id,descripcion,tarifaIVA)
        {
            this.productos = productos;
        }

        public Producto[] Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        public override decimal ObtenerValorIva()
        {
            decimal Iva = 0;
            foreach (var producto in productos)
            {
                Iva += producto.ObtenerValorIva();
            }
            return Iva;
        }

        public override decimal ObtenerValorVenta()
        {
            decimal ValorVenta = 0;
            foreach (var producto in productos)
            {
                ValorVenta += producto.ObtenerValorVenta();
            }
            return ValorVenta;
        }

        public override string ToString()
        {
            string componentes="";

            foreach (var producto in productos)
            {
                componentes += producto.Descripcion+"\n\t\t\t\t\t\t";
            }
            componentes = componentes.Substring(0,componentes.Length - 6);

            return String.Format("Producto Compuesto: {0}\n\tComponentes..........................: {1}" +
                                "\n\tValor Iva:.........................: ${2,12:N0}" +
                                "\n\tValor Venta........................: ${3,12:N0}\n",
                                 base.ToString(), componentes, ObtenerValorIva(), ObtenerValorVenta());

        }














    }
}
