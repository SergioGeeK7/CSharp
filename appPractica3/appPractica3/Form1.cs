using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFiguras;
namespace appPractica3
{
    public partial class frmHerencia : Form
    {
        double dblDato1, dblDato2;

        #region "variables globales"

        double dblArea, dblPerim, dblLado;
        double dblLadoA, dblLadoB, dblLadoC;


        #endregion




        public frmHerencia()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtradio.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtPerimetro.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtradio.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtPerimetro.Text = string.Empty;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcularcircu_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularTriang_Click(object sender, EventArgs e)
        {


            try
            {

                dblLadoA= Convert.ToDouble(txtLadoA.Text);
                dblLadoB = Convert.ToDouble(txtLadoB.Text);
                dblLadoC = Convert.ToDouble(txtLadoC.Text);

                clsTriangulo obj = new clsTriangulo(dblLadoA, dblLadoB, dblLadoC);

                if (!obj.HallarArea() || !obj.HallarPerimetro())
                {
                    MessageBox.Show(obj.Error,"Alerta");
                    this.txtLadoA.Focus();
                    return;
                }

                dblArea = obj.Area;
                dblPerim = obj.Perimetro;

                // cadenas con formato strig microsoft

                txtArea.Text = dblArea.ToString("F");
                txtPerimetro.Text = dblPerim.ToString("F");

              //MessageBox.Show("hellow","alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }


        }
    }
}
