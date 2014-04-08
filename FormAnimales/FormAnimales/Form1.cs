using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animales;
namespace FormAnimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        string error;
        

        private void btnsiguiente_Click(object sender, EventArgs e)
        {

            if (!Validar()) return;

            try
            {
               
                Animal animal;
                

                if (chbperro.Checked) animal = new Perro(txtnombre.Text, Convert.ToInt32(txtanos.Text), "M");
                else if (chbpaloma.Checked) animal = new Paloma(txtnombre.Text, Convert.ToInt32(txtanos.Text), "F");
                else if (chbgato.Checked) animal = new Gato(txtnombre.Text, Convert.ToInt32(txtanos.Text), "F");
                else animal = new Aguila(txtnombre.Text, Convert.ToInt32(txtanos.Text), "M");


                using (StreamWriter w = File.AppendText("log.txt"))
                {
                    w.Write(animal + "\n");
                }



              

                txtnombre.Text = "";
                txtanos.Text = "";
                txtnombre.Focus();


            }
            catch (Exception ex)
            {
                error = ex.Message;
                MessageBox.Show(error);
            }


        }

        private bool Validar()
        {

            if (String.IsNullOrEmpty(txtnombre.Text))
            {
                error = "debe ingresar nombre";
                MessageBox.Show(error);
                txtnombre.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtanos.Text))
            {
                error = "debe ingresar numero de anos";
                MessageBox.Show(error);
                txtnombre.Focus();
                return false;
            }

            try
            {

                if (Convert.ToInt32(txtanos.Text) < 0)
                {
                       error = "debe ingresar un numero de anos positivo";
                       MessageBox.Show(error);
                       txtnombre.Focus();
                       return false;

                }


            }
            catch (Exception ex)
            {
                 error = ex.Message;
            }

            return true;

        }
    }
}
