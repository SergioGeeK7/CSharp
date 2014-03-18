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

namespace SistemaFacturacionLibrerias.Formularios
{
    public partial class frmProductos : Form
    {
        LlenarCombos llenarCombos = new LlenarCombos("Parametros.xml");
        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml");

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            llenarGrids.SQL = "SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock, dbo.Producto.Notas, dbo.IVA.Descripcion AS IVA, "
                + "dbo.Departamento.Descripcion AS Departamento "
                + "FROM dbo.Departamento INNER JOIN "
                + "dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento INNER JOIN "
                + "dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA";
            llenarGrids.LlenarGridWindows(dgvProductos);

            llenarCombos.SQL = "SELECT IDIVA, Descripcion FROM IVA ORDER BY 2";
            llenarCombos.CampoID = "IDIVA";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbIVA);

            llenarCombos.SQL = "SELECT IDDepartamento, Descripcion FROM Departamento ORDER BY 2";
            llenarCombos.CampoID = "IDDepartamento";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbDepartamento);

            cmbIVA.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
        }
    }
}
