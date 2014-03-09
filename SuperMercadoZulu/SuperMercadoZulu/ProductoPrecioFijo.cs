using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercadoZulu
{
    class ProductoPrecioFijo:Producto // hereda de Producto
    {


        private decimal precio; // sin IVA



        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public ProductoPrecioFijo (string id, string descripcion, double tarifaIVA,decimal precio)
            :base(id,descripcion,tarifaIVA)
        {
            this.precio = precio;
        }

        public override decimal ObtenerValorIva()
        {
            // como es el obtenervaloriva de un precioFijo
            return precio * (decimal)TarifaIVA;
        }

        public override decimal ObtenerValorVenta()
        {
            return precio + ObtenerValorIva();
        }

        public override string ToString()
        {   //,12 caracteres aliniados a la derecha
            // :N0 separadores de miles con 0 decimales
            return String.Format("Producto Precio Fijo: {0}\n\tPrecio.............................: ${1,12:N0}"+
                                  "\n\tValor Iva:.........................: ${2,12:N0}"+
                                  "\n\tValor Venta........................: ${3,12:N0}\n",
                                   base.ToString(),precio,ObtenerValorIva(),ObtenerValorVenta());
        }





    }
}
