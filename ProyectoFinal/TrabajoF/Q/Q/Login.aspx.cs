using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibEncriptar;
namespace Q
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        private static Login login;
        private static string strApp;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                strApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            login = new Login(strApp);

            string password = new ClsEncriptar().Encripta(this.txtpassword.Text);


            if (login.logear(this.txtusuario.Text, password))
            {
                Session["CodEmpleado"] = login.CodEmpleado;
                Response.Redirect("Cursos.aspx");
            }
            else
            {
                // Response.Redirect("Login.aspx");
                lblMensaje.Text = login.Mensaje;
                this.txtusuario.Text = string.Empty;
                this.txtpassword.Text = string.Empty;
                this.txtusuario.Focus();
            }

        }
    }
}