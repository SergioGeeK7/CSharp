//using SistemaFacturacion.FacturacionDataSetTableAdapters;
using SistemaFacturacion.Clases.DSFacturacionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Clases
{
    class DetalleFacturaTmp
    {
        private static DetalleFacturaTmpTableAdapter adapter = 
                        new DetalleFacturaTmpTableAdapter();


        public static void NuevoDetalleFacturaTmp(int IDProducto,
            string Descripcion,decimal Precio,int Cantidad)
        {
            adapter.NuevoDetalleFacturaTmp(IDProducto, Descripcion, Precio, Cantidad);
        }

        public static int SumaCantidad()
        {
            return (int)adapter.SumaCantidad();
        }

        public static decimal SumaValor()
        {
            return (decimal) adapter.SumaValor();
        }



    }
}
