using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMatricula
{
    public partial class Formulario_web15 : System.Web.UI.Page
    {
        #region "Variable Globales"

            static string strApp;
            string strCarnet;
            string strIdAsig;
            int intIdProg, intIdPer;

        #endregion

        #region "Metodos personalizados"

            private void Mensaje(string Mensaje)
            {
                this.lblMsj.Text = Mensaje;
            }

            private void Limpiar() 
            {
                this.ddlPeriodo.SelectedValue = "59";
                this.txtCarne.Text = string.Empty;
                this.lblNombre.Text = string.Empty;
                this.lblPrograma.Text = string.Empty;
                this.ddlAsignatura.Items.Clear();
                this.grvDatos.DataSource = null;
                this.grvDatos.DataBind();
            }

            private void LlenarComboPer()
            {
                clsPeriodo objXX = new clsPeriodo(strApp);
                if (!objXX.LlenarCombo(this.ddlPeriodo))
                {
                    Mensaje(objXX.Error);
                    objXX = null;
                    return;
                }
                objXX = null;
            }

            private void LlenarAsignatura()
            {
                clsAsignatura objXX = new clsAsignatura(strApp);
                if (!objXX.LlenarCombo(ddlAsignatura, intIdProg))
                {
                    Mensaje(objXX.Error);
                    objXX = null;
                    return;
                }
                objXX = null;
            }


            private void LlenarGridAsignaturas()
            {
                clsMatricula objXX = new clsMatricula(strApp);

                objXX.Periodo = intIdPer;
                objXX.Carnet = strCarnet;

                if (!objXX.LlenarGrid(this.grvDatos))
                {
                    Mensaje(objXX.Error);
                    objXX = null;
                    return;
                }
                objXX = null;
            }

            private bool CapturarInfo() 
            {
                try
                {

                    Mensaje(string.Empty);
                    strCarnet = this.txtCarne.Text;
                    intIdPer = Convert.ToInt32(this.ddlPeriodo.SelectedValue);
                    strIdAsig = this.ddlAsignatura.SelectedValue;

                    if (string.IsNullOrEmpty(strCarnet))
                    {
                        Mensaje("Carné no válido");
                        this.txtCarne.Focus();
                        return false;
                    }

                    if (string.IsNullOrEmpty(strIdAsig))
                    {
                        Mensaje("Asignatura no válida, Seleccione la asignatura a matrícular");
                        this.ddlAsignatura.Focus();
                        return false;
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    Mensaje(ex.Message);
                    return false;
                }
            }

            private void Grabar() 
            {
                try
                {

                    if (!CapturarInfo())
                    {
                        Mensaje("Fallo la captura de la información");
                        return;
                    }

                    clsMatricula matricula = new clsMatricula(strApp);

                    matricula.Carnet = strCarnet;
                    matricula.Periodo = intIdPer;
                    matricula.Asignatura = strIdAsig;

                    if (!matricula.GrabarMaestro())
                    {
                        Mensaje(matricula.Error);
                        matricula = null;
                        return;
                    }

                    strCarnet = matricula.Carnet;

                    if (strCarnet == "-1")
                    {
                        Mensaje("El estudiante ya matriculó la asignatura para éste período con anterioridad ");
                        matricula = null;
                        return;
                    }
                    else if (strCarnet == "0")
                    {
                        Mensaje("Error al Grabar, Consulte con el Admón del sistema");
                        matricula = null;
                        return;
                    }

                    Mensaje("Matricula realizada con éxito");
                    matricula = null;

                    LlenarGridAsignaturas();
                }
                catch (Exception ex)
                {
                    Mensaje(ex.Message);
                    return;
                }
                
            }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//cargue el formulario por primera vez
            {
                strApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;//nombre Proyecto
                LlenarComboPer();
            }
            
        }

        protected void mnnOpciones_MenuItemClick(object sender, MenuEventArgs e)
        {
            this.ibtnBuscar.Visible = false;
            this.txtCarne.ReadOnly = true;
            Mensaje(string.Empty);

            switch (this.mnnOpciones.SelectedValue)
            {
                case "opcNuevo":
                    Limpiar();
                    this.ibtnBuscar.Visible = true;
                    this.txtCarne.ReadOnly = false;
                    this.txtCarne.Focus();
                    break;
                case "opcMatricular":
                    Grabar();
                    break;
                case "opcImprimir":

                    break;
                default:
                    Mensaje("Opción no válida");
                    break;
            }
        }

        protected void ibtnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                Mensaje(string.Empty);
                strCarnet = this.txtCarne.Text.Trim();
                clsEstudiante estudiante = new clsEstudiante(strApp);
                if (!estudiante.BuscarMaestro(strCarnet))
                {
                    Mensaje(estudiante.Error);
                    estudiante = null;
                    return;
                }

                this.lblNombre.Text = estudiante.Nombre;
                this.lblPrograma.Text = estudiante.Nombre_Programa;
                intIdProg = estudiante.Programa;
                LlenarAsignatura();
                this.ibtnBuscar.Visible = false;
                this.txtCarne.ReadOnly = true;

                intIdPer = Convert.ToInt32(this.ddlPeriodo.SelectedValue);

                LlenarGridAsignaturas();
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }
    }
}