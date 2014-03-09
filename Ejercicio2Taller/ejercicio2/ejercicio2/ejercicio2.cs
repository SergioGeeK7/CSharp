using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;


using libEjercicio2;
namespace ejercicio2
{
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
            txtSalario.Text = "hellow";
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private double dblSalarioActual, dblAños;
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtSalario.Text = string.Empty;
            this.txtAñosW.Text = string.Empty;
            this.txtMontoAumen.Text = string.Empty;
            this.txtPctAumento.Text = string.Empty;
        }
       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                dblAños =Convert.ToDouble( this.txtAñosW.Text.Trim());
                dblSalarioActual = Convert.ToDouble(this.txtSalario.Text.Trim());
                clsEjercicio2 objxx = new clsEjercicio2();
                objxx.Antiguedad = dblAños;
                objxx.SalarioActual = dblSalarioActual;
                if (!objxx.Calcular())
                {
                    MessageBox.Show(objxx.Error);
                    return;
                }
                this.txtPctAumento.Text = objxx.Porcentaje.ToString() ;
                this.txtMontoAumen.Text = objxx.MontoAumento.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ejercicio2_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");

            CultureInfo Objeto = System.Threading.Thread.CurrentThread.CurrentCulture;

            Objeto.NumberFormat.NumberDecimalSeparator = ".";
            Objeto.NumberFormat.NumberGroupSeparator = ",";
        }
    }
}
