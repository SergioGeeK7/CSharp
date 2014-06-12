using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {

        private static string nombreApp;
        private static CursosMatriculados cursosMatri;
        private static bool update;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                nombreApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                cursosMatri = new CursosMatriculados(nombreApp);
                cursosMatri.LlenarComboCurso(comboocurso);
                cursosMatri.LlenarComboFormaPagos(combopago);
                cursosMatri.LlenarComboPeriodo(comboperiodo);
                comboocurso_SelectedIndexChanged(null, null);
            }

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void combocurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void combofecha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

            lblmensaje.Text = "";
        
            try
            {


                if (string.IsNullOrEmpty(this.txtcedula.Text))
                {
                    lblmensaje.Text = "Porfavor ingrese numero de cedula";
                    return;
                }

                cursosMatri = new CursosMatriculados(nombreApp);

                int cedula = Convert.ToInt32(this.txtcedula.Text);
                int idcurso = Convert.ToInt32(comboocurso.SelectedValue);

                if (!cursosMatri.getMatricula(cedula,idcurso))
                {
                    lblmensaje.Text = cursosMatri.Mensaje;
                    Limpiar();
                    return;
                }


                txtcedula.Text = cursosMatri.Cedula.ToString();
                comboocurso.SelectedValue = cursosMatri.CodigoCur.ToString();
                combojornada.SelectedValue = cursosMatri.IdJornada.ToString();
                combopago.SelectedValue = cursosMatri.IdPago.ToString();
                comboperiodo.SelectedValue = cursosMatri.IdPeriodo.ToString();
                txtestado.Text = cursosMatri.Estado.ToString("N2");


                // rblJornada.SelectedValue




            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
                Limpiar();
            }







        }

        protected void comboocurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
            new CursosMatriculados(nombreApp).LlenarComboJornada(combojornada, Convert.ToInt32(comboocurso.SelectedValue));
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
                        this.btnbuscar.Visible = true;
                        this.txtcedula.ReadOnly = false;
                        ReadOnlyy(true);
                        this.comboocurso.Enabled = true;
                        break;
                    case "agregar":
                        Limpiar();
                        ReadOnlyy(false);
                        this.txtcedula.ReadOnly = false;
                        this.txtestado.ReadOnly = true;
                        this.txtcedula.Focus();
                        update = false;
                        break;
                    case "modificar":

                        this.comboocurso.Focus();
                        ReadOnlyy(false);
                        this.txtcedula.ReadOnly = true;
                        update = true;
                        break;
                    case "grabar":

                        if (!Validar()) return;

                        int cedula = Convert.ToInt32(this.txtcedula.Text);
                        int curso = Convert.ToInt32(comboocurso.SelectedValue);
                        int periodo = Convert.ToInt32(comboperiodo.SelectedValue);
                        int jornada = Convert.ToInt32(combojornada.SelectedValue);
                        int pago = Convert.ToInt32(combopago.SelectedValue);
                        decimal estado = string.IsNullOrEmpty(this.txtestado.Text) ? 0m:Convert.ToDecimal(txtestado.Text);
                        int codEmpleado = Convert.ToInt32(Session["CodEmpleado"]);



                        cursosMatri = new CursosMatriculados(nombreApp);


                        if (update)
                            cursosMatri.UpdateMatricula(cedula, curso, periodo, jornada, pago, estado, codEmpleado);
                        else
                            cursosMatri.InsertMatricula(cedula, curso, periodo, jornada, pago, codEmpleado);

                        lblmensaje.Text = cursosMatri.Mensaje;
                        break;

                    case "cancelar":
                        Limpiar();
                        this.btnbuscar.Visible = false;
                        ReadOnlyy(true);
                        break;
                    case "mostrartodo":
                        
                        if (! new CursosMatriculados(nombreApp).FillGridMatriculas(GridView1) )
                            lblmensaje.Text = cursosMatri.Mensaje;
                        GridView1.Visible = true;
                        break;


                }


            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }

        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(this.txtcedula.Text))
            {
                lblmensaje.Text = "porfavor digite su cedula";
                return false;
            }


            return true;
        }


        private void ReadOnlyy(bool b)
        {
            comboocurso.Enabled = !b;
            combojornada.Enabled = !b;
            combopago.Enabled = !b;
            comboperiodo.Enabled = !b;
            txtestado.ReadOnly = b;
        }

        private void Limpiar()
        {
          
            combopago.SelectedIndex = 0;
            comboperiodo.SelectedIndex = 0;
            txtestado.Text = "";
            txtcedula.Text = "";
        }


    }
}