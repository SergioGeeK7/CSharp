using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public abstract class Aves:Animal
    {

        protected double AlasLenght;
        protected double MaxAltura;

        public Aves(string nombre, int anos, string sexo) 
            : base(nombre, anos, sexo)
        {
           
        }


        public abstract double volar();

        public override string ToString()
        {
            return String.Format("{0};Longitud Alas:{1};Maxima Altura:{2}", base.ToString(), AlasLenght, MaxAltura);
        }
    }
}
