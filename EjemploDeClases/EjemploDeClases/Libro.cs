using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClases
{
    class Libro
    {

        #region "atributos privados"
        
      

        // ATRIBUTOS PRIVADOS
        private string nombre;
        private decimal precio;
        #endregion

        // autoidentar ctrl + k + f
        //-------------------------------------------------------------
    



        // propiedades /GETTER AND SETTER
        // prop ...

        #region "propiedades"

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }

        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        // ATRIBUTO PROTECTED  NO SE PUEDE ACCEDER A EL DESDE AFUERA. LIBRO.ATRIBUTO_PROTECTED = ... NOP
        protected int exaple = 4;
        // ATRIBUTO PROTECTED SI SE HEREDA


        public string Nombre2 { get; set; }
        public decimal Precio2 { get; set; }


        #endregion


        
        
       
        public Libro()
        {
            this.nombre = "";
            this.precio = 0.0M; // costante Money
        }

        public Libro(string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.precio = precio; // costante Money
        }





        // Metodo toString
        #region "Metodos"
        public override string ToString()
        {
            // -20 alinea el texto a la izquierda
            // ,10 da un espaciado a la derecha
            // :N2 nos da el numero con dos deciamales
            return String.Format("Nombre : {0,-25}, Precio : ${1,10:N2}", nombre, precio);
        }
        #endregion



    }
}
