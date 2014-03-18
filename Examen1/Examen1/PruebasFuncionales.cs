using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class PruebasFuncionales:Servicio
    {
        public PruebasFuncionales(string descripcion, string id, int numeroHoras)
            :base(descripcion,id,numeroHoras)
        {
            


        }


        public override decimal TotalHorasCotizadas()
        {
            decimal pesimista = NumeroHoras*0.35m;

            return NumeroHoras + pesimista;


        }

        public override decimal ValorServicio()
        {
            return TotalHorasCotizadas()*72000m;
        }

        public override string ToString()
        {
            return String.Format("Pruebas Funcional: {0}",base.ToString());
        }
    }
}
