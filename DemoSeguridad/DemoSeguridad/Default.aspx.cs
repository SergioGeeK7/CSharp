using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoSeguridad
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // clases del memebercship

            if (Roles.IsUserInRole("Administrador"))
            {
                
                // busqueme un "linkbutton1" dentro del loginview1 y a ese lo hago visible
                LinkButton link = (LinkButton)LoginView1.FindControl("LinkButton1");
                link.Visible = true;


                // esto es un contorl se asp.net para optiber acceso a esos controlers -
                // los tenemos que referenciar por codigo


            }

        }
    }
}