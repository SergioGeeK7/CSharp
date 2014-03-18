using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenesSA
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal CC, PC, PA, VOL, VR_V, VR_P, CA, CE, PDP;
            string TP, TC, MA;
            PedirDatos(out CC,out TP,out TC,out PC,out PA,out VOL,out MA);
            CA = CalcularCA(TP, CC, TC, PC, PA, VOL); // analizar de que depende..costo almacenamiento
            PDP = CalcularPDP(PA);
            CE = CalcularCE(TP, TC, MA, CA);

            VR_P = (CC + CA + CE) * PDP;

            if (TP == "P") VR_V =VR_P*1.4m;
            else VR_V = VR_P * 1.2m;

            
            MostrarResultados(CA, PDP, CE, VR_P, VR_V);


        }

        private static void PedirDatos(out decimal CC, out string TP, out string TC, out decimal PC, out decimal PA, out decimal VOL, out string MA)
        {
            Console.WriteLine("***********DATOS DE ENTRADA***********");
            Console.Write("Costo de compra ($)....................................................: ");
            CC = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Tipo de producto [P]erecedero, [N]o perecedero.........................: ");
            TP = Console.ReadLine().ToUpper();
            Console.Write("Tipo de conservación [F]rio, [A]mbiente................................: ");
            TC = Console.ReadLine().ToUpper();
            Console.Write("Periodo de conservación (días).........................................: ");
            PC = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Periodo de almacenamiento (días).......................................: ");
            PA = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Volumen (litros).......................................................: ");
            VOL = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Medio de almacenamiento [N]evera, [C]ongelador, [E]estanteria, [G]uacal: ");
            MA = Console.ReadLine().ToUpper();
            Console.WriteLine("*** CALCULOS ***");

        }


        private static decimal CalcularCA(string TP, decimal CC, string TC, decimal PC, decimal PA, decimal VOL)
        {
           //37.21
            // ir al enunciado

            if (TP=="P")// perecederos
            {
                if (TC == "F" && PC < 10) return CC*0.05m;
                if (TC == "F" && PC >= 10) return CC*0.10m;
                if (TC == "A" && PA < 20) return CC*0.03m;
                if (TC == "A" && PA > 20) return CC*0.10m;
                
                return CC*0.05m;
            }
            else // no perecederos
            {
                if (VOL >= 50) return CC*0.10M;
                return CC*0.20M;
            }
        }
        
        
        private static decimal CalcularPDP(decimal PA)
        {
            if (PA < 30) return 0.95M;
            return 0.85m;
        }

        private static decimal CalcularCE(string TP, string TC, string MA, decimal CA)
        {
            if (TP=="P") // perecederos
            {
                if (TC == "F" && MA == "N") return CA*2;
                return CA;
            }
            else // no perecederos
            {
                if (MA == "E") return CA*0.05M;
                return CA*0.07M;

            }
        }




        private static void MostrarResultados(decimal CA, decimal PDP, decimal CE, decimal VR_P, decimal VR_V)
        {
            Console.WriteLine("***** CALCULOS *********");
            Console.WriteLine("Porcentaja de depreciación.............................: {0:P}",PDP);
            Console.WriteLine("Costos de almacenamiento...............................: ${0,12:N0}",CA);
            Console.WriteLine("Costo de exhibición....................................: ${0,12:N0}",CE);
            Console.WriteLine("Valor producto.........................................: ${0,12:N0}",VR_P);
            Console.WriteLine("Valor venta............................................: ${0,12:N0}",VR_V);
            Console.ReadKey();

        }





    }
}
