using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Clases
{
    class Utilidades
    {
        private static decimal numeroDecimal = 0;
        private static int numeroEntero = 0;
        private static string error="";
        
        
        public static decimal NumeroDecimal
        {
            get { return numeroDecimal; }
        }

        public static int NumeroEntero
        {
            get { return numeroEntero; }
        }

        public static string Error
        {
            get { return error; }
        }


        public static bool ValidarDecimal(string numero)
        {
            try
            {
                numeroDecimal = Convert.ToDecimal(numero);
                return true;
            }
            catch (Exception ex)
            {
                numeroDecimal = 0;
                error = ex.Message;
                return false;
            }
        }


        public static bool ValidarEntero(string numero)
        {
            try
            {
                numeroEntero = Convert.ToInt32(numero);
                return true;
            }
            catch (Exception ex)
            {
                numeroEntero = 0;
                error = ex.Message;
                return false;
            }
        }



    }
}
