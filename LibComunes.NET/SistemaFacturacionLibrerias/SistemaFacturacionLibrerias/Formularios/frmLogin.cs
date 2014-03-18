using SistemaFacturacionLibrerias.Clases;
using SistemaFacturacionLibrerias.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionLibrerias
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                txtUsuario.Focus();
                return;
            }

            if (txtClave.Text == "")
            {
                MessageBox.Show("Debe ingresar una clave");
                txtClave.Focus();
                return;
            }

            if(!Datos.ValidarUsurio(txtUsuario.Text, txtClave.Text))
            {
                MessageBox.Show(Datos.Mensaje);
                txtUsuario.Focus();
                return;
            }

            this.Hide();
            frmPrincipal f = new frmPrincipal();
            f.Show();
        }
    }
}
