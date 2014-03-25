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
            throw new NotImplementedException();
        }

        public override bool HallarPerimetro()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
