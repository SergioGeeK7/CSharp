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


using LibParcial1;

namespace AppParcial1
{
    public partial class AppParcial1 : Form
    {
        public AppParcial1()
        {
            InitializeComponent();
        }

        #region " variables globales"

        Clparcial1 objXX;
        double dblventa;
        int tipoventa=1;

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AppParcial1_Load(object sender, EventArgs e)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");

            CultureInfo Objeto = System.Threading.Thread.CurrentThread.CurrentCulture;

            Objeto.NumberFormat.NumberDecimalSeparator = ".";
            Objeto.NumberFormat.NumberGroupSeparator = ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objXX = new Clparcial1();

            this.btnEmpezar.Visible = false;
            this.gbdatos.Visible = true;
            this.btLimpiar.Visible = true;
            this.btProcesos.Visible = true;
            this.btnReiniciar.Visible = true;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        { 
        this.txtCod.Clear();
            this.txtCod.Focus();
            this.txtVentC1.Clear();
            this.txtVenCOnt1.Clear();
            this.txtVenta2.Clear();
            this.txtVenCont2.Clear();
            this.txtvalorventa.Clear();
        
        }

        private void button5_Click(object sender, EventArgs e)
        {


            try
                {



                    if (this.txtvalorventa.Text.Trim() != "*")
                    {


                        int codigoalmacen = Convert.ToInt32(this.txtCod.Text.Trim());
                        dblventa = Convert.ToDouble(this.txtvalorventa.Text.Trim());


                        objXX.VlrVenta = dblventa;
                        objXX.TipoVenta = tipoventa;
                        objXX.Codigo = codigoalmacen;


                        if (!objXX.Calcular())
                        {
                            MessageBox.Show(objXX.Error1);
                            return;

                        }

                        limpiar();


                    }
                    else {

                        txtVentC1.Text = objXX.TotalVentaCredito1.ToString();
                        txtVenCOnt1.Text = objXX.TotalVentaContado1.ToString();
                        txtVenta2.Text = objXX.TotalVentaCredito2.ToString();
                        txtVenCont2.Text = objXX.DTotalVentaContado2.ToString();
                        gbalmacen1.Visible = true;
                        gbalmacen2.Visible = true;
                    }

                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            tipoventa = 1;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipoventa = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.btnEmpezar.Visible = true;
            this.gbdatos.Visible = false;
            this.gbalmacen1.Visible = false;
            this.gbalmacen2.Visible = false;
            this.btnEmpezar.Visible = true;
            this.btnReiniciar.Visible = false;
        }
    }
}
