using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercadoZulu
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoPrecioFijo pro1 = new
                               ProductoPrecioFijo("1", "Aguardiente Antioqueño", 0.16, 23000.0m);
            ProductoPrecioFijo pro2 = new
                               ProductoPrecioFijo("2", "Ron Medellín", 0.16, 25000.0m);

            ProductoPrecioVariable pro3 = new
                                 ProductoPrecioVariable("3", "Cabano", 0.16, "Kilo", 7800m, .98);
            ProductoPrecioVariable pro4 = new
                                 ProductoPrecioVariable("4", "Queso Holandes", 0.16, "Kilo", 9500.0m, 0.567);

            Producto[] productosAncheta = { pro1, pro2, pro3, pro4 };
            
            ProductoCompuesto pro5 = new
                              ProductoCompuesto("5", "Ancheta Don Ebrio", 0.16, productosAncheta);

            Producto[] productos = { pro1, pro2, pro3, pro4, pro5 };


            foreach (Producto item in productos)
            {
                Console.WriteLine(item);
            }

        

            Console.ReadKey();

        }
    }
}
