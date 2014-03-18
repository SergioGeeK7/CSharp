using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //new String[]{“a”,”b”,”c”,”d”}
            Format("ffff", new Object[]{"4",1}); // FUNK

            Format("ffff","sdf",4564,654,654,654,65465,4564,654654,65465,"ffffff",848,664,65465,65465,65465,"hellow");
            Format("ffff", 65465, "ffffff", 848, 664, 65465, 65465, 65465, "hellow 2");
            ParametrosOpcionales("hola");
            ParametrosOpcionales("hola","hellow");
            Console.ReadKey();
        }

        public static void Format(string format,params Object[] args)
        {

            foreach (object o in args)
            {
                Console.WriteLine(o);
            }

        }


        public static void ParametrosOpcionales(string saludo, string respuesta = "default")
        {
            Console.WriteLine(saludo+" "+respuesta);
        }



    }
}
