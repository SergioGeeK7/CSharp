using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Guerrero:Personaje
    {

        private string arma;


        public Guerrero(string nombre, int energia, string arma)
            :base(nombre,energia)
        {
            this.Arma = arma;
        }
        public string Arma
        {
            get { return arma; }
            set { arma = value; }
        }

        public override void Ayudar(Personaje ayuda)
        {
            if (!EstaVivo) return;
            if (this.Energia <= 100) return;
            ayuda.Alimentarse(80);
            this.Herida(80);
        }

        public override void Combatir(Personaje combate)
        {
            if (!EstaVivo) return;
            if (this.Energia <= 10) return;

                switch (this.Arma)
                {
                    case "E":combate.Herida(30);
                    break;
                    case "L": combate.Herida(40);
                    break;
                    default:combate.Herida(50);
                    break;
                }
            
        }
    }
}
