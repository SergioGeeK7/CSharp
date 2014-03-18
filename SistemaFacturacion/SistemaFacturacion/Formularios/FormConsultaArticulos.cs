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
using LibLlenarCombos;

namespace SistemaFacturacion.Formularios
{
    public partial class FormConsultaArticulos : Form
    {
        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml"); // necesita el usuario

        LlenarCombos llenarCombos = new LlenarCombos("Parametros.xml");

        public FormConsultaArticulos()
        {
            InitializeComponent();
        }

        private void dgbproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormConsultaArticulos_Load(object sender, EventArgs e)
        {
            llenarGrids.SQL =
                "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock, dbo.IVA.Descripcion AS Iva," +
                "dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas " +
                "FROM dbo.Producto INNER JOIN " +
                "dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
                "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento";

            
            if (!llenarGrids.LlenarGridWindows(dgbproductos))
            {
                MessageBox.Show(llenarGrids.Error, "Error");
                
            }

            llenarCombos.SQL = "select IDDepartamento,Descripcion " +
                               "from Departamento " +
                               "union " +
                               "select '', '[Todos]' order by 2";
            llenarCombos.CampoID = "IDDepartamento";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbdepartamento);




            llenarCombos.SQL = "select IDIVA,Descripcion " +
                               "from IVA union " +
                               "select '', '[Todos]' order by 2";
            llenarCombos.CampoID = "IDIVA";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbiva);


        }

        private void cmbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdepartamento.SelectedIndex == 0)
            {
                llenarGrids.SQL =
                "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock, dbo.IVA.Descripcion AS Iva," +
                "dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas " +
                "FROM dbo.Producto INNER JOIN " +
                "dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
                "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento";
            }
            else
            {
                llenarGrids.SQL =
                  "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock, dbo.IVA.Descripcion AS Iva," +
                  "dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas " +
                  "FROM dbo.Producto INNER JOIN " +
                  "dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
                  "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento " +
                  "WHERE dbo.Producto.IDDepartamento= "+cmbdepartamento.SelectedValue;
            }
            llenarGrids.LlenarGridWindows(dgbproductos);

        }

        private void cmbiva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbiva.SelectedIndex == 0)
            {
                llenarGrids.SQL =
                "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock, dbo.IVA.Descripcion AS Iva," +
                "dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas " +
                "FROM dbo.Producto INNER JOIN " +
                "dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
                "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento";
            }
            else
            {
                llenarGrids.SQL =
                  "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock, dbo.IVA.Descripcion AS Iva," +
                  "dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas " +
                  "FROM dbo.Producto INNER JOIN " +
                  "dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
                  "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento " +
                  "WHERE dbo.Producto.IDIVA= " + cmbiva.SelectedValue;
            }
            llenarGrids.LlenarGridWindows(dgbproductos);
        }
    }
}
