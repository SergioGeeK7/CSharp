using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibConexionBD;
using System.Data;

namespace WebMatricula
{
    public partial class Formulario_web17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string strCarnet = Session["Carnet"].ToString();
            clsConexionBD objcnx = new clsConexionBD(strApp);
            objcnx.SQL = "EXEC USP_Estudiante_Buscar_Imprimir '" + strCarnet + "'; ";
            if (!objcnx.LlenarDataSet(false))
            {
                Response.Redirect("frmEstudiante.aspx");            
            }

            DataSet dts = new DataSet();
            dts = objcnx.DataSet_Lleno;
            objcnx = null;

            string strDireccion = AppDomain.CurrentDomain.BaseDirectory + "Estudiante_Impresion.xml";

            dts.WriteXmlSchema(strDireccion);

            rptEstudiante myDataReport = new rptEstudiante();

            myDataReport.SetDataSource(dts);

            this.crvVerInforme.ReportSource = myDataReport;
            this.crvVerInforme.ShowFirstPage();
        }
    }
}