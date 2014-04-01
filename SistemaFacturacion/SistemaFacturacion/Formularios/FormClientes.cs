using SistemaFacturacion.Clases;
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
    public partial class FormClientes : Form
    {
        private bool nuevo = false;
        private int posicion;


        private Usuario usuarioLogeado;



        internal Usuario UsuarioLogeado
        {
            get { return usuarioLogeado; }
            set { usuarioLogeado = value; }
        }



        private void EstablecerPermisos()
        {
            if (UsuarioLogeado.IdPerfil != 1)
            {
                tsbnuevo.Enabled = false;
                tsbmodificar.Enabled = false;
                tsbeliminar.Enabled = false;
            }
        }




        public FormClientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facturacionDataSet);

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.facturacionDataSet.Cliente);
            EstablecerPermisos();
        }

        private void tsbnuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            BlanquearCampos();
            HabilitarEdision();
            iDClienteTextBox.Enabled = true;
            iDClienteTextBox.Focus();
        }

        private void HabilitarEdision()
        {

            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;

            tsbnuevo.Enabled = false;
            tsbguardar.Enabled = true;
            tsbcancelar.Enabled = true;
            tsbeliminar.Enabled = false;
            tsbmodificar.Enabled = false;
            tsbbuscar.Enabled = false;


            nombresTextBox.Enabled=true;
            apellidosTextBox.Enabled=true;
            direccionTextBox.Enabled=true;
            telefonoTextBox.Enabled=true;
            correoTextBox.Enabled=true;
            fechaNacimientoDateTimePicker.Enabled=true;
            cupoTextBox.Enabled=true;
            


        }

        private void BlanquearCampos()
        {
            iDClienteTextBox.Text = "";
            nombresTextBox.Text = "";
            apellidosTextBox.Text = "";
            direccionTextBox.Text = "";
            telefonoTextBox.Text = "";
            correoTextBox.Text = "";
            fechaNacimientoDateTimePicker.Text = "";
            cupoTextBox.Text = "";
        }

        private void tsbmodificar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            posicion = clienteBindingSource.Position;
  // binding enganchaos de alguna forma, selecciono un campo en la tabla y lo llena en el texbox
            HabilitarEdision();
            nombresTextBox.Focus();
        }

        private void tsbcancelar_Click(object sender, EventArgs e)
        {
            DehabilitarCampos();
            ActualizarFormulario();
        }

        private void ActualizarFormulario()
        {
            this.clienteTableAdapter.Fill(this.facturacionDataSet.Cliente);
        }

        private void DehabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;

            tsbnuevo.Enabled = true;
            tsbguardar.Enabled = false;
            tsbcancelar.Enabled = false;
            tsbeliminar.Enabled = true;
            tsbmodificar.Enabled = true;
            tsbbuscar.Enabled = true;

            iDClienteTextBox.Enabled = false;
            nombresTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            correoTextBox.Enabled = false;
            fechaNacimientoDateTimePicker.Enabled = false;
            cupoTextBox.Enabled = false;
            

        }

        private void tsbguardar_Click(object sender, EventArgs e)
        {
            // HIBRIDO semi automatico, y pedaliar cositas

            if (!Validar()) return;

            if(nuevo)Cliente.NuevoCliente(iDClienteTextBox.Text,nombresTextBox.Text,
                apellidosTextBox.Text,direccionTextBox.Text,telefonoTextBox.Text,
                correoTextBox.Text,fechaNacimientoDateTimePicker.Text,Utilidades.NumeroEntero);
            else Cliente.ActualizarCliente(iDClienteTextBox.Text, nombresTextBox.Text,
                apellidosTextBox.Text, direccionTextBox.Text, telefonoTextBox.Text,
                correoTextBox.Text, fechaNacimientoDateTimePicker.Text, Utilidades.NumeroEntero);

            MessageBox.Show("Cambios realizados con exito", "Confirmacion");
            DehabilitarCampos();
            ActualizarFormulario();
            if (!nuevo)
                clienteBindingSource.Position = posicion;
            
        }

        private bool Validar()
        {

            if (iDClienteTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un id", "error");
                iDClienteTextBox.Focus();
                return false;
            }

            if (nuevo && Cliente.ExisteCliente(iDClienteTextBox.Text))
            {
    // capa de presentacion no se mete con Querys nada simplemente la esta llamando
                MessageBox.Show("Ya existe un cliente con esa id", "error");
                iDClienteTextBox.Text = "";
                iDClienteTextBox.Focus();
                return false;
            }


            
            if (nombresTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar nombres", "error");
                nombresTextBox.Focus();
                return false;
            }

            if (apellidosTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar apellidos ", "error");
                apellidosTextBox.Focus();
                return false;
            }

            if (cupoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un cupo", "error");
                cupoTextBox.Focus();
                return false;
            }


            // heredar el campo texto y decirle que solo sea texto numerico
            //cuadro de texto heredado, cuadro de texto heredado pa solo numeros.... 

            if (!Utilidades.ValidarEntero(cupoTextBox.Text))
            {
                MessageBox.Show(Utilidades.Error, "error");
                cupoTextBox.Text = "";
                cupoTextBox.Focus();
                return false;
            }

            if (Utilidades.NumeroEntero < 0)
            {
                MessageBox.Show("Debe ingresar un valor positivo", "error");
                cupoTextBox.Focus();
                return false;
            }

            return true;


        }

        private void tsbeliminar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Esta segudo de borrar el registro actual",
                "Confirmacion", MessageBoxButtons.YesNo);
            Cliente.EliminarCliente(iDClienteTextBox.Text);
            if (respuesta == DialogResult.No) return;
            MessageBox.Show("Registro borrado correctamente", "confirmacion");
            ActualizarFormulario();


        }

        private void tsbbuscar_Click(object sender, EventArgs e)
        {
            FormBusquedaClientes miBusqueda = new FormBusquedaClientes();

            // showdialog para que quede en forma modal
            miBusqueda.ShowDialog(); // no me permite llenar otra cosa
            // MessageBox.Show("El usuario busco " + miBusqueda.IdProducto);

            if (miBusqueda.IdCliente == "") return;

            clienteBindingSource.Position = clienteBindingSource.Find("IDCliente", miBusqueda.IdCliente);



        }
    }
}
