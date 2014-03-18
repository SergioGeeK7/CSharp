using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{

    abstract class Servicio
    {
        private string descripcion;
        private string id;
        private int numeroHoras;

        public Servicio( string id,string descripcion, int numeroHoras)
        {
            this.descripcion = descripcion;
            this.id = id;
            this.numeroHoras = numeroHoras;
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public int NumeroHoras
        {
            get { return numeroHoras; }
            set { numeroHoras = value; }
        }

        public abstract decimal TotalHorasCotizadas();
        public abstract decimal ValorServicio();

        public override string ToString()
        {
            return String.Format("{0} {1}\n\t" +
                                 "Numero Horas.....................:{2,7:n2}\n\t" +
                                 "Total horas cotizadas............:{3,7:n2}\n\t" +
                                 "Valor servicio...................:{4,7:n2}\n",
                id, descripcion, numeroHoras,TotalHorasCotizadas(),ValorServicio());
        }
    }
}
