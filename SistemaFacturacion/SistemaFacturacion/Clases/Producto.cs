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




    }
}
