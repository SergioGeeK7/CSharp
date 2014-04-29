using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Aguila:Aves
    {
        public Aguila(string nombre, int anos, string sexo) 
            : base(nombre, anos, sexo)
        {
          
            base.MaxAltura = 2; // metros
            base.AlasLenght = 20; // centimetros
        }

        public override double volar()
        {
            return new Random().NextDouble()*(MaxAltura - 0.3) + 0.3;
        }

    }
}
