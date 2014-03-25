using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibFiguraGeometrica;

namespace LibFiguras
{
    class clsCuadrado : clsFiguraGeometrica
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
            throw new NotImplementedException();
        }

        public override bool HallarPerimetro()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
