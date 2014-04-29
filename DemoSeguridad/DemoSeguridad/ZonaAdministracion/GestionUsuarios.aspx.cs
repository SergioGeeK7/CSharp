using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoSeguridad.ZonaAdministracion
{
    public partial class GestionUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // me pinte todos los usuarios

            gridviewusuarios.DataSource = Membership.GetAllUsers(); // colleccion de la clase llamada usuarios
            gridviewusuarios.DataBind();
            // uno de los parametros que acepta el datasource lea arriba xD

            // cada que cambis el datasource tiene que ejecutarse tambien el databind 


        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            gvwbuscar.DataSource = Membership.FindUsersByName(txtusuario.Text);
            gvwbuscar.DataBind();

        }
    }
}