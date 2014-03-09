using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEjercicio2
{
    public class clsEjercicio2
    {

        #region "Atributos"
        private double dblSalarioActual;
        private double dblPorcentaje;
        private double dblMontoAumento;
        private double dblAntiguedad;
        private string StrError;

        #endregion




        #region "Constructor"
        public clsEjercicio2()
        {
            dblSalarioActual = 0;
            dblPorcentaje = 0;
            dblMontoAumento = 0;
            dblAntiguedad = 0;
            StrError = string.Empty;
        }
        #endregion



        #region "Propiedades"


        public double SalarioActual
        {
            set { dblSalarioActual = value; }
        }
        public double Antiguedad
        {
            set { dblAntiguedad = value; }
        }


        public double MontoAumento
        {
            get { return dblMontoAumento; }
        }


        public double Porcentaje
        {
            get { return dblPorcentaje; }
        }

        public string Error
        {
            get { return StrError; }
        }

        #endregion




        #region "Metodos Privados"

        private bool validar()
        {
            if (dblAntiguedad <= 0)
            {
                StrError = "Cantidad de años no válida";
                return false;
            }
            if (dblSalarioActual <= 0)
            {
                StrError = "Salario actual no válido";
                return false;
            }
            return true;

        }

        #endregion



        #region "Metodos Publicos"

        public bool Calcular()
        {
            try
            {

                if (!validar())
                    return false;

                if (dblSalarioActual <= 700000)
                {
                    if (dblAntiguedad >= 5)
                    {
                        dblPorcentaje = 4.95;
                        dblMontoAumento = dblSalarioActual * (dblPorcentaje / 100);
                    }
                    else
                    {
                        dblPorcentaje = 4.55;
                        dblMontoAumento = dblSalarioActual * (dblPorcentaje / 100);
                    }
                }
                else if (dblSalarioActual < 2500000)
                {

                    if (dblAntiguedad > 5)
                    {
                        int intcantAños = Convert.ToInt32(dblAntiguedad / 3);
                        dblPorcentaje = 2.71;
                        dblMontoAumento = dblSalarioActual * (dblPorcentaje / 100) * intcantAños;
                    }
                    else
                    {
                        dblPorcentaje = 4.6;
                        dblMontoAumento = dblSalarioActual * (dblPorcentaje / 100);
                    }
                }
                else
                {
                    if (dblAntiguedad > 5)
                    {
                        int intcantAños = Convert.ToInt32(dblAntiguedad / 3);
                        dblPorcentaje = 2.5;
                        dblMontoAumento = dblSalarioActual * (dblPorcentaje / 100) * intcantAños;
                    }
                    else
                    {
                        dblPorcentaje = 4.3;
                        dblMontoAumento = dblSalarioActual * (dblPorcentaje / 100);
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
