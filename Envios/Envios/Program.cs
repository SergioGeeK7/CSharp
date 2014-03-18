using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pesoMercandia, valorMercancia, valorTarifa, valorPromocion, valorDescuento;
            string esLunes, tipoPago;
            // las alterare en el sub-programa y quiero que conserven su valor
            PedirDatos(out pesoMercandia,out valorMercancia,out esLunes,out tipoPago);
            valorTarifa = CalcularTarifa(pesoMercandia);
            valorDescuento = CalcularDescuento(valorMercancia, valorTarifa);
            valorPromocion = CalcularPromocion(esLunes,tipoPago,valorMercancia,valorTarifa);
            MostrarResultados(valorTarifa,valorDescuento,valorPromocion);
        }

        static void PedirDatos(out decimal pesoMercandia,out decimal valorMercancia,
                               out string esLunes,out string tipoPago)
        {
            Console.Write("Peso Mercancia?_____________________");
            pesoMercandia = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Valor Mercancia?____________________");
            valorMercancia = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Es Lunes [S]i [N]o ?________________");
            esLunes = Console.ReadLine();
            Console.Write("Tipo de pago [E]efectivo, [T]arjeta? ");
            tipoPago= Console.ReadLine();
        }

        static decimal CalcularTarifa(decimal pesoMercancia)
        {
            if (pesoMercancia<100)return 20000;
            if (pesoMercancia <= 150) return 25000;
            if (pesoMercancia <= 200) return 30000;
            return 35000 + (pesoMercancia - 200) / 10 * 2000;// por cada 1  kilos adicionales 2000 de recarga

        }

        static decimal CalcularDescuento(decimal valorMercancia, decimal valorTarifa)
        {
            if (valorMercancia < 300000) return 0;
            if (valorMercancia <= 600000) return valorTarifa * 0.1m; //10% de la tarifa
            if (valorMercancia <= 1000000) return valorTarifa * 0.2m;
            return valorTarifa*0.3m;
        }

        static decimal CalcularPromocion(string esLunes, string tipoPago,
                                        decimal valorMercancia, decimal valorTarifa)
        {
            if (esLunes.ToUpper() == "S" && tipoPago == "T") return valorTarifa * 0.5m;
            if (tipoPago.ToUpper() == "E" && valorMercancia > 1000000) return valorTarifa * 0.4m;
            return 0;
        }

        static void MostrarResultados(decimal valorTarifa, decimal valorDescuento,
                                      decimal valorPromocion)
        {
            decimal totalApagar;
            Console.WriteLine("Tarifa       : ${0,12:N0}",valorTarifa);
            if (valorDescuento > valorPromocion)
            {
                Console.WriteLine("Valor Descuento    : ${0,12:N0}", valorDescuento);
                totalApagar=valorTarifa-valorDescuento;
            }
            else
            {
                Console.WriteLine("Promocion      :${0,12:N0}", valorPromocion);
                totalApagar = valorTarifa - valorPromocion;
            }

            Console.WriteLine("Total a pagar: ${0,12:N0}", totalApagar);
            Console.ReadKey();

            
        }


    }
}
