using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibFiguraGeometrica;

namespace LibFiguras
{
    public class clsTriangulo : clsFiguraGeometrica
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

        public clsTriangulo(double lado1,double lado2,double lado3)
        {
            dblArea = 0;
            dblPerimetro = 0;
            dblLadoA = lado1;
            dblLadoB = lado2;
            dblLadoC = lado3;
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
            try
            {
                if (!Validar()) return false;
                dblPerimetro = dblLadoA + dblLadoB + dblLadoC;
                dblArea = Math.Sqrt(dblp * (dblp - dblLadoA) * (dblp - dblLadoB) * (dblp - dblLadoC));
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
                
                {
                    if (!Validar()) return false;
                    dblPerimetro = dblLadoA + dblLadoB + dblLadoC;
                    return true;
                }
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }



        private bool Validar()
        {
            if (dblLadoA<1)
            {
                strError = "Valor lado A no valido";
                return false;
            }
            if (dblLadoB < 1)
            {
                strError = "Valor lado B no valido";
                return false;
            }
            if (dblLadoC < 1)
            {
                strError = "Valor lado C no valido";
                return false;
            }

            if ((dblLadoA + dblLadoB) > dblLadoC)
            {
                strError = "No se puede construir un triangulo con los valores dados";
                return false;
            }

            //dblp = (dblLadoA + dblLadoB + dblLadoC) / 2.0;
            //dblBajoRadical = dblp * (dblp - dblLadoA) * (dblp - dblLadoB) * (dblp - dblLadoC);

            //if (dblBajoRadical<1)
            //{
            //    strError = "Los valores no son validos para un tringulo";
            //    return false;
            //}


            return true;
        }


        #endregion
    }
}
