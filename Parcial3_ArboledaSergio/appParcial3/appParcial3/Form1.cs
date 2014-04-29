using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLancha;

namespace appParcial3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnsiguiente_Click(object sender, EventArgs e)
        {

            if (!Validar()) return;
            try
            {



                string nombre = txtnombre2.Text;
                string nombremotor = txtnombremotor.Text;
                int kilometroshora = Convert.ToInt32(txtkilometrosporhora2.Text);
                int recorreenhoras = Convert.ToInt32(txtrecorrerhoras.Text);

                Lancha milancha = new Lancha(nombre, kilometroshora, nombremotor);

                milancha.Save(recorreenhoras);
                txtnombre2.Text = string.Empty;
                txtnombremotor.Text = string.Empty;
                txtkilometrosporhora2.Text = string.Empty;
                txtrecorrerhoras.Text = string.Empty;

                txtnombre2.Focus();

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
           


            

        }

        private bool Validar()
        {
            if (String.IsNullOrEmpty(txtnombre2.Text))
            {
                MessageBox.Show("debe ingresar un nombre");
                this.txtnombre2.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(txtkilometrosporhora2.Text))
            {
                MessageBox.Show("debe ingresar cuantos kilometros corre por hora tu bote");
                this.txtkilometrosporhora.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(txtrecorrerhoras.Text))
            {
                MessageBox.Show("debe ingresar cuantos kilometros desea poner a navegar su bote");
                this.txtrecorrerhoras.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(txtnombremotor.Text))
            {
                MessageBox.Show("debe ingresar el nombre del motor");
                this.txtnombremotor.Focus();
                return false;
            }

            try
            {

                if (Convert.ToInt32(txtkilometrosporhora2.Text) < 0)
                {
                    MessageBox.Show("debe ingresar un numero de kilometros positivo");
                    this.txtkilometrosporhora2.Focus();
                    return false;
                }


                if (Convert.ToInt32(txtrecorrerhoras.Text) < 0)
                {
                    MessageBox.Show("debe ingresar cuantos kilometros desea navegar en positivo");
                    this.txtrecorrerhoras.Focus();
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return true;

        }
    }
}
