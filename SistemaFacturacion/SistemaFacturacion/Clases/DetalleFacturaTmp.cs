//using SistemaFacturacion.FacturacionDataSetTableAdapters;
using SistemaFacturacion.Clases.DSFacturacionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Clases
{
    class DetalleFacturaTmp
    {
        private static DetalleFacturaTmpTableAdapter adapter =
                        new DetalleFacturaTmpTableAdapter();


        private static FacturaTableAdapter adapter2 = new FacturaTableAdapter(); 


        public static void NuevoDetalleFacturaTmp(int IDProducto,
            string Descripcion, decimal Precio, int Cantidad)
        {
            adapter.NuevoDetalleFacturaTmp(IDProducto, Descripcion, Precio, Cantidad);
        }

        public static int SumaCantidad()
        {
            return adapter.SumaCantidad() != null ? (int)adapter.SumaCantidad():0;
        }

        public static decimal SumaValor()
        {
            return adapter.SumaValor() != null ? (decimal) adapter.SumaValor() : 0;

        }

        public static bool EliminarProducto(DataGridViewSelectedRowCollection selected)
        {
            foreach (DataGridViewRow row in selected)
            {
                int idLinea = (int)row.Cells[0].Value;
                adapter.EliminarProducto(idLinea);


            }
            return true;
        }


        public static void EliminarTodo()
        {
            adapter.EliminarTodo();
        }

        public static void NuevaFactura(string IDCliente,DateTime Fecha)
        {
            adapter2.NuevaFactura(IDCliente,Fecha);
        }




    }
}
