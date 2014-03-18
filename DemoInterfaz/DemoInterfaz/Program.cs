using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura("001", "LLantas Good Year", 4, 132400m);

            Factura f2 = new Factura("002", "Jamon Serrano", 3.489, 18500m);
            EmpleadoAsalariado ep1 = new EmpleadoAsalariado("99565456","Nicolas","Maduro",2300000m);
            EmpleadoAsalariado ep2 = new EmpleadoAsalariado("94513245", "Celia", "Cruz", 7900000m);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(ep1);
            Console.WriteLine(ep2);
            Console.ReadKey();
        }
    }
}
