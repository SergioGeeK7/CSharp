using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void consultaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaArticulos miForm = new FormConsultaArticulos();
            miForm.MdiParent = this;
            miForm.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
            //Application.Exit();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArticulos miForm = new FormArticulos();
            miForm.MdiParent = this;
            miForm.Show();
        }
    }
}
