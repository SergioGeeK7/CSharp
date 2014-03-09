using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            EmpleadoAsalariado emp1 = new EmpleadoAsalariado("1010", "Ruben", "Blades", 1200M);
            EmpleadoPorHoras emp2 = new EmpleadoPorHoras("2020", "Bob", "Marley", 125f,15.32m);
            EmpleadoPorComision emp3 = new EmpleadoPorComision("3030", "shakira", "Mevarak",0.04f, 92564.56m);
            EmpleadoBaseMasComision emp4 = new EmpleadoBaseMasComision("4040", "John", "Secada",0.02f,12000m,480.56m);


            Empleado [] empleados = new Empleado[4];


            empleados[0] = emp1;
            empleados[1] = emp2;
            empleados[2] = emp3;
            empleados[3] = emp4;

          // es un array de empleados pero solo toma los metodos  de la superclase Empleado. sin embargo 
          // existe un metodo abstracto que es el que nos modifica cada clase y hace funcional este proyecto





            foreach (var item in empleados)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();


        }
    }
}
