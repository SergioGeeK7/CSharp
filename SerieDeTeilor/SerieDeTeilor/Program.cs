using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDeTeilor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Cuantos terminos desea ?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de x ?");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("F(x) = {0}", Taylor(x, n));
            Console.ReadKey();

        }

        private static double Taylor(double x, int n)
        {
            double t;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                t = Math.Pow(x, i)/Factorial(i); // i == n
                Console.WriteLine("{0}! = {1}",i,Factorial(i));
                s += t;
            }

            return s;
        }

        private static double Factorial(int n)
        {
            double factorial = 1; // multiplicador inical 1*2*3*4*5 * n
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }

}
