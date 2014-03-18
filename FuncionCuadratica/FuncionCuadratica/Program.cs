using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionCuadratica
{
    class Program
    {
        static void Main(string[] args)
        {

            //double a, b, c;

            Console.Write("a? ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b? ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c? ");
            double c = Convert.ToDouble(Console.ReadLine());

            double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            Console.WriteLine("x1? ={0:N10}", x1);
            Console.WriteLine("x2? ={0:N10}", x2);
            Console.ReadKey();






        }



    }
}
