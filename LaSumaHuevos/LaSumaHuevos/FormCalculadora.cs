using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaSumaHuevos
{
    public partial class FormCalculadora : Form
    {
        Calculos calculos = new Calculos();

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("9");
        }

        private void btntriplecero_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("000");
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text.IndexOf(".")==-1) // SI NO HAY NINGUN PUNTO
            {
                this.txtdisplay.Text = calculos.Concatenar(".");    
            }
            
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            this.txtdisplay.Text = calculos.Concatenar("0");
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            this.calculos.Suma(txtdisplay.Text);
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            this.calculos.Resta(txtdisplay.Text);
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            this.calculos.Multiplicacion(txtdisplay.Text);
        }

        private void btndivicion_Click(object sender, EventArgs e)
        {
            this.calculos.Division(txtdisplay.Text);
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = calculos.Resultado(txtdisplay.Text).ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            calculos.Clear();
            txtdisplay.Text = "0";
        }
    }
}
