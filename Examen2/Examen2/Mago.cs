using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Mago:Personaje
    {
        private string poder;

        public Mago(string nombre, int energia, string poder)
            :base(nombre,energia)
        {
            this.Poder = poder;
        }

        public string Poder
        {
            get { return poder; }
            set { poder = value; }
        }


        public override void Ayudar(Personaje ayuda)
        {
            if (!EstaVivo) return;
            if (this.Energia >50)
            {
                ayuda.Alimentarse(70);
                this.Herida(40);
            }
        }

        public override void Combatir(Personaje combate)
        {
            if (!EstaVivo) return;
            if (this.Energia>50)
            {
                if(this.poder=="H") combate.Herida(50);
                else if (this.poder == "E") combate.Herida(70);
                else combate.Herida(100);
            }
        }
    }
}
