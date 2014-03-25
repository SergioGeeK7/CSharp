using SistemaFacturacion.Clases; // esta en la carpeta clases ... desde el namespace... directorio de trabajo del proyecto
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFacturacion.Formularios; // como el package de java

namespace SistemaFacturacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text =="")
            {
                MessageBox.Show("Debe Ingresar un usuario","Errror");
                txtusuario.Focus();
                return;
            }
            if (txtclave.Text == "")
            {
                MessageBox.Show("Debe Ingresar una clave", "Errror");
                txtclave.Focus();
                return;
            }

            // el ELSE no se usa para eso tenemos el return
            if (!Datos.ValidarUsuario(txtusuario.Text, txtclave.Text))
            {
               
                txtusuario.Focus();
                MessageBox.Show(Datos.Mensaje, "Error");
                return;
            }

            // MessageBox.Show("Fuck yeah.......","You Get It");

            Usuario usuarioLogeado = Datos.GetUsuario(txtusuario.Text); 
            // getUsuario busca en la base de datos el usuario y lo convierte en un objeto usuario

            FormPrincipal miPrincipal = new FormPrincipal();
            this.Hide(); // no puedo cerrarlo porque es el que tiene el hilo de ejecucion
            miPrincipal.UsuarioLogeado = usuarioLogeado; // para saber quien es el usuario actual
            miPrincipal.Show();

            



        }
    }
}
