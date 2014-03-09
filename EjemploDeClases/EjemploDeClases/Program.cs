using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();

            Libro libro2 = new Libro("LA BIBLIA DEL C#",23.43M);
            Libro libro3 = new Libro("APRENDIENDO JAVA 2EE", 45.12M);


            libro1.Nombre = "CRITICA A LA RAZON PURA";
            libro1.Precio = 12.03m;

            Libro[] libros = new Libro[3];

            libros[0] = libro1;
            libros[1] = libro2;
            libros[2] = libro3;


            foreach (var item in libros)
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();





        }
    }
}
