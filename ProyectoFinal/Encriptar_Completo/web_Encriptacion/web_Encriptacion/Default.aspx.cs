using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using LibEncriptar;

namespace web_Encriptacion
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcesar_Click(object sender, EventArgs e)
        {
            string Cadena = this.TxtTexto.Text.Trim();
            this.TxtRpta.Text = "";
            
            if (Cadena == "")
            {
                this.TxtRpta.Text = "Ingrese un dato por favor";
                this.TxtTexto.Focus();
                return;
            }
            
            ClsEncriptar objEnc = new ClsEncriptar();
            int Opcion = Convert.ToInt32( this.rdbL_Opciones.SelectedItem.Value );
            switch (Opcion)
            { 
                case 1:
                    this.TxtRpta.Text = objEnc.Encripta(Cadena);
                    break;
                case 2:
                    this.TxtRpta.Text = objEnc.DesEncripta(Cadena);
                    break;
            }

        }
    }
}
