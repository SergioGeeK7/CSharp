using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {

            PruebasFuncionales pru1 = new PruebasFuncionales("001", "CRUD Maestros", 150);
            PruebasFuncionales pru2 = new PruebasFuncionales("002", "Movimientos", 300);
            PruebasFuncionales pru3 = new PruebasFuncionales("003", "Módulo de reportes", 90);
            PruebasFuncionales pru4 = new PruebasFuncionales("004", "Seguridad del sistema", 65);
            PruebasPerformance pru5 = new PruebasPerformance("005", "Pruebas de carga", 30);
            PruebasPerformance pru6 = new PruebasPerformance("006", "Pruebas de estrés", 40);
            PruebasPerformance pru7 = new PruebasPerformance("007", "Pruebas de escalabilidad", 15);

            Servicio[] pruebas = { pru1, pru2, pru3, pru4, pru5, pru6, pru7 };

            PruebasPaquete pru8 = new PruebasPaquete("100", "Paquete de pruebas con descuento", 0, pruebas);

            Console.WriteLine("Total cotizando pruebas individuales: ");
            decimal total = 0;
            foreach (var prueba in pruebas)
            {
                Console.WriteLine(prueba);
                total += prueba.ValorServicio();
            }
            Console.WriteLine("TOTAL....................: ${0,14:N2}", total);

            Console.WriteLine("\n\nTotal cotizando el paquete completo: ");
            Console.WriteLine(pru8);

            Console.ReadKey();


        }
    }
}
