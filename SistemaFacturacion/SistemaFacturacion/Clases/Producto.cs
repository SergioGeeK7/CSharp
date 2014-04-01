using SistemaFacturacion.Clases.DSFacturacionTableAdapters;
//using SistemaFacturacion.FacturacionDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaFacturacion.Clases
{
    class Producto
    {

        public int IdProducto { get; set; }
        public string Descipcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Notas { get; set; }
        public int Idiva { get; set; }
        public int IdDepartamento { get; set; }

        // para poder utilizar las consultas del dataset
        private static ProductoTableAdapter adapter = new ProductoTableAdapter();

        //private static DetalleFacturaTmpTableAdapter ll = new DetalleFacturaTmpTableAdapter();
        //private static ClienteTableAdapter lol = new ClienteTableAdapter();

        
        public static Producto GetProducto(int id)
        {
            //adapter.GetProducto(IDProducto) Query devuvle un dataset
            // convertir Dataset en objeto producto

            //DSFacturacion.ProductoDataTable mitabla = adapter.GetProducto(id);

            DSFacturacion.ProductoDataTable mitabla =adapter.GetProducto2(id);


            if (mitabla.Rows.Count == 0) return null;
            // cada fila de cada clase me quedo como una tabla
            // una tabla esta compuesta por filas

            DSFacturacion.ProductoRow miRegistro = (DSFacturacion.ProductoRow)mitabla.Rows[0];

            // aunque mi producto row es una herencia de los rows 
            // rows es una herencia de los rows no lo puede convertir implicitamente
            // toca hacer casting

            Producto miProducto = new Producto();

            miProducto.IdProducto = miRegistro.IDProducto;
            miProducto.Descipcion = miRegistro.Descripcion;
            miProducto.Precio = miRegistro.Precio;
            miProducto.Stock = miRegistro.Stock;
            miProducto.Idiva = miRegistro.IDIVA;
            miProducto.IdDepartamento = miRegistro.IDDepartamento;
            miProducto.Notas = miRegistro.Notas ;

            

            return miProducto;

        }

    }
} 
