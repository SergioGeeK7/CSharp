using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}! = {1}",n,Factorial(n));
            Console.ReadKey();
        }

        private static decimal Factorial(int n)
        {
            decimal fac = 1; // multiplicador inicial

            for (int i = 2; i <= n; i++)
            {
                fac *= i;
            }

            return fac;

        }




    }
}
