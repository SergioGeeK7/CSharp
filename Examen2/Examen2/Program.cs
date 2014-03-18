using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago m1 = new Mago("Merlin", 500, "H");
            Mago m2 = new Mago("Rasputin", 400, "E");
            Guerrero g1 = new Guerrero("Rey Arturo", 800, "E");
            Guerrero g2 = new Guerrero("Lancelot", 30, "L");
            Guerrero g3 = new Guerrero("Thor", 480, "M");
            Guerrero g4 = new Guerrero("Demonio Rojo", 300, "E");
            Guerrero g5 = new Guerrero("Zorro Maldito", 130, "L");
            Guerrero g6 = new Guerrero("Belcebuck", 480, "M");

            Personaje[] buenos = { m1, g1, g2, g3 };
            Personaje[] malos = { m2, g4, g5, g6 };

            Equipo heroes = new Equipo("Los buenos", 0, buenos);
            Equipo villanos = new Equipo("Los malos", 0, malos);

            m1.Combatir(m2);
            m2.Combatir(g1);
            g1.Combatir(g5);
            g5.Ayudar(g4);
            g4.Combatir(m1);
            heroes.Combatir(m2);
            villanos.Ayudar(m1);
            g1.Combatir(g5);

            Console.WriteLine(heroes);
            Console.WriteLine(villanos);
            Console.ReadKey();

        }
    }
}
