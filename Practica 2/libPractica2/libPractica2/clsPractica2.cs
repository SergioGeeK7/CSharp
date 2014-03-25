using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace libPractica2
{
    public class clsPractica2
    {

        #region "Atributos"

            private double dblVrDolar;
            private double dblVrCartaT1;
            private double dblVrCartaT2;
            private double dblVrCartaT3;
            private double dblVrCaja1;
            private double dblVrCaja1_Adic;
            private double dblVrCaja2;
            private double dblVrCaja2_Adic;
            private double dblVrCaja3;
            private double dblVrCaja3_Adic;
            private string strError;

        #endregion

        #region "Constructor"

            public clsPractica2()
            {
                dblVrDolar = 0;
                dblVrCartaT1 = 0;
                dblVrCartaT2 = 0;
                dblVrCartaT3 = 0;
                dblVrCaja1 = 0;
                dblVrCaja1_Adic = 0;
                dblVrCaja2 = 0;
                dblVrCaja2_Adic = 0;
                dblVrCaja3 = 0;
                dblVrCaja3_Adic = 0;
                strError = string.Empty;
            }

        #endregion

        #region "Propiedades"

            public double VrDolar 
            {
                get { return dblVrDolar; }
            }

            public double VrCartaTarifa1
            {
                get { return dblVrCartaT1; }
            }

            public double VrCartaTarifa2
            {
                get { return dblVrCartaT2; }
            }

            public double VrCartaTarifa3
            {
                get { return dblVrCartaT3; }
            }

            public double VrCaja1
            {
                get { return dblVrCaja1; }
            }

            public double VrCaja1_Adic
            {
                get { return dblVrCaja1_Adic; }
            }

            public double VrCaja2
            {
                get { return dblVrCaja2_Adic; }
            }

            public double VrCaja2_Adic
            {
                get { return dblVrCaja2_Adic; }
            }

            public double VrCaja3
            {
                get { return dblVrCaja3; }
            }

            public double VrCaja3_Adic
            {
                get { return dblVrCaja3_Adic; }
            }

            public string Error
            {
                get { return strError; }
            }
        #endregion


        #region "Metodos Privados"

            string strPath = AppDomain.CurrentDomain.BaseDirectory + @"DatosCostos.txt";
            // cadena de direccion @ ... no es una cadena NORMAL
            private bool LeerArchivo()
            {
                try
                {
                    string[] vec;
                    string strNombreDato;
                    string strLinea;
                    double dblValor;

                    int intCan = File.ReadAllLines(strPath).Length;
                    if (intCan<1)
                    {
                        strError = "No hay datos en el archivo Porfavor Contacte con SERGIO";
                        return false;
                    }

                    // espeficica que un String es de tipo direccion y respete los caracteres especiales
                    StreamReader archivo = new StreamReader(@strPath); 
                    while ((strLinea = archivo.ReadLine())!=null)
                    {
                        vec = strLinea.Split(':');
                        strNombreDato = vec[0];
                        dblValor = Convert.ToDouble(vec[1]);

                        switch (strNombreDato)
                        {
                            case "Dolar": dblVrDolar = dblValor;
                            break;
                            case "Carta1": dblVrCartaT1 = dblValor;
                            break;
                            case "Carta2": dblVrCartaT2 = dblValor;
                            break;
                            case "Carta3": dblVrCartaT3 = dblValor;
                            break;
                            case "Caja1_Norm": dblVrCaja1 = dblValor;
                            break;
                            case "Caja1_Add": dblVrCaja1_Adic = dblValor;
                            break;
                            case "Caja2_Norm": dblVrCaja2 = dblValor;
                            break;
                            case "Caja2_Add": dblVrCaja2_Adic = dblValor;
                            break;
                            case "Caja3_Norm": dblVrCaja3 = dblValor;
                            break;
                            case "Caja3_Add": dblVrCaja3_Adic = dblValor;
                            break;
                            default:
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

            }
    #endregion



            #region "Metodos Publicos"

            public bool ObtenerDatos()
            {
                return LeerArchivo();
            }

            #endregion
            



    }
}
