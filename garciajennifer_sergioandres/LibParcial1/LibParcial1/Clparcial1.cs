using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace LibParcial1
{
    public class Clparcial1
    {
        #region "Atributos"



        private int intCodigo;
        private int intTipoVenta;
        private double vlrVenta;
        private double dblTotalVentaContado1;
        private double dblTotalVentaCredito1;
        private double dblTotalVentaContado2;
        private double dblTotalVentaCredito2;
        private string StrError;


        #endregion


        #region "Constructor"

        public Clparcial1()
        {
            intCodigo = 1;
            intTipoVenta = 0;
            vlrVenta = 0;
            dblTotalVentaContado1 = 0;
            dblTotalVentaCredito1 = 0;
            dblTotalVentaContado2 = 0;
            dblTotalVentaCredito2 = 0;
            intTipoVenta = 0;

            StrError = string.Empty;
        }

        #endregion



        #region "Propiedades"


        public double DTotalVentaContado2
        {
            get { return dblTotalVentaContado2; }
        }

        public double TotalVentaContado1
        {
            get { return dblTotalVentaContado1; }
        }

        public double TotalVentaCredito1
        {
            get { return dblTotalVentaCredito1; }
        }

        public double TotalVentaCredito2
        {
            get { return dblTotalVentaCredito2; }
        }

        public string Error1
        {
            get { return StrError; }
        }

        public double VlrVenta
        {
            set { vlrVenta = value; }
        }

        public int TipoVenta
        {
            set { intTipoVenta = value; }
        }

        public int Codigo
        {
            set { intCodigo = value; }
        }



        #endregion



        #region "Metodos Privados"

        private bool validar()
        {
            if (intCodigo != 1 && intCodigo != 2)
            {
                StrError = "Codigo del almacen no valido";
                return false;
            }
            if (intTipoVenta != 1 && intTipoVenta != 2)
            {
                StrError = "Tipo de venta no valida";
                return false;
            }

            if (vlrVenta <= 0)
            {
                StrError = "Valor de venta no valida";
                return false;
            }


            return true;

        }



        #endregion



        #region "Metodo Publico"



        public bool Calcular()
        {

            try
            {

                if (!validar())
                    return false;


                if (intCodigo ==1 )
                {

                    if (intTipoVenta == 1)
                    {

                        dblTotalVentaContado1 += vlrVenta;

                    }
                    else {
                        dblTotalVentaCredito1 += vlrVenta;
                    }

                }else{

                    if (intTipoVenta == 1)
                    {

                        dblTotalVentaContado2 += vlrVenta;

                    }
                    else
                    {
                        dblTotalVentaCredito2 += vlrVenta;
                    }
                
                
                }


                return true;

            }


            catch (Exception ex)
            {

                StrError = ex.Message;
                return false;
            }

        }

        #endregion



    }
}
