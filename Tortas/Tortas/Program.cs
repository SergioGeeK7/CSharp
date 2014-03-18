using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("cantidad de tortas? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("tipo de pago [C]ontado,c[R]edito? ");
            string tipoPago=Console.ReadLine().ToUpper();

            // calcular costo de la torta

            decimal valor = CalcularCosto(cantidad,tipoPago);
            Console.WriteLine("El valor a pagar es: ..........${0:N2}",valor);

            Console.ReadKey();
        }

        private static decimal CalcularCosto(int cantidad, string tipoPago)
        {
                // calcular lo que me cuestan la torta sin descuentos
            decimal costo = (0.800m * 14000m+
                            0.010m * 8200m+
                            3.00m * 250m+
                            0.001m * 6200m+
                            0.250m * 7500m+
                            0.300m * 3200m+
                            0.210m * 4200m) * cantidad; // no importa el tipo de medida que lleve porque ya nos dice el precio por esa medida
           // automento por la empresa
            costo *= 1.35m;
            // descuentos

            if (cantidad > 100) costo *= 0.9m;
            if (tipoPago == "C") costo *= 0.95m; // 5%


            return costo;
            

        }
    }
}
