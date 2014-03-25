using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libInvitaciones
{
    public class Class1
    {
        private int edad;
        private string strError;

        private double edadTotales;
        private double promedioEdadAcompanantes;
        private int nacompanantes;
        private int totalAsistentes;

        private int totalAmigos;
        private int totalAcompanantes;

        private int totalAmigosyAcompanantes; // trampa para sacar el promedio


        private double valorAmigo;
        private double valorAcompanante;

        private int totalInvitaciones;


        public Class1()
        {
            Edad = 0;
            edadTotales = 0.0;
            promedioEdadAcompanantes = 0.0;
            totalAmigos = 0;
            totalAmigosyAcompanantes = 0;
            Nacompanantes = 0;
            valorAmigo = 0;
            valorAcompanante = 0;
            totalAcompanantes = 0;
            totalAsistentes = 0;
            totalInvitaciones = 0;
            strError = string.Empty;
        }

        public int TotalAcompanantes
        {
            get { return totalAcompanantes; }
        }

        public int TotalAmigos
        {
            get { return totalAmigos; }
        }

        public int TotalAsistentes
        {
            get { return totalAsistentes; }
        }

        public string StrError
        {
            get { return strError; }
        }

        public int Edad
        {
            set { edad = value; }
        }

        public int Nacompanantes
        {
            set { nacompanantes = value; }
        }

        public double PromedioEdadAcompanantes
        {
            set { promedioEdadAcompanantes = value; }
        }

        public int TotalInvitaciones
        {
            get { return totalInvitaciones; }
            set { totalInvitaciones = value; }
        }


        private bool Validar()
        {
            if (edad > 0) return true;
            strError = "edad no valida";
            return false;
        }




        public bool Calcular()
        {
            if (!Validar())
                return false;

            edadTotales += edad + promedioEdadAcompanantes;
            totalAmigos++;
            totalAcompanantes += nacompanantes;
            totalAsistentes += nacompanantes + 1;

            totalAmigosyAcompanantes += nacompanantes > 0 ? 2 : 1;
            return true;
        }

        string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Negocio.txt";
        // cadena de direccion @ ... no es una cadena NORMAL
        public bool LeerArchivo()
        {
            try
            {
                string[] vec; // DONDE SE GUARDA EL SPLIT :
                string strNombreDato;
                string strLinea;
                double dblValor;

                int intCan = File.ReadAllLines(strPath).Length;
                if (intCan < 1)
                {
                    strError = "No hay datos en el archivo Porfavor Contacte con SERGIO";
                    return false;
                }

                // espeficica que un String es de tipo direccion y respete los caracteres especiales
                StreamReader archivo = new StreamReader(@strPath);
                while ((strLinea = archivo.ReadLine()) != null)
                {
                    vec = strLinea.Split(':');
                    strNombreDato = vec[0];
                    dblValor = Convert.ToDouble(vec[1]);

                    switch (strNombreDato)
                    {
                        case "X": valorAmigo = dblValor;
                            break;
                        case "Y": valorAcompanante = dblValor;
                            break;
                    }

                }// fin while

                archivo.Close();// cierre el archivo y libere memoria
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
                throw;
            }

        } // FIN LEER ARCHIVO

        public double PromedioEdadesTotales()
        {
            return edadTotales / totalAmigosyAcompanantes;
        }

        public double ValorAmigos()
        {
            return totalAmigos * valorAmigo;
        }
        public double ValorAcompanantes()
        {
            return totalAcompanantes * valorAcompanante;
        }








    }
}
