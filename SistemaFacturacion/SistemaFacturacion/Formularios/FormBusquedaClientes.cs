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
    public partial class FormBusquedaClientes : Form
    {

        private string idCliente;

        

        public FormBusquedaClientes()
        {
            InitializeComponent();
        }

        public string IdCliente
        {
            get { return idCliente; }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            idCliente = "";
            //this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            if (dgvdatagridproductos.SelectedRows.Count > 0)
            {
                idCliente = dgvdatagridproductos.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                idCliente = dgvdatagridproductos.Rows[0].Cells[0].Value.ToString(); // toma por defecto el primer registro
            }
            this.Close();
        }

        private void FormBusquedaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.facturacionDataSet.Cliente);




        }

        private void fillByIDClienteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillByIDCliente(this.facturacionDataSet.Cliente, iDClienteToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNombresToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillByNombres(this.facturacionDataSet.Cliente, nombresToolStripTextBox.Text+"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByApellidosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillByApellidos(this.facturacionDataSet.Cliente, apellidosToolStripTextBox.Text+"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.facturacionDataSet.Cliente);
        }
    }
}
