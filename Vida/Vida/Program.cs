using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vida
{
    class Program
    {
        static void Main(string[] args)
       {

         
           Console.WriteLine("Genero [H]ombre [M]ujer: ..............................................?");
           string genero = Console.ReadLine().ToUpper();
           Console.WriteLine("Cantidad de cigarrillos que fuma mensual: .............................?");
           int cigarrillos= Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("vive: [S]olo o [A]companado: ..........................................?");
           string vive = Console.ReadLine().ToUpper();
           Console.WriteLine("Consumo de licor : [N]unca [O]cacionalmente, [R]egularmente:...........?");
           string licor= Console.ReadLine().ToUpper();
           Console.WriteLine("Numero de veces que hace ejercicio a la semana:........................?");
           int ejercicio= Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Tiene vida sexual activa ?:............................................?");
           string sex = Console.ReadLine().ToUpper();
           Console.WriteLine("Tiene alimentacion saludable: [S]i, [N]o ?:............................?");
           string alimentacion= Console.ReadLine().ToUpper();
           Console.WriteLine("Estrato................................................................?");
           int estrato= Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Vive en una zona de peligrosidad: [S]i, [N]o ?:........................?");
           string peligrosidad = Console.ReadLine().ToUpper();



           


           double esperanza;

           if (genero == "H") esperanza = 70;
           else esperanza = 77;

           if (cigarrillos == 0) esperanza += 5;
           else if (cigarrillos == 1) esperanza -= 3;
           else if (cigarrillos == 2) esperanza -= 4;
           else if (cigarrillos == 2) esperanza -= 5.5;
           else esperanza -= 6.2 - (cigarrillos - 4) * 0.7;

           if (vive == "S") esperanza -= 7;
           else esperanza += 4;

           if (licor == "O") esperanza *= 1.01; // incrementa 1%
           else if (licor == "R") esperanza *= 0.95;

           if (ejercicio == 0) esperanza *= 0.935; // el 6.5%  || 100 - 6.5
           else if (ejercicio == 1) esperanza *= 1.03;  // aumenta 3%
           else if (ejercicio <= 4) esperanza *= 1.06; // aumenta 6%
           else esperanza *= 1.12; // aumenta 12%

           if (sex == "S") esperanza += 9.5; // aumenta la esperanza de vida en 9.5
           if (alimentacion == "S") esperanza *= 1.06;

           if (estrato == 1) esperanza *= 0.98;
           else if (estrato == 2) esperanza *= 0.99;
           else if (estrato >= 4) esperanza *= 1.015; // aumenta el  1.5 % 

           if (peligrosidad == "S") esperanza *= 0.83;


           int anos = (int)esperanza; // para que bote la parte decimal
           int meses = (int)esperanza - anos; // la parte decimal 
           meses *=12; // parte decimal multiplicada por 12 meses


            // tenemos que convertir a meses
           Console.WriteLine("Su esperanza de vida es :..................................{0} anos, {1} meses",anos,meses);
           Console.ReadKey();















       }
    }
}
