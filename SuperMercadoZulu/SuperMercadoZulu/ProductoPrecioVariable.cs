using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercadoZulu
{
    class ProductoPrecioVariable:Producto
    {

        private string unidadDeMedida;
        private double cantidad;
        private decimal precioUnidadDemedia;


        // constructor

        public ProductoPrecioVariable(string id, string descripcion, double tarifaIVA,
            string unidadDeMedida, decimal precioUnidadDemedia, double cantidad)
            :base(id,descripcion,tarifaIVA)
        {
            this.unidadDeMedida = unidadDeMedida;
            this.precioUnidadDemedia = precioUnidadDemedia;
            this.cantidad = cantidad;
        }

        public override decimal ObtenerValorIva()
        {
            return precioUnidadDemedia * (decimal)cantidad * (decimal)TarifaIVA;
        }

        public override decimal ObtenerValorVenta()
        {
            // como se obtiene el iva de un producto precio variable
            return precioUnidadDemedia *(decimal)cantidad + ObtenerValorIva();
        }

        public override string ToString()
        {   //,12 caracteres aliniados a la derecha
            // :N0 separadores de miles con 0 decimales
            return String.Format("Producto Precio Variable: {0}\n\t" +
                                  "\n\tUnidad de medida:..................: {1}" +
                                  "\n\tCantidad:..........................: {2,12:N3}" +
                                  "\n\tPrecio por Unidad de medida........: ${3,12:N0}" +
                                  "\n\tValor Iva:.........................: ${4,12:N0}" +
                                  "\n\tValor Venta........................: ${5,12:N0}\n",
                                  base.ToString(), unidadDeMedida, cantidad, precioUnidadDemedia,
                                  ObtenerValorIva(),ObtenerValorVenta());
        }


        public string UnidadDeMedida
        {
            get { return unidadDeMedida; }
            set { unidadDeMedida = value; }
        }
        public decimal PrecioUnidadDemedia
        {
            get { return precioUnidadDemedia; }
            set { precioUnidadDemedia = value; }
        }
        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


    }
}
