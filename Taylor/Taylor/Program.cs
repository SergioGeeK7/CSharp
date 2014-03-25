using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taylor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x? ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("n? ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El valor de taylor para x = {0} , n = {1} es {2}",x,n,Taylor(x,n));
            Console.WriteLine("El valor de taylor modificado = {0} , n = {1} es {2}", x, n, TaylorMod(x, n));
            Console.ReadKey();

        }

        private static object TaylorMod(double x, double n)
        {
            //    sig *= -1;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                double t = Math.Pow(x, i) / Factorial(i);
                s += i%2==0 ? t:t*-1;
            }
            return s;

        }

        private static double Taylor(double x, double n)
        {
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                double t = Math.Pow(x, i)/Factorial(i);
                s += t;
            }
            return s;

        }

        private static double Factorial(int n)
        {

            double fac=1;

            for (int i = 2; i <= n; i ++)
            {
                fac *= i;
            }

            return fac;
        }
    }
}
