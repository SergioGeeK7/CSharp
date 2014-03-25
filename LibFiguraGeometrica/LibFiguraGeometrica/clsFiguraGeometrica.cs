using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFiguraGeometrica
{
    public abstract class clsFiguraGeometrica
    {
        #region "Atributos"
        protected double dblArea;
        protected double dblPerimetro;
        protected string strError;
        #endregion

        #region "Propiedades"
        public double Area
        {
            get { return dblArea; }
        }
        public double  Perimetro
        {
            get{return dblPerimetro;}
        }
        public string Error
        {
            get { return strError; }
        }


        #endregion

        #region "Metodos Publicos"
        public abstract bool HallarArea();
        public abstract bool HallarPerimetro();
        #endregion
    }
}
