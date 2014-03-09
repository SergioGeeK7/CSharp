using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado[] empleados = new Empleado[6];



            empleados[0] = new Empleado("1010", "Bob", "Marley", 100000.32m, new DateTime(2010, 2, 23));
            empleados[1] = new Empleado("2020", "Freddy", "Mercury", 200000.32m, new DateTime(2010, 2, 23));
            empleados[2] = new Empleado("3030", "Hector", "Lavoe", 300000.32m, new DateTime(2010, 2, 23));
            empleados[3] = new Empleado("4040", "Celia", "Cruz", 400000.32m, new DateTime(2010, 2, 23));
            empleados[4] = new Empleado("5050", "Penelope", "Cruz", 500000.32m, new DateTime(2010, 2, 23));
            empleados[5] = new Empleado("6060", "Tom", "Cruise", 600000.32m, new DateTime(2010, 2, 23));

            Console.WriteLine("Antes del aumento");
            foreach (var item in empleados)
            {
                
                Console.WriteLine(item);
            }

            Console.WriteLine("Despues del aumento");
            Console.ReadKey();
            foreach (var item in empleados)
            {
                item.Salario = item.Salario * 1.1m;
                Console.WriteLine(item);
            }



            
            string x = empleados[0].ToString() + empleados[1].ToString();



            Console.ReadKey();
        }
    }
}
