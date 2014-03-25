using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibFiguraGeometrica;

namespace LibFiguras
{
    public class clsCuadrado : clsFiguraGeometrica
    {
        #region Constructor
        public clsCuadrado()
        {
            dblArea = 0;
            dblPerimetro = 0;
            dblLado = 0;
            strError = string.Empty;
        }

        #endregion

        #region Atributos
        private double dblLado;
        #endregion

        #region Propiedades
        public double Lado
        {
            set { dblLado = value; }
        }
        #endregion

        #region Metodos Publicos
        public override bool HallarArea()
        {

            try
            {
                if (!Validar()) return false;
                dblArea = Math.Pow(dblLado, 2.0);
                return true;
            }
            catch (Exception ex)
            {

                strError = ex.Message;
                return false;
            }


        }

        public bool Validar()
        {
            if (dblLado < 1)
            {
                strError = "Valor del lado no valido";
                return false;
            } 
            return true;
        }


        public override bool HallarPerimetro()
        {

            try
            {
                if (!Validar()) return false;
                dblPerimetro = 4.0*dblLado;
                return true;
            }
            catch (Exception ex)
            {

                strError = ex.Message;
                return false;
            }
        }
        #endregion


    }
}
