using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajes
{
    class Program
    {
        static void Main(string[] args)
        {
            int ruta, numeroViajes, numeroPasajeros, paquetes10, paquetes1020, paquetes20;
            decimal ingresosPasajeros, ingresosPaquetes, ingresosTotales, valorAyudante, valorSeguro, valorGasolina;


            PedirDatos(out ruta,out numeroViajes,out numeroPasajeros,out paquetes10,
                       out paquetes1020,out paquetes20);
            ingresosPasajeros = CalcularIngresosPasajeros(ruta, numeroViajes, numeroPasajeros);
            ingresosPaquetes = calcularIngresosPaquetes(ruta, paquetes10, paquetes1020, paquetes20);
            ingresosTotales = ingresosPasajeros + ingresosPaquetes;
            valorAyudante = CalcularValorAyudante(ingresosTotales);
            valorSeguro = CalcularValorSeguro(ingresosTotales);
            valorGasolina = CalcularValorGasolina(ruta, numeroViajes, numeroPasajeros, paquetes10, paquetes1020, paquetes20);
            MostrarResultados(ingresosPasajeros, ingresosPaquetes, valorAyudante, valorSeguro, valorGasolina);

        }
        
         static void PedirDatos(out int ruta, out int numeroViajes, out int numeroPasajeros,
                                out int paquetes10, out int paquetes1020, out int paquetes20)
        {
            Console.WriteLine("******* DATOS DE ENTRADA ******************");
            Console.Write("Ruta [1][2][3][4]...........................................");
            ruta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero de viajes ...........................................");
            numeroViajes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero de pasajeros total ..................................");
            numeroPasajeros = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero de encomiendas de menos de 10 kg ....................");
            paquetes10= Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero de encomiendas entre 10 kg y menos de 20kg ..........");
            paquetes1020= Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero de encomiendas de mas de 20kg .......................");
            paquetes20= Convert.ToInt32(Console.ReadLine());

        }

         static decimal CalcularIngresosPasajeros(int ruta, int numeroViajes, int numeroPasajeros)
         {
             decimal valor;
             if (ruta == 1)
             {
                 valor = numeroViajes * 500000;
                 if (numeroPasajeros < 50) return valor;
                 if (numeroPasajeros < 100) return valor*1.05m;
                 if (numeroPasajeros < 150) return valor*1.06m;
                 if (numeroPasajeros < 200) return valor*1.07m;
                 return valor * 1.07m + (numeroPasajeros - 200) * 50;

             }else if (ruta == 2) 
             {
                 valor = numeroViajes * 600000;
                 if (numeroPasajeros < 50) return valor;
                 if (numeroPasajeros < 100) return valor * 1.07m;
                 if (numeroPasajeros < 150) return valor * 1.08m;
                 if (numeroPasajeros < 200) return valor * 1.09m;
                 return valor * 1.09m + (numeroPasajeros - 200) * 60;
             }else if (ruta == 3) 
             {
                 valor = numeroViajes * 800000;
                 if (numeroPasajeros < 50) return valor;
                 if (numeroPasajeros < 100) return valor * 1.10m;
                 if (numeroPasajeros < 150) return valor * 1.13m;
                 if (numeroPasajeros < 200) return valor * 1.15m;
                 return valor * 1.15m + (numeroPasajeros - 200) * 100;
             }else
             {
                 valor = numeroViajes * 1000000;
                 if (numeroPasajeros < 50) return valor;
                 if (numeroPasajeros < 100) return valor * 1.125m; //12.5%
                 if (numeroPasajeros < 150) return valor * 1.15m;  //15%
                 if (numeroPasajeros < 200) return valor * 1.17m;  // 17%
                 return valor * 1.17m + (numeroPasajeros - 200) * 150;// 150 adicionales por cada uno de los pasajeros
             }  
         }



         private static decimal calcularIngresosPaquetes(int ruta, int paquetes10, int paquetes1020, int paquetes20)
         {
             decimal valor;
             if (ruta == 1 || ruta == 2)
             {
                 if (paquetes10 < 50) valor = paquetes10 * 100; // pagamos 100 pesos por cada paquete
                 else if (paquetes10 < 100) valor = paquetes10 * 120;
                 else if (paquetes10 < 130) valor = paquetes10 * 150;
                 else valor = paquetes10 * 160;
                 if (paquetes1020 + paquetes20 < 50) valor = valor += (paquetes1020 + paquetes20)  *120;
                 else if (paquetes1020 + paquetes20 < 100) valor += (paquetes1020 + paquetes20) *140;
                 else if (paquetes1020 + paquetes20 < 50) valor += (paquetes1020 + paquetes20)* 160;
                 else valor += (paquetes1020 + paquetes20)*180;

             }
             else 
             {
                 if (paquetes10 < 50) valor = paquetes10 * 130; // pagamos 100 pesos por cada paquete
                 else if (paquetes10 < 100) valor = paquetes10 * 160;
                 else if (paquetes10 < 130) valor = paquetes10 * 175;
                 else valor = paquetes10 * 200;
                 if (paquetes1020 < 50) valor *= 140;
                 else if (paquetes1020< 100) valor +=paquetes1020* 180;
                 else if (paquetes1020 < 50) valor += paquetes1020*200;
                 else valor +=paquetes1020*250;
                 if (paquetes20 < 50) valor += paquetes20 * 170; // pagamos 100 pesos por cada paquete
                 else if (paquetes20 < 100) valor += paquetes20 * 210;
                 else if (paquetes20 < 130) valor += paquetes20 * 250;
                 else valor += paquetes20 * 300;
             }
             return valor;
         }



         private static decimal CalcularValorAyudante(decimal ingresosTotales)
         {
             if (ingresosTotales < 1000000) return ingresosTotales * 0.05m;
             if (ingresosTotales < 2000000) return ingresosTotales * 0.08m;
             if (ingresosTotales < 4000000) return ingresosTotales * 0.10m;
             return ingresosTotales * 0.13m;

         }

         private static decimal CalcularValorSeguro(decimal ingresosTotales)
         {

             if (ingresosTotales < 1000000) return ingresosTotales * 0.03m;
             if (ingresosTotales < 2000000) return ingresosTotales * 0.04m;
             if (ingresosTotales < 4000000) return ingresosTotales * 0.06m;
             return ingresosTotales * 0.09m;
         }

         private static decimal CalcularValorGasolina(int ruta, int numeroViajes, int numeroPasajeros,
                                                      int paquetes10, int paquetes1020, int paquetes20)
         {

             decimal valorGalon = 8860m;
             decimal rendimientoPorKilometro = 39m; //39 kl = 1 galon
             decimal kilometros;
             decimal pesoPromedioPorPersona=60;
             // 150 kilometros dura el trayecto 1
             if (ruta == 1) kilometros = 150 * numeroViajes;
             else if (ruta == 2) kilometros = 167 * numeroViajes;
             else if (ruta == 3) kilometros = 184 * numeroViajes;
             else kilometros =  203* numeroViajes;
             // numero de kilometros... pasar kilometros a galones
             // cuanto equivale un galon 


             decimal valor = kilometros / rendimientoPorKilometro* valorGalon; // numero de galones que me gaste || 1 galon 2 galones 3 galones
             // valor *= valorGalon; // 20 galones * el dinero que vale cada galon
             decimal pesoTotalBus = pesoPromedioPorPersona * numeroPasajeros + paquetes10 *10 + 
                                    paquetes1020 * 15 + paquetes20 *20;

             if (pesoTotalBus <= 5000) return valor * 0.75m; // le bajo el 25% del valor total de la gasolina al conductor(subsidio)
             else if (pesoTotalBus <= 10000) return valor * 1.1m * 0.75m;//por el peso del bus sube en 10% ,la empresa responde por el 25% 
             else return valor * 1.25m * 0.75m;// peso del bus mayor a 10000
         }



         private static void MostrarResultados(decimal ingresosPasajeros, decimal ingresosPaquetes,
                                               decimal valorAyudante, decimal valorSeguro, decimal valorGasolina)
         {
             Console.WriteLine("****** CALCULOS ********");
             Console.WriteLine("Ingresos por Pasajeros..........................: ${0,12:N2}",ingresosPasajeros);
             Console.WriteLine("Ingresos por Encomientas........................: ${0,12:N2}",ingresosPaquetes);
             Console.WriteLine("                                                : ____________");
             decimal totalIngresos = ingresosPasajeros + ingresosPaquetes;
             Console.WriteLine("Total Ingresos..................................: ${0,12:N2}\n",totalIngresos);
             Console.WriteLine("Pago Ayudante...................................: ${0,12:N2}", valorAyudante);
             Console.WriteLine("Pago Seguro.....................................: ${0,12:N2}", valorSeguro);
             Console.WriteLine("Pago Combustible..................................: ${0,12:N2}", valorGasolina);
             Console.WriteLine("                                                  : ____________");
             decimal totalEgresos = valorAyudante + valorSeguro + valorGasolina;
             Console.WriteLine("TOTAL DEDUCCIONES.............................: ${0,12:N2}\n", totalEgresos);
             Console.WriteLine("                                              : ============");
             decimal totalPagar = totalIngresos - totalEgresos;
             Console.WriteLine("TOTAL A LIQUITAR.............................: ${0,12:N2}\n", totalPagar);
             Console.ReadKey();

         }





    }
}
