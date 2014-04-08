using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Perro:Mamiferos
    {

        private int MaxLadrar; // deciveles

        public Perro(string nombre, int anos, string sexo) :
            base(nombre, anos, sexo)
        {
            MaxLadrar = 10;
            numeroDientes = 10;
        }

        public string Ladrar()
        {
            string guaw = "";
            int max = new Random().Next(1, MaxLadrar);

            for (int i = 0; i < max; i++)
            {
                guaw += "Guaw ";
            }
            return guaw;
        }


        public override string ToString()
        {
            return String.Format("{0};Ladrido:{1}", base.ToString(),Ladrar());
        }
    }
}
