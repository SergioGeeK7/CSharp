using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Equipo:Personaje
    {
        private Personaje[] integrantes;

        public Equipo(string nombre, int energia, Personaje[] integrantes)
            :base(nombre,energia)
        {
            this.Integrantes = integrantes;
        }


        public Personaje[] Integrantes
        {
            get { return integrantes; }
            set { integrantes = value; }
        }


        public override void Ayudar(Personaje ayuda)
        {
            double ayudando=0;

            foreach (Personaje integrante in integrantes)
            {

                if (integrante.EstaVivo)
                {
                    ayuda.Alimentarse((int)(integrante.Energia * 0.1));
                    //integrante.Energia = (int)(integrante.Energia * 0.9);    
                    integrante.Herida((int)(integrante.Energia * 0.9));
                }
                



            }


        }

        public override void Combatir(Personaje combate)
        {

            foreach (Personaje integrante in integrantes)
            {

                if (integrante.EstaVivo)
                {
                    combate.Herida((int)(integrante.Energia * 0.05));
                    integrante.Energia = integrante.Energia - 10;    
                }
                



            }
        }

        public override string ToString()
        {
            string team = "";

            foreach (Personaje integrante in integrantes)
            {
                team += integrante.ToString()+"\n";
            }

            return team;

        }
    }
}
