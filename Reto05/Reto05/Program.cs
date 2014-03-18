using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto05
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Precio: ...................................?");
            decimal precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Precio: ...................................?");
            decimal cantidad = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Pertenece a regimen comun :[S]s [N]o:..... ?");
            string regimen = Console.ReadLine().ToUpper();
            Console.WriteLine("Precio: ...................................?");

            decimal valorBruto = precio * cantidad;
            
            // descuentos
            decimal valorDescuento = CalcularDescuento(valorBruto);
            // promociones
            decimal valorPromocion = CalcularPromocion(cantidad,valorBruto);


            
            decimal valorReteICA = 0;
            decimal valorNeto = 0;

            

            Console.WriteLine("Valor bruto.....................................: ${0,14:N2}",valorBruto);
            if (valorPromocion > valorDescuento)
            {
                Console.WriteLine("Valor Promocion.....................................: ${0,14:N2}", valorPromocion);
                valorNeto = valorBruto - valorPromocion;
                Console.WriteLine("Valor Con Promocion.....................................: ${0,14:N2}", valorNeto);
            }
            else {
                Console.WriteLine("Valor descuento.....................................: ${0,14:N2}", valorDescuento);
                valorNeto = valorBruto - valorDescuento;
                Console.WriteLine("Valor Con Promocion.....................................: ${0,14:N2}", valorNeto);
            
            }

            decimal valorIva = valorNeto * 0.16m; // calculando el valor del iva
            Console.WriteLine("Valor Iva.....................................: ${0,14:N2}",valorIva);
            if (regimen == "S") valorReteICA = valorNeto * 0.03m;
            Console.WriteLine("Valor Rete ICA................................: ${0,14:N2}",valorReteICA);
            decimal total = valorNeto + valorIva + valorReteICA;
            Console.WriteLine("Total a pagar................................: ${0,14:N2}", total);




            // tenemos que convertir a meses
            
            Console.ReadKey();


        }

        private static decimal CalcularPromocion(decimal cantidad, decimal valorBruto)
        {
            if (cantidad < 50) return 0;
            if (cantidad <= 200) return valorBruto * 0.05m; 
            else return valorBruto * 0.15m; 
        }

        private static decimal CalcularDescuento(decimal valorBruto)
        {
            if (valorBruto < 100000) return 0;
            if (valorBruto <= 500000) return valorBruto*0.03m; // menor 3%
            if (valorBruto <= 1000000) return valorBruto * 0.05m; 
            else return valorBruto * 0.08m; 
        }
    }
}
