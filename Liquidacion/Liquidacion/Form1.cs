using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liquidacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool Validar()
        {

            if (string.IsNullOrEmpty(textBox2.Text.Trim())) {
                MessageBox.Show("Error ingrese codigo");
                return false;
            }
             if (string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                MessageBox.Show("Error ingrese codigo");
                return false;
            }
             if (string.IsNullOrEmpty(textBox4.Text.Trim()))
            {
                MessageBox.Show("Error ingrese codigo");
                return false;
            }
             if (string.IsNullOrEmpty(textBox5.Text.Trim()))
            {
                MessageBox.Show("Error ingrese codigo");
                return false;
            }
             if (string.IsNullOrEmpty(textBox6.Text.Trim()))
             {
                 MessageBox.Show("Error ingrese codigo");
                 return false;
             }
             if (string.IsNullOrEmpty(textBox1.Text.Trim()))
             {
                 MessageBox.Show("Error ingrese codigo");
                 return false;
             }




            return true;

        }
            





        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            try
            {
                string codigo = textBox2.Text;
                string nombre = textBox1.Text;
                int nhijos = Convert.ToInt32(textBox3.Text);
                int nhijos18 = Convert.ToInt32(textBox5.Text);
                double vrHora = Convert.ToDouble(textBox4.Text);
                int nhoras = Convert.ToInt32(textBox6.Text);

                // crear objeto y validar


            }
            catch (Exception ex)
            {
                
                throw;
            }




        }
    }
}
