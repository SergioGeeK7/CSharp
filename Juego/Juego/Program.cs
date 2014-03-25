using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int n = rd.Next(1000),conIntentos=0,numJug1,numJug2;
            do
            {
                Console.Write("Jugador 1 :Ingrese numero");
                numJug1 = Convert.ToInt32(Console.ReadLine());
                conIntentos++;
                if(numJug1>n)Console.WriteLine("El numero a adivinar es menor....");
                else if (numJug1 < n) Console.WriteLine("El numero a adivinar es mayor....");
                else break; // el jugador 1 ya lo adivino
                                                            // continue; vuelve y evalua la condicion

                Console.Write("Jugador 2 :Ingrese numero");
                numJug2 = Convert.ToInt32(Console.ReadLine());
                conIntentos++;
                if (numJug2 > n) Console.WriteLine("El numero a adivinar es menor....");
                else if (numJug2 < n) Console.WriteLine("El numero a adivinar es mayor....");



            } while (numJug1 != n && numJug2 != n);

            if (numJug1 == n) Console.WriteLine("Felicitaciones jugador 1 {0} intentos", conIntentos);
            else Console.WriteLine("Felicitaciones jugador 2 {0} intentos", conIntentos);


            
            Console.ReadKey();
        }
    }
}
