using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibVehiculo;


namespace LibAcuaticos
{
    public abstract class Acuatico:Vehiculo
    {

        public abstract double navegar(int horas);

        protected Acuatico(string nombreVehiculo, int kilometrosPorHora) : base(nombreVehiculo, kilometrosPorHora)
        {
        }
    }
}
