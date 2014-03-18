using LibParametros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLibParametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // libparametros nombre del name space
            // .Parametros el nombre de la clase

            Parametros parametros = new Parametros();
            if (parametros.GenerarCadenaConexion("Parametros.xml")) {
                MessageBox.Show(parametros.CadenaConexion);
            }else{
                MessageBox.Show(parametros.Error);
            }
        }
    }
}
