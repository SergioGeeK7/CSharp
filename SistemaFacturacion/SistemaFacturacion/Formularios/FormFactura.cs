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
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.DetalleFacturaTmpConValor' Puede moverla o quitarla según sea necesario.
            ActualizarTotales();
            //this.detalleFacturaTmpConValorTableAdapter.Fill(this.facturacionDataSet.DetalleFacturaTmpConValor);
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.facturacionDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.ClienteNombresFull' Puede moverla o quitarla según sea necesario.
            this.clienteNombresFullTableAdapter.Fill(this.facturacionDataSet.ClienteNombresFull);

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (!ValidarAdicion()) return;

            Producto miProducto = Producto.GetProducto((int) cmbproducto.SelectedValue);
            DetalleFacturaTmp.NuevoDetalleFacturaTmp(miProducto.IdProducto,
                miProducto.Descipcion,miProducto.Precio,Convert.ToInt32(txtcantidad.Text));

            ActualizarTotales();

        }

        private void ActualizarTotales()
        {
            this.detalleFacturaTmpConValorTableAdapter.Fill(this.facturacionDataSet.DetalleFacturaTmpConValor);
            txttotalcantidad.Text = DetalleFacturaTmp.SumaCantidad().ToString("N0");
            txttotalvalor.Text = DetalleFacturaTmp.SumaValor().ToString("C2");
            // C2 FORMATO CURRENCI MONEY

            //1. Cree la consulta en el dataset
            //2. create el metodo
            //3. usalo en el formulario




        }

        private bool ValidarAdicion()
        {
            if (txtcantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad", "Error");
                txtcantidad.Focus();
                return false;
            }

            if (!Utilidades.ValidarEntero(txtcantidad.Text))
            {
                MessageBox.Show("Debe ingresar un valor numerico entero en cantidad", "Error");
                txtcantidad.Text = "";
                txtcantidad.Focus();
                return false;
            }

            if (Utilidades.NumeroEntero < 1)
            {
                MessageBox.Show("Debe ingresar un valor mayor a cero", "Error");
                txtcantidad.Text = "";
                txtcantidad.Focus();
                return false;
            }

            return true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
