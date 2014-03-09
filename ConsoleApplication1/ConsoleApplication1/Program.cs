using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            // decimal TIPO DE DATO todo lo con salario


            
            Console.Write("Ingrese primer numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.Write("{0:N0} + {1:N0} = {2:N0}",a,b,c);
            Console.WriteLine("Presione ENTER para terminar ...");
            Console.ReadKey();




        }




    }
}
