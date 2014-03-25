using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace univercidad
{
    public class Class1
    {


        #region "Atributos / Variables globales privadas"

            private double promedio;
            private int preprogrado;
            private int ncreditos;
            private string error;

        #endregion



            #region "Constructor"

            public Class1() {

                this.ncreditos = 0;
            
             }



            #endregion



            #region "Propiedades / GETTER AND SETTER"

            public double SetPromedio {
                set { promedio = value; }
            }

            public int SetPreProgrado
            {
                set { this.preprogrado = value; }
            }

            




            #endregion


        #region "Metodos" 


            private bool Validar(){

                if (this.promedio<1)
                {
                    error = "El promedio no puede ser negativo ni cero ";
                    return false;
                }

                if (preprogrado<0 || preprogrado>2)
                {
                    error = "El tipo de programa no es valido  ";
                    return false;
                }


                return true;
            }



            public bool Calcular() {

                if (!Validar())
                {

                     return false;

                }

                if (promedio>=4.5 && preprogrado ==1)
                {
                    

                }





                return true;
            }



        #endregion



    }
}
