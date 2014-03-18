using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSumaHuevos
{
    class Calculos
    {
        private string cadena; // lo que el usuario va tirando al display
        private double resultado; // se almacena cuando el usuario de una operacion (+*-/)
        private bool suma;
        private bool resta;
        private bool division;      // VANDERAS SI HUBO MULTIPLICACION DIVISION SUMA RESTA
        private bool multiplicacion;

        public Calculos()
        {
            cadena = "";
            resultado = 0;
            ApagarVanderas();
        }

        private void ApagarVanderas()
        {
            this.suma = false; 
            this.resta = false; 
            this.division = false; 
            this.multiplicacion = false; 
        }

        public string Concatenar(string cadena) 
        {
            this.cadena += cadena;
            return this.cadena;
        }

        public void Suma(string cadena)
        {
            this.resultado = Convert.ToDouble(cadena);
            this.suma = true;
            this.cadena = "";
        }


        public void Resta(string cadena)
        {
            this.resultado = Convert.ToDouble(cadena);
            this.resta = true;
            this.cadena = "";
        }

        public void Multiplicacion(string cadena)
        {
            this.resultado = Convert.ToDouble(cadena);
            this.multiplicacion = true;
            this.cadena = "";
        }


        public void Division(string cadena)
        {
            this.resultado = Convert.ToDouble(cadena);
            this.division = true;
            this.cadena = "";
        }

        public double Resultado(string cadena)
        {
            if (suma) this.resultado += Convert.ToDouble(cadena);
            if (resta) this.resultado -= Convert.ToDouble(cadena);
            if (multiplicacion) this.resultado *= Convert.ToDouble(cadena);
            if (division) this.resultado /= Convert.ToDouble(cadena);
            ApagarVanderas();
            return resultado;
        }


        public void Clear() 
        {
            cadena = "";
            resultado = 0;
            ApagarVanderas();
        }





    }
}
