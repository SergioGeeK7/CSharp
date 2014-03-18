using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    abstract class Personaje
    {
        private int energia;
        private bool estaVivo;
        private string nombre;

        public Personaje(string nombre, int energia)
        {
            this.nombre = nombre;
            this.energia = energia;
            this.estaVivo = true;
        }

        public int Energia
        {
            get { return energia; }
            set { energia = value; }
        }

        public bool EstaVivo
        {
            get { return estaVivo; }
            set { estaVivo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void Alimentarse(int a)
        {
            if (!estaVivo) return;
            this.energia += a;
        }

        public void Herida(int a)
        {
            this.energia -= a;
            if (energia < 1) estaVivo = false;
        }

        public abstract void Ayudar(Personaje ayuda);
        public abstract void Combatir(Personaje combate);

        public override string ToString()
        {
            if (estaVivo) return String.Format("{0}, Energia: {1}", nombre, energia);
            return String.Format("{0}, Esta Muerto", nombre);
        }
    }
}
