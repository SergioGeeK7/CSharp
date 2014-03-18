using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class PruebasPerformance:Servicio
    {


        public PruebasPerformance(string descripcion, string id, int numeroHoras)
            :base(descripcion,id,numeroHoras)
        {

        }

        public override decimal TotalHorasCotizadas()
        {
            double pesimista = NumeroHoras * 0.2;
            double horasCotizadas = NumeroHoras + pesimista;
            double descuento = horasCotizadas * 0.1;

            return (decimal)(horasCotizadas - descuento);


        }

        public override decimal ValorServicio()
        {

            return TotalHorasCotizadas()*92000;


        }

        public override string ToString()
        {
            return String.Format("Pruebas Performance: {0}", base.ToString());
        }
    }
}
