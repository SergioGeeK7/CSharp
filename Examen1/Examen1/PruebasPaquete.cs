using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class PruebasPaquete:Servicio
    {

        private Servicio[] pruebas;

        public PruebasPaquete(string descripcion, string id, int numeroHoras, Servicio[] pruebas)
            :base(descripcion,id,numeroHoras)
        {
            this.Pruebas = pruebas;
        }

        public Servicio[] Pruebas
        {
            get { return pruebas; }
            set { pruebas = value; }
        }

        public override decimal TotalHorasCotizadas()
        {
            decimal total = 0m;
            foreach (Servicio servicio in Pruebas)
            {
                total += servicio.TotalHorasCotizadas();
            }

            return total;
        }

        public override decimal ValorServicio()
        {
            decimal valor = 0m;

            foreach (Servicio servicio in Pruebas)
            {
                valor += servicio.ValorServicio();
            }

            return valor*0.65m;

        }

        public override string ToString()
        {
            string servicios="";
            foreach (Servicio servicio in pruebas)
            {
                servicios += servicio.Descripcion+"\n\t\t\t\t\t";
            }
            servicios = servicios.Substring(0, servicios.Length - 6);

            return String.Format("Pruebas Paquete: {0} {1}\n\t" +
                                 "Servicios.....................: {2}\n\t"+
                                 "Total Horas Cotizadas..........: {3,13:n2}\n\t"+
                                 "Valor Servicio.................: {4:n2}",
                                 Id,Descripcion,servicios,TotalHorasCotizadas(),ValorServicio());


        }
    }
}
