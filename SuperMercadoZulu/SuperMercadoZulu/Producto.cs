using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercadoZulu
{
    abstract class Producto
    {

        // atributos privados
        private string id;
        private string descripcion;
        private double tarifaIVA;


        // constructor

        public Producto(string id,string descripcion,double tarifaIVA)
        {
            // PORQUE PONER UN CONSTRUCTOR EN LA CLASE ABSTRACTA SINO SE PUEDE HACER UN OBJETO DE EL
            // PORQUE QUIERO UTILIZAR EL CONSTRUCTOR DE EL PARA ESTABLECER LAS VARIABLES HEREDADAS .. EN LA CLASE HIJA
            this.id = id;
            this.descripcion = descripcion;
            this.tarifaIVA = tarifaIVA;


        }

        // propiedades
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
       

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
       

        public double TarifaIVA
        {
            get { return tarifaIVA; }
            set { tarifaIVA = value; }
        }

        // toString

        public override string ToString()
        {
            // :P porcentaje P0 CERO decimales
            return String.Format("{0} {1}\n\tTarifa Iva........................: {2:P} ",
                                id,descripcion,tarifaIVA);
        }
      
        // metodos abstractos

        public abstract decimal ObtenerValorIva();
        public abstract decimal ObtenerValorVenta();




    }
}
