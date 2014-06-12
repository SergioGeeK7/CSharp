using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        private static string strApp;
      

        protected void Page_Load(object sender, EventArgs e)
        {
         

            if (!IsPostBack)
            {
                strApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                
                //LlenarComboFac();
                //ddlFacultad_SelectedIndexChanged(null, null);
                //ddlPrograma.SelectedIndex = 0;
                //LlenarJornada();
                //rblJornada.SelectedIndex = 3;
                //intOpcion = 0;
            }

           // usuario.LlenaGridview(GridView1);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            int cedula = Convert.ToInt32(this.txtcedula.Text.Trim());

           Usuario usuario = new Usuario(strApp);

            if (!usuario.getUsuario(cedula))
            {
                Mensaje(usuario.Error);
                return;
            }

            this.txtnombre.Text = usuario.Nombres;
            this.txtapellidos.Text = usuario.Apellidos;
            this.txtcedula.Text = usuario.Cedula.ToString();


        }

        public void Mensaje(string msj)
        {
            this.lblmensaje.Text = msj;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(strApp);
            usuario.LlenaGridview(GridView1);
        }


    }
}