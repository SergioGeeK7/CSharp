using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public abstract class Mamiferos:Animal
    {

        // CARACTERISTICAS DE LOS MAMIFEROS


        protected int numeroDientes;

        // abstract mama 

        protected Mamiferos(string nombre, int anos, string sexo) : 
            base(nombre, anos, sexo)
        {
          
        }



       // public abstract Mamiferos Mama();


        public override string ToString()
        {
            return String.Format("{0};numeroDientes:{1}", base.ToString(), numeroDientes);
        }
    }
}
