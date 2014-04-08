using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public abstract class Animal
    {

        protected string nombre;
        protected int anos;
        protected string sexo;
        

        //protected bool lleno;
        //protected int cantidadComida;
        public Animal(string nombre, int anos, string sexo)
        {
            this.nombre = nombre;
            this.anos = anos;
            this.sexo = sexo;
        }

        //protected Comer (int a)
        //{
                
        //    if(lleno)return;



        //}

        public override string ToString()
        {
            return String.Format("nombre:{0};anos:{1};sexo:{2}", nombre, anos, sexo);
        }
    }
}
