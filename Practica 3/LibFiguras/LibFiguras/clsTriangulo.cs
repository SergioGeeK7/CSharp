using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibFiguraGeometrica;

namespace LibFiguras
{
    class clsTriangulo : clsFiguraGeometrica
    {
        #region Constructor
        public clsTriangulo()
        {
            dblArea = 0;
            dblPerimetro = 0;
            dblLadoA = 0;
            dblLadoB = 0;
            dblLadoC = 0;
            strError = string.Empty;
        }

        #endregion

        #region Atributos
        private double dblLadoA;
        private double dblLadoB;
        private double dblLadoC;
        private double dblp;
        private double dblBajoRadical;
        #endregion

        #region Propiedades
        public double LadoA
        {
            set { dblLadoA = value; }
        }
        public double LadoB
        {
            set { dblLadoB = value; }
        }
        public double LadoC
        {
            set { dblLadoC = value; }
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
