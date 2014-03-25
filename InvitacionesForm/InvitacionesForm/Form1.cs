using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libInvitaciones;

namespace InvitacionesForm
{
    public partial class Form1 : Form
    {

        Class1 obj = new Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void rbtsivoy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtsivoy.Checked) groupBox1.Visible = true;
        }

        private void rbtnovoy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnovoy.Checked) groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            obj.TotalInvitaciones++;
            groupBox1.Visible = false;


            if (rbtnovoy.Checked)
            {
                Limpiar();
                return;
            }



            if (string.IsNullOrEmpty(txtedad.Text.Trim()))
            {
                MessageBox.Show("Porfavor digite la edad");
                return;
            }
            if (string.IsNullOrEmpty(txtnombre.Text.Trim()))
            {
                MessageBox.Show("Porfavor digite el nombre");
                return;
            }





            try
            {

                double promedioEdadAcompanantes = 0.0;
                int numeroAcompanantes = 0;
                int edad = Convert.ToInt32(txtedad.Text.Trim());

                if (!string.IsNullOrEmpty(txtna.Text.Trim()))
                {
                    promedioEdadAcompanantes = Convert.ToDouble(txtpromedioedades.Text.Trim());
                    numeroAcompanantes = Convert.ToInt32(txtna.Text.Trim());
                }

                

                obj.Edad = edad;
                obj.Nacompanantes = numeroAcompanantes;
                obj.PromedioEdadAcompanantes = promedioEdadAcompanantes;

                if (!obj.Calcular())
                    MessageBox.Show(obj.StrError);
                Limpiar();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }





        }


        private void Limpiar()
        {
            txtedad.Text = "";
            txtnombre.Text = "";
            txtnombre.Focus();
            txtna.Text = "";
            txtpromedioedades.Text = "";
            rbtnovoy.Checked = true;
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {

            if (!obj.LeerArchivo())
                MessageBox.Show(obj.StrError);
            


            textBox2.Text = obj.TotalAcompanantes.ToString();
            textBox3.Text = obj.TotalAmigos.ToString();
            textBox4.Text = obj.PromedioEdadesTotales().ToString();
            textBox5.Text = obj.ValorAmigos().ToString();
            textBox6.Text = obj.ValorAcompanantes().ToString();
            textBox7.Text = obj.TotalAsistentes.ToString();
            textBox1.Text = obj.TotalInvitaciones.ToString();
            

            groupBox2.Visible = true;



        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = false;

            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox1.Text = string.Empty;
            Limpiar();



            obj = new Class1(); 
        }

    }
}
