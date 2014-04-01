using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFacturacion.Clases;

namespace SistemaFacturacion.Formularios
{
    public partial class FormPrincipal : Form
    {
        private Usuario usuarioLogeado;

      
         
        internal Usuario UsuarioLogeado
        {
            get { return usuarioLogeado; }
            set { usuarioLogeado = value; }
        }


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
            miForm.UsuarioLogeado = usuarioLogeado;
            miForm.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            tssusuario.Text = usuarioLogeado.Nombres + " " + usuarioLogeado.Apellidos;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormClientes miForm = new FormClientes();
            miForm.MdiParent = this;
            miForm.UsuarioLogeado = usuarioLogeado;
            miForm.Show();

        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactura miForm = new FormFactura();
            miForm.MdiParent = this;
            
            miForm.Show();
        }
    }
}
