using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libPractica2;
using System.Globalization;
namespace appPractica2
{
    public partial class Form1 : Form
    {


        #region "Variables globales"

        int intTipoEmp; //1:Sobre, 2 :Caja
        int intTipoServ; // 1:Priori 2:stand , 3:>dias
        double dblPesoTotal, dblVrBas, dblVrAdic, dblXPesoBas, dblXPesoAdic;
        double dblSubTotal, dblDscto, dblIVA, dblAPagar;
        double dblVrUss;
        double dblXPesBas;
        double dblPesoAdic=0;

        #endregion

        //20 kilos == 44o43 libras

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string strX;
            try
            {
                dblVrAdic = 0;
                dblXPesoAdic = 0;
                dblDscto = 0;
                if (intTipoEmp == 0)
                {
                    MessageBox.Show("Porfavor seleccione tipo de empaque");
                    this.comboBox1.Focus();
                    return;
                }

                dblPesoTotal = Formato(this.textBox1.Text.Trim());
                clsPractica2 obj = new clsPractica2();
                if (!obj.ObtenerDatos())
                {
                    MessageBox.Show(obj.Error);
                    obj = null;
                    return;
                }
                if (intTipoEmp == 1)// carta
                {
                    if (dblPesoTotal > 8.0 * 32.0) // gramos
                    {
                        MessageBox.Show("Peso no permitido en carta");
                        this.textBox1.Focus();
                        return;
                    }
                    if (intTipoServ == 1) // Prioridad
                        dblSubTotal = obj.VrCaja1; // Obtener el valor en dolares
                    else dblSubTotal = obj.VrCartaTarifa2;
                }
                else // caja
                {
                    dblXPesBas = 1;

                    if (dblPesoTotal > (1000.0 / 2.2)) // peso en libras 1 KILO 2.2libras
                    {// libra o fraccion adicional se cobra como 1 libra mas
                        dblPesoAdic = Math.Ceiling((dblPesoTotal - 1000.0 / 2.2) / (1000.0 / 2.2));

                        // en libras
                        // Math.floor , Math.ceiling
                        // quedan los decimales restantes
                        // 545.46/444.54==1.2
                    }

                    if (intTipoServ == 1)
                    {// Prioridad
                        //dblSubTotal = obj.VrCaja1;  // Obtener el valor en dolares
                        dblVrBas = obj.VrCaja1;
                        dblVrAdic = obj.VrCaja1_Adic;
                    }
                    else if (intTipoServ == 2)
                    { // estandar 
                        dblVrBas = obj.VrCaja2;
                        dblVrAdic = obj.VrCaja2_Adic;
                    }
                    else
                    {
                        dblVrBas = obj.VrCaja3;
                        dblVrAdic = obj.VrCaja3_Adic;
                    }
                    dblSubTotal = dblVrBas + (dblPesoAdic * dblVrAdic);

                    // el peso esta en gramos
                    // 50 multiplicado por el valor de una libra
                    if (dblPesoTotal >= (25.0 * 1000.0 / 2.2) && dblPesoTotal <= (50.0 * 1000.0 / 2.2))
                    {
                        dblDscto = 0.035;
                    }
                    else if (dblPesoTotal > (50.0 * 1000.0 / 2.2))
                    {
                        dblDscto = 0.085;
                    }

                    dblSubTotal *= obj.VrDolar; // pesos colombianos
                    dblDscto *= dblSubTotal;
                    dblIVA = (dblSubTotal - dblDscto) * 0.025;
                    dblAPagar = dblSubTotal - dblDscto + dblIVA;
                    obj = null;


                    this.txtsubtotal.Text = dblSubTotal.ToString();
                    this.txtdacto.Text = dblDscto.ToString();
                    this.txtiva.Text = dblIVA.ToString();
                    this.txtapagar.Text = dblAPagar.ToString();
                    this.groupBox2.Visible = true;


                }
            } // try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Seleccione un empaque");
            this.comboBox1.Items.Add("Carta"); // index 1
            this.comboBox1.Items.Add("Caja");   // index 2
            this.comboBox1.SelectedIndex = 0;
            this.intTipoEmp = 0;
            intTipoServ = 1;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            intTipoServ = 1;
            groupBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            intTipoServ = 2;
            groupBox2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            intTipoServ = 3;
            groupBox2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            intTipoEmp = 0;
            if (comboBox1.SelectedIndex == 1)
            {
                intTipoEmp = 1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                intTipoEmp = 2;
            }


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            this.radioButton1.Checked = true;
            this.textBox1.Text = string.Empty;
            this.comboBox1.Focus();

        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double Formato(string xx)
        {

            return Convert.ToDouble(xx.Replace(NumberFormatInfo.CurrentInfo.CurrencyGroupSeparator,
                    NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator));

        }



    }
}
