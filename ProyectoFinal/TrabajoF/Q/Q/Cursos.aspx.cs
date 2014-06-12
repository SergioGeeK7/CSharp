using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {

        private static Curso curso;
        private static string nombreApp;
        private static bool update;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                nombreApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                new Curso(nombreApp).getTemas(cbltemas);
            }



        }

        protected void mnnOpciones_MenuItemClick(object sender, MenuEventArgs e)
        {


            lblmensaje.Text = "";
            GridView1.Visible = false;
            try
            {
                switch (mnnOpciones.SelectedValue.ToLower())
                {
                    case "buscar":
                        ReadOnlyy(true);
                        this.btnbuscar.Visible = true;
                        this.txtcodigo.ReadOnly = false;
                        break;
                    case "agregar":
                        Limpiar();
                        ReadOnlyy(false);
                        this.txtcodigo.Focus();
                        update = false;
                        break;
                    case "modificar":

                        this.txtcodigo.Focus();
                        ReadOnlyy(false);
                        this.txtcodigo.ReadOnly = true;
                        update = true;
                        break;
                    case "grabar":

                        if (!Validar()) return;

                        int codigo = Convert.ToInt32(this.txtcodigo.Text);
                        string titulo = txttitulo.Text;
                        decimal costo = Convert.ToDecimal(txtcosto.Text);
                        int numeroHoras = Convert.ToInt32(txtNumeroHoras.Text);
                        int codEmpleado = Convert.ToInt32(Session["CodEmpleado"]);

                        curso = new Curso(nombreApp);


                        if (update)
                            curso.UpdateCurso(codigo, titulo, numeroHoras, costo, codEmpleado);
                        else
                            curso.InsertCurso(codigo, titulo, numeroHoras, costo, codEmpleado);

                        curso.UpdateTemas(cbltemas, codEmpleado, codigo);
                        lblmensaje.Text = curso.Mensaje;
                        break;

                    case "cancelar":
                        Limpiar();
                        this.btnbuscar.Visible = false;
                        ReadOnlyy(true);
                        break;
                    case "mostrartodo":
                        if (! new Curso(nombreApp).FillGridCursos(GridView1) )
                            lblmensaje.Text = curso.Mensaje;
                        GridView1.Visible = true;
                        break;


                }


            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }





        }


        public bool Validar()
        {

            if (string.IsNullOrEmpty(txtcodigo.Text))
            {
                lblmensaje.Text = "falta codigo";
                return false;
            }
            if (string.IsNullOrEmpty(txtNumeroHoras.Text))
            {
                lblmensaje.Text = "falta numero de horas";
                return false;
            }
            if (string.IsNullOrEmpty(txtcosto.Text))
            {
                lblmensaje.Text = "falta el costo";
                return false;
            }
            if (string.IsNullOrEmpty(txttitulo.Text))
            {
                lblmensaje.Text = "falta el titulo";
                return false;
            }

            bool atLeastOne = false;
            foreach (ListItem item in cbltemas.Items)
            {
                if (item.Selected)
                {
                    atLeastOne = true;
                    break;
                }
            }
            if (!atLeastOne)
            {
                lblmensaje.Text = "debes seleccionar almenos un tema";
                return false;
            }

            return true;

        }


        public void Limpiar()
        {
            this.txtcodigo.Text = "";
            this.txtNumeroHoras.Text = "";
            this.txtcosto.Text = "";
            this.txttitulo.Text = "";

            foreach (ListItem item in cbltemas.Items)
            {
                item.Selected = false;
            }
        }



        public void ReadOnlyy(bool b)
        {
            this.txtcodigo.ReadOnly = b;
            this.txtNumeroHoras.ReadOnly = b;
            this.txtcosto.ReadOnly = b;
            this.cbltemas.Enabled = !b;
            this.txttitulo.ReadOnly = b;
        }


        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

            try
            {


                curso = new Curso(nombreApp);

                int id = Convert.ToInt32(this.txtcodigo.Text);

                if (!curso.GetCurso(id))
                {
                    lblmensaje.Text = curso.Mensaje;
                    return;
                }

                txtcodigo.Text = curso.Codigo.ToString();
                txtNumeroHoras.Text = curso.NumeroHoras.ToString();
                txtcosto.Text = curso.Valor.ToString("N2");
                txttitulo.Text = curso.Titulo;





                foreach (ListItem item in cbltemas.Items)
                {
                    if (curso.Temas.Contains(Convert.ToInt32(item.Value))) item.Selected = true;
                }





                // rblJornada.SelectedValue






            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }



        }
    }
}