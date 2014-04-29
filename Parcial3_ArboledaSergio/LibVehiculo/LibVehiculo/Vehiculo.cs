using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibVehiculo
{
    public abstract class Vehiculo
    {

        protected string nombreVehiculo;
        protected int kilometrosPorHora;
        protected string error;

      

        protected Vehiculo(string nombreVehiculo, int kilometrosPorHora)
        {
            this.nombreVehiculo = nombreVehiculo;
            this.kilometrosPorHora = kilometrosPorHora;
        }

        public abstract double avanzar(int horas); // return horas*kilometrosPorHora 

        public abstract bool Save(int horas);


        public string Error
        {
            get { return error; }
        }


    }
}
