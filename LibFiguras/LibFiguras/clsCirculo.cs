using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibFiguraGeometrica;

namespace LibFiguras
{
    public class clsCirculo : clsFiguraGeometrica
    {
        #region Atributos
        private double dblRadio;
        #endregion

        #region Propiedades
        public double Radio
        {
            set { dblRadio = value; }
        }
        #endregion

        #region "Construtor"
        public clsCirculo()
        {
            dblArea = 0;
            dblPerimetro = 0;
            dblRadio = 0;
        }






        #endregion

        #region Metodos Publicos
        public override bool HallarArea()
        {
            try
            {
                if (!Validar()) return false;
                dblArea = Math.PI * Math.Pow(dblRadio, 2.0); // 2.0 porque estan pidiendo doble
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;

            }
        }

        public override bool HallarPerimetro()
        {
            try
            {
                if (!Validar()) return false;
                dblPerimetro = Math.PI * 2.0 * dblRadio;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion


        public bool Validar()
        {
            if (dblRadio < 1)
            {
                strError = "Valor del radio no valido";
                return false;
            }

           


            return true;
        }

    }
}
