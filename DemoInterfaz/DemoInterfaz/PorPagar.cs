using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaz
{
    interface PorPagar
    {
        // TODO LO QUE HAY EN UNA INTERFACE ES ABSTRACTO
        // LAS APIs de .NET Tienen interfaces Genericas
        // Que tiene un empleado y una factura en comun.. ?
        // las interfaces tienden a hacer genericas

        decimal ObtenerMontoPago();

    }
}
