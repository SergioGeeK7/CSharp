using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Gato:Mamiferos
    {
        private int maxMaulla;

        public Gato(string nombre, int anos, string sexo) : 
            base(nombre, anos, sexo)
        {
            this.maxMaulla = 10;
            numeroDientes = 6;
        }

        public string Mauyar()
        {
            string miau = "";
            int max = new Random().Next(1,maxMaulla);

            for (int i = 0; i < max; i++)
            {
                miau += "Miau ";
            }
            return miau;
        }



        // buscar caracteristicas perro,gato,mamiferos,aves
        // buscar clase perros, clase gatos , clase paloma ya hechas

        public override string ToString()
        {
            return String.Format("{0};Maulla:{1}", base.ToString(), Mauyar());
        }






    }
}
