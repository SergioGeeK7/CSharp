using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLlenarCombos;
using LibLlenarGrids;
using SistemaFacturacion.Clases;

namespace SistemaFacturacion.Formularios
{
    public partial class FormArticulos : Form
    {
        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml"); // necesita el usuario

        LlenarCombos llenarCombos = new LlenarCombos("Parametros.xml");


        private int i=0;
        private bool nuevo;

        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {

            LlenarGrids();
            LlenarCombos();
            LlenarCampos();
            EstablecerPermisos();




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

        private void LlenarCombos()
        {
            // llenar combos departamentos
            
            llenarCombos.SQL = "select IDDepartamento,Descripcion " +
                              "from Departamento " +
                              "union " +
                              "select '', '[Todos]' order by 2";
            llenarCombos.CampoID = "IDDepartamento";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbdepartamento);


            // llenar combos ivas

            llenarCombos.SQL = "select IDIVA,Descripcion " +
                               "from IVA union " +
                               "select '', '[Todos]' order by 2";
            llenarCombos.CampoID = "IDIVA";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbiva);
        }

        private void LlenarGrids()
        {
            llenarGrids.SQL =
              "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock," +
              "dbo.Producto.IDIVA, dbo.IVA.Descripcion AS Iva,dbo.Producto.IDDepartamento, " +
              "dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas " +
              "FROM dbo.Producto INNER JOIN " +
              "dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
              "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento";


            if (!llenarGrids.LlenarGridWindows(dgvProductos))
            {
                MessageBox.Show(llenarGrids.Error, "Error");

            }
        }



        private void LlenarCampos()
        {
            if (dgvProductos.Rows.Count == 0) return;
                                           //1er registro //1er campo
            if (dgvProductos.Rows[i].Cells["IDProducto"].Value == null) return;

            txtidproducto.Text = dgvProductos.Rows[i].Cells["IDProducto"].Value.ToString(); // [0]primer registro [0] primer campo
            txtdescripcion.Text = dgvProductos.Rows[i].Cells["Descripcion"].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[i].Cells["Precio"].Value.ToString();
            txtStock.Text = dgvProductos.Rows[i].Cells["Stock"].Value.ToString();
            cmbdepartamento.SelectedValue = dgvProductos.Rows[i].Cells["IDDepartamento"].Value.ToString();
            cmbiva.SelectedValue = dgvProductos.Rows[i].Cells["IDIVA"].Value.ToString();
            txtNotas.Text = dgvProductos.Rows[i].Cells["Notas"].Value.ToString();
            





        }

        private void tsbsiguiente_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0) return;
            if (i == dgvProductos.Rows.Count)
            {
                MessageBox.Show("Ha llegado al ultimo registro");
                return;
            }
            this.i++;
            LlenarCampos();
        }

        private void tsbanterior_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0) return;
            if (i == -1)
            {
                i = 0;
                return;
            }
            this.i--;
            LlenarCampos();

        }

        private void tsbprimero_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0) return;
            i = 0;
            LlenarCampos();


        }

        private void tsbultimo_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0) return;
            i = dgvProductos.Rows.Count-2;
            LlenarCampos();

        }

        private void tsbmodificar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            HabilitarEdicion();
          


        }

        private void HabilitarEdicion()
        {
            tsbprimero.Enabled = false;
            tsbanterior.Enabled = false;
            tsbsiguiente.Enabled = false;
            tsbultimo.Enabled = false;
            tsbnuevo.Enabled = false;
            tsbmodificar.Enabled = false;
            tsbguardar.Enabled = true;
            tsbcancelar.Enabled = true;
            tsbeliminar.Enabled = false;
            tsbbuscar.Enabled = false;



            txtdescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            cmbdepartamento.Enabled = true;
            cmbiva.Enabled = true;
            txtNotas.Enabled = true;

            txtdescripcion.Focus();


        }

        private void tsbcancelar_Click(object sender, EventArgs e)
        {
            DesabiligarEdicion();
            LlenarCampos();
        }

        private void DesabiligarEdicion()
        {
            tsbprimero.Enabled = true;
            tsbanterior.Enabled = true;
            tsbsiguiente.Enabled = true;
            tsbultimo.Enabled = true;
            tsbnuevo.Enabled = true;
            tsbmodificar.Enabled = true;
            tsbguardar.Enabled = false;
            tsbcancelar.Enabled = false;
            tsbeliminar.Enabled = true;
            tsbbuscar.Enabled = true;



            txtdescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            cmbdepartamento.Enabled =false;
            cmbiva.Enabled = false;
            txtNotas.Enabled = false;
            



        }

        private void tsbnuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            BlanquearCampos();
            HabilitarEdicion();

        }

        private void BlanquearCampos()
        {
            txtidproducto.Text = "";
            txtdescripcion.Text="";
            txtPrecio.Text="";
            txtStock.Text="";
            cmbdepartamento.SelectedIndex = 0;
            cmbiva.SelectedIndex = 0;
            txtNotas.Text = "";



        }

        private void tsbguardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return;

            Producto producto = new Producto();

            try
            {
                producto.IdProducto = Convert.ToInt32(txtidproducto.Text);
            }
            catch (Exception ex)
            {
                producto.IdProducto = 0;

            }
            producto.Descipcion = txtdescripcion.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Stock = Convert.ToInt32(txtStock.Text);
            producto.Notas = txtNotas.Text;
            producto.IdDepartamento = Convert.ToInt32(cmbdepartamento.SelectedValue);
            producto.Idiva = Convert.ToInt32(cmbiva.SelectedValue);

            if (nuevo)
            {
                if (!Datos.ProductoNuevo(producto))
                {
                    MessageBox.Show(Datos.Mensaje, "Error");
                    return;
                }
            }
            else
            {

                if (!Datos.ActualizarProducto(producto))
                {
                    MessageBox.Show(Datos.Mensaje, "Error");
                    return;
                }

            }

            MessageBox.Show(Datos.Mensaje, "Confirmacion");
            LlenarGrids();
            DesabiligarEdicion();

            if(nuevo)tsbultimo_Click(sender,e);
            else LlenarCampos();


        }

        private bool validarCampos()
        {
            if (txtdepartamento.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripcion","error");
                txtdescripcion.Focus();
                return false;
            }

            if (txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un precio", "error");
                txtPrecio.Focus();
                return false;
            }

            // heredar el campo texto y decirle que solo sea texto numerico

            if (!Utilidades.ValidarDecimal(txtPrecio.Text))
            {
                MessageBox.Show(Utilidades.Error, "error");
                txtPrecio.Text = "";
                txtPrecio.Focus();
                return false;
            }

            if (Utilidades.NumeroDecimal < 0)
            {
                MessageBox.Show("Debe ingresar un valor positivo", "error");
                txtPrecio.Focus();
                return false; 
            }


            if (txtStock.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un stock para el producto", "error");
                txtStock.Focus();
                return false;
            }

            // heredar el campo texto y decirle que solo sea texto numerico

            if (!Utilidades.ValidarDecimal(txtPrecio.Text))
            {
                MessageBox.Show(Utilidades.Error, "error");
                txtStock.Text = "";
                txtStock.Focus();
                return false;
            }

            if (Utilidades.NumeroEntero < 0)
            {
                MessageBox.Show("Debe ingresar un valor positivo", "error");
                txtStock.Focus();
                return false;
            }

            if (cmbdepartamento.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un departamento", "error");
                cmbdepartamento.Focus();
                return false;
            }
            if (cmbiva.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un iva", "error");
                cmbiva.Focus();
                return false;
            }

            return true;
        }

        private void tsbeliminar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Esta segudo de borrar el registro actual",
                "Confirmacion", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.No) return;
            if (!Datos.EliminarProducto(Convert.ToInt32(txtidproducto.Text)))
            {
                MessageBox.Show(Datos.Mensaje, "Error");
                return;
            }

            MessageBox.Show(Datos.Mensaje, "Confirmacion");
            LlenarGrids();
            LlenarCampos();
            //tsbprimero_Click(sender,e);

        }

        private void tsbbuscar_Click_1(object sender, EventArgs e)
        {
            FormBusquedaProductos miBusqueda = new FormBusquedaProductos();

            miBusqueda.ShowDialog(); // no me permite llenar otra cosa
           // MessageBox.Show("El usuario busco " + miBusqueda.IdProducto);

            for (i = 0; i < dgvProductos.Rows.Count; i++)
            {
                if (miBusqueda.IdProducto == Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value)) break;
            }
            LlenarCampos();

        }


        private Usuario usuarioLogeado;



        internal Usuario UsuarioLogeado
        {
            get { return usuarioLogeado; }
            set { usuarioLogeado = value; }
        }









    }
}
