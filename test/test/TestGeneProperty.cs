using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class TestGeneProperty
    {

        private double lala;
        private decimal salario;
        private string nombre;


        public TestGeneProperty(double lala, decimal salario, string nombre)
        {
            this.lala = lala;
            this.salario = salario;
            this.nombre = nombre;
        }

        public double Lala
        {
            get { return lala; }
            set { lala = value; }
        }

        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
