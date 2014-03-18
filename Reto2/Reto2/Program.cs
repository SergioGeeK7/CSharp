using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ano menor? ");
            int anoMen= Convert.ToInt32(Console.ReadLine());
            Console.Write("Mes Menor ");
            int mesMenor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ano Mayor ");
            int anoMayor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mes Mayor ");
            int mesMayor = Convert.ToInt32(Console.ReadLine());

            int mesesMayor = anoMayor * 12 + mesMayor;
            int mesesMenor = anoMen * 12 + mesMenor;
            int meses = mesesMayor - mesesMenor; // cuanto a trancurrido en meses 80
            int ano = meses / 12; // convertir meses a anos

            int mes = meses - ano * 12;

            Console.Write("Han pasado: {0} anos y {1} meses",ano,mes);
            Console.ReadKey();

            // 18,46

        }
    }
}
