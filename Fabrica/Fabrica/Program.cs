using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipoProducto, tipoAdicion;
            int cantidad;
            decimal costo;
            PedirDatos(out tipoProducto,out cantidad,out tipoAdicion);
            costo = CalcularCosto(tipoProducto, cantidad, tipoAdicion);
            MostrarResultdos(costo);
        }

        static void PedirDatos(out string tipoProducto,out int cantidad,out string tipoAdicion)
        {
            Console.Write("Tipo Producto: [E]scritorio [S]illa, [P]uerta,[V]entana...?");
            Console.Write("Cantidad..................................................?");
            Console.Write("Tipo Adicion: [L]Laca [C]romado, [E]nvejecido,c[R]aquelado?");
        }






    }
}
