using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLiquidacion
{
    public class Class1
    {

        string error;
        double salarioBruto;// sin retenciones
        double totalRetencion;
        double totalSubsidio;
        double salarioNeto;


        int nhijos;
        int nhoras;
        int nhijos18;
        double vrHora;


        public int Nhijos
        {
            
            set { nhijos = value; }
        }
        

        public int Nhijos18
        {
            
            set { nhijos18 = value; }
        }
        

        public double VrHora
        {
            
            set { vrHora = value; }
        }
        

        public int Nhoras
        {
            
            set { nhoras = value; }
        }


        public double TotalRetencion
        {
            get { return totalRetencion; }

        }
        public double SalarioNeto
        {
            get { return salarioNeto; }
            
        }
        public double TotalSubsidio
        {
            get { return totalSubsidio; }
            
        }

        public double SalarioBruto
        {
            get { return salarioBruto; }
            
        }

        public string Error
        {
            get { return error; }
        
        }


        public bool Validar()
        {

            if (nhijos<0)
            {
                error = "numero de hijos invalido";
                return false;
            }
            if (nhijos18 < 0)
            {
                error = "numero de hijos invalido";
                return false;
            }

            if (vrHora< 0)
            {
                error = "numero de hijos invalido";
                return false;
            }

            if (nhoras< 0)
            {
                error = "numero de hijos invalido";
                return false;
            }
            
            return true;
        }

        double retencionEnFuente=0;
        double salarioMinimo = 616.000;

        public bool Calcular()
        {
            if (!Validar())
            {
                return false;
            }

            double retencionSalud = 0.4;
            double retencionPension = 0.4;
            salarioBruto = nhoras * vrHora;

            if (salarioBruto < salarioMinimo)
            {
                if (nhijos <= 3)
                {
                    retencionEnFuente = 0.6;

                    retencionEnFuente -= nhijos / 2;

                }
                else retencionEnFuente = 0.0;

            }
            else
            {
                if (nhijos < 3)
                {
                    retencionEnFuente = 0.3;



                }
                else {
                    retencionEnFuente = 0.1;
                    retencionEnFuente /= nhijos;

                } 


            }

            double subsTrasporte =0;

            if ((salarioMinimo*2) == salarioBruto)
            {
                subsTrasporte = 72.000;
            }


            double subsidioMenorEdad;
            // subsidio menor de edad
            subsidioMenorEdad = 50.500 * nhijos18;


            totalSubsidio = subsidioMenorEdad + subsTrasporte;
            totalRetencion = retencionPension + retencionSalud + retencionEnFuente;  // total porcentaje retencion
            totalRetencion *= salarioBruto; // total en pesos
            salarioNeto = totalSubsidio + salarioBruto - totalRetencion;
            


            return true;
        }












    }
}
