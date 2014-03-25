using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libfigura
{
    public class CLSFigura
    {
        #region "Atributos"
          // modificador de acceso  private
        private int intTipoFig;
        private double dblLado1;
        private double dblLado2;
        private double dblArea;
        private double dblPerimetro;
        private string strError;





        #endregion
        #region "Constructor"
        public CLSFigura() {
        
            intTipoFig=0;
            dblLado1 = 0;
            dblLado2 = 0;
            dblArea = 0;
            dblPerimetro = 0;
            strError=string.Empty;


        }

        #endregion
        #region "Propiedades"

        public int TipoFigura
        { 
            //descriptores de clase ¬¬ entrada o salida

            // descriptor de entrada

            set { intTipoFig = value; }
        }

        public double Lado1
        {
            set { dblLado1 = value; }
        }

        public double Lado2
        {
            set { dblLado2 = value; }
        }

        public double Area
        {
            get { return dblArea; }
        }

        public double Perimetro
        {
            get { return dblPerimetro; }
        }

        public string Error
        {
            get { return strError; }
        }

        #endregion
        #region "Metodos Privados"

        private bool Validar() {

            if (intTipoFig != 1 && intTipoFig != 2)
            {
                strError = "Tipo de figura no valida";
                return false;
            }
            
            if (dblLado1<1)
            {
                strError = "Valor del lado no valido";
                return false;
            }

            if (intTipoFig == 2)
                if (dblLado2<1)
                {
                    strError = "Valor del lado 2 no valido";
                    return false;
                }

            return true;

        }  

        #endregion
        #region "Metodos Publicos"

        public bool procesar() {

            try
            {
                if (!Validar())
                {
                    return false;
                }

                if (intTipoFig == 1) // cuadraro
                {
                    dblArea = Math.Pow(dblLado1, 2.0);
                    dblPerimetro = dblLado1 * 4.0;


                }
                else { // rectangulo

                    dblArea = dblLado1* dblLado2 ;
                    dblPerimetro = (dblLado1 * 2.0) + (dblLado2 * 2.0);
                    
                }

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
