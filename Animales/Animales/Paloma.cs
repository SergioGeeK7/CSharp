using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Paloma:Aves
    {

        // paloma vs aguila

         public Paloma(string nombre, int anos, string sexo) 
            : base(nombre, anos, sexo)
        {
       
            base.MaxAltura = 1; // metros
            base.AlasLenght = 10; // centimetros
        }

        public override double volar()
        {
            return new Random().NextDouble()*(MaxAltura - 0.2) + 0.2;
        }





    }
}
