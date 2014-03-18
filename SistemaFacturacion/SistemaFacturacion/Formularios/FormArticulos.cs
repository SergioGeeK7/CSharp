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

namespace SistemaFacturacion.Formularios
{
    public partial class FormArticulos : Form
    {
        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml"); // necesita el usuario

        LlenarCombos llenarCombos = new LlenarCombos("Parametros.xml");


        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
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
    }
}
