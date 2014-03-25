using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hipica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtstart_Click(object sender, EventArgs e)
        {
            //// - el ancho de uno de los caballos
            //int meta = this.Width - caballo1.Width - 18; 

            //for (int i = 0; i < this.Width - caballo1.Width - 18; i++)
            //{
            //    caballo1.Left = i;
            //    Thread.Sleep(10); //50 milisegundos 
            //}

            //*********************************************************

            // - el ancho de uno de los caballos

            caballo1.BackColor = Color.Transparent;

            int meta = this.Width - caballo1.Width - 30;
            bool c1 = false, c2 = false, c3 = false, c4 = false, c5 = false;
            Random rd = new Random();
            while (!c1 && !c2 && !c3 && !c4 && !c5)
            {
                caballo1.Left += rd.Next(10);
                caballo2.Left += rd.Next(10);
                caballo3.Left += rd.Next(10);
                caballo4.Left += rd.Next(10);
                caballo5.Left += rd.Next(10);
                c1 = caballo1.Left >= meta;
                c2 = caballo2.Left >= meta;
                c3 = caballo3.Left >= meta;
                c4 = caballo4.Left >= meta;
                c5 = caballo5.Left >= meta;

                Thread.Sleep(7);

            }

            if (c1) MessageBox.Show("Gano caballo 1");
            else if (c2) MessageBox.Show("Gano caballo 2");
            else if (c3) MessageBox.Show("Gano caballo 3");
            else if (c4) MessageBox.Show("Gano caballo 4");
            else MessageBox.Show("Gano caballo 5");






        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            caballo1.Left = 0;
            caballo2.Left = 0;
            caballo3.Left = 0;
            caballo4.Left = 0;
            caballo5.Left = 0;
        }
    }
}
