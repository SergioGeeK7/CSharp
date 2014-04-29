using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAcuaticos;

namespace LibLancha
{
    public class Lancha:Acuatico
    {

        
        private string nombreMotor;

        public Lancha(string nombreVehiculo, int kilometrosPorHora, string nombreMotor)
            : base(nombreVehiculo, kilometrosPorHora)
        {
            this.nombreMotor = nombreMotor;
        }

        public override double navegar(int horas)
        {
            return horas*kilometrosPorHora;
        }

        public override double avanzar(int horas)
        {
            return navegar(horas);
        }

        public override bool Save(int horas)
        {
            try
            {
                using (StreamWriter w = File.AppendText("Parcial3.txt"))
                {
                    string output = String.Format("Nombre Vehiculo:{0};Kilometros Por Hora:{1};Nombre del motor:{2};Kilometros Recorridos:{3}",
                         this.nombreVehiculo, this.kilometrosPorHora, this.nombreMotor, avanzar(horas));

                    w.WriteLine(output);

                    return true;
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
