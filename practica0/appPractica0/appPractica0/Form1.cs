using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// una libreria es un monton de clases. abstractas o que necesitan
// hacer objeto para utilizarlas
// todo ese codigo ya esta en el proyecto todas las librerias

using libfigura;

namespace appPractica0
{
    public partial class Form1 : Form
    {   


        public Form1()
        {
            InitializeComponent();
        }
        #region "Variables Glovales"

        int intTipoFig = 1;


        #endregion


        private void rdbrect_CheckedChanged(object sender, EventArgs e)
        {
            this.intTipoFig = 2;
            this.lbltexto.Text = "Valor lado 1";
            this.txtlado2.Text = string.Empty;
            this.PnlDatos.Visible = true;
            this.txtlado1.Focus();
        }

        private void rdbcuad_CheckedChanged(object sender, EventArgs e)
        {
            this.intTipoFig = 1;
            this.lbltexto.Text = "Valor del lado";
            this.txtlado2.Text = string.Empty;
            this.PnlDatos.Visible = false;
            this.txtlado1.Focus();
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            // control J muestra la ayuda
            // Border style Border3DSide 
            // textaling donde hubicar el texto 

            this.rdbcuad.Checked = true;
            this.txtarea.Text = string.Empty;
            this.txtperimetro.Text = string.Empty;
            this.txtlado1.Text = string.Empty;
            this.txtlado2.Text = string.Empty;
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            double l1, l2 = 0;


            try
            {
                l1 = Convert.ToDouble(this.txtlado1.Text);

                if (intTipoFig == 2)
                {
                    l2 = Convert.ToDouble(this.txtlado1.Text);


                }
                    // instanciar la clase

                    CLSFigura ob = new CLSFigura();

                    // envio de parametros

                    ob.TipoFigura = intTipoFig;
                    ob.Lado1 = l1;
                    ob.Lado2 = l2;

                    // invocar el metodo del objeto

                    if (!ob.procesar())
                    {
                        MessageBox.Show(ob.Error);
                        ob = null;
                        return;
                    }
                    this.txtarea.Text = Convert.ToString(ob.Area);
                    this.txtperimetro.Text = ob.Perimetro.ToString();

                    ob = null;
                
                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }




        }
    }
}
