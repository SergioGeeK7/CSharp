using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("m1? ");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("m2? ");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("r? ");
            double r = Convert.ToDouble(Console.ReadLine());
            double G = 0.0000000000667;
            double F = G*(m1*m2/(r*r));
            Console.Write("rf ={0} ",F);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
