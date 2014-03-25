using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLlenarGrids;

namespace SistemaFacturacion.Formularios
{
    public partial class FormBusquedaProductos : Form
    {

        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml"); // necesita el usuario
        private int idProducto;


        public FormBusquedaProductos()
        {
            InitializeComponent();
        }

        public int IdProducto
        {
            get { return idProducto; }
        }

        private void FormBusquedaProductos_Load(object sender, EventArgs e)
        {
            llenarGrids.SQL =
             "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Departamento.Descripcion AS " +
             "Departamento " +
            "FROM dbo.Departamento INNER JOIN " +
            "dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento " +
            "ORDER BY dbo.Producto.IDProducto";


            if (!llenarGrids.LlenarGridWindows(dgvdatagridproductos))
            {
                MessageBox.Show(llenarGrids.Error, "Error");

            }
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {

            if (rbtidproducto.Checked)
            {

                int num;
                try
                {
                    num = Convert.ToInt32(txtfiltro.Text);
                }
                catch (Exception ex)
                {
                    num = 0;
                }

                llenarGrids.SQL =
                "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Departamento.Descripcion AS " +
                "Departamento " +
                "FROM dbo.Departamento INNER JOIN " +
                "dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento " +
                "WHERE dbo.Producto.IDProducto >= '" + num + "'" +
                "ORDER BY dbo.Producto.IDProducto";
            }
            else
            {
                llenarGrids.SQL =
                "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Departamento.Descripcion AS " +
                "Departamento " +
                "FROM dbo.Departamento INNER JOIN " +
                "dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento " +
                "WHERE dbo.Producto.Descripcion LIKE '" + txtfiltro.Text + "%'" +
                "ORDER BY dbo.Producto.Descripcion";
            }
            llenarGrids.LlenarGridWindows(dgvdatagridproductos);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            idProducto = 0;
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (dgvdatagridproductos.SelectedRows.Count > 0)
            {
                idProducto = Convert.ToInt32(dgvdatagridproductos.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                idProducto = Convert.ToInt32(dgvdatagridproductos.Rows[0].Cells[0].Value); // toma por defecto el primer registro
            }
            this.Close();
        } 

        private void rbtidproducto_CheckedChanged(object sender, EventArgs e)
        {
            txtfiltro.Text = "";
            llenarGrids.SQL =
               "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Departamento.Descripcion AS " +
               "Departamento " +
               "FROM dbo.Departamento INNER JOIN " +
               "dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento "+
               "ORDER BY dbo.Producto.IDProducto";
            llenarGrids.LlenarGridWindows(dgvdatagridproductos);
        }

        private void rbtdescripcion_CheckedChanged(object sender, EventArgs e)
        {

            txtfiltro.Text = "";
            llenarGrids.SQL =
               "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Departamento.Descripcion AS " +
               "Departamento " +
               "FROM dbo.Departamento INNER JOIN " +
               "dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento " +
               "ORDER BY dbo.Producto.Descripcion";
            llenarGrids.LlenarGridWindows(dgvdatagridproductos);



        }
    }
}
