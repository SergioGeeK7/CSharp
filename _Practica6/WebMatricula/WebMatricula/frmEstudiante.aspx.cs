using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibLlenarRBList;
using LibConexionBD;
using LibLlenarCombos;
using LibLlenarGrids;

namespace WebMatricula
{
    public partial class Formulario_web14 : System.Web.UI.Page
    {
      #region "Variable Globales"

        static string strApp;    //Nombre de la aplicacion que le vamos a enviar a facultad 
                                 //para que pueda encontrar El Archivo XML
        int intFac, intProg;     //claves primaria de facultad, y de programa
        string strCarnet;         //carne de estudiante
        int intNroDoc,intJor;
        string strNombres, strObser;
        bool blnAct;
        static int intOpcion; 

      #endregion
      
      #region "Metodos Personalizados"

        private void Mensaje(string Mensaje) 
        {
            this.lblMsj.Text = Mensaje;
        }
        
        private void LlenarComboFac() 
        {
            clsFacultad objXX = new clsFacultad(strApp);
            if (!objXX.LlenarCombo(this.ddlFacultad)) 
            {
                Mensaje(objXX.Error);
                objXX = null;
                return;
            }
            objXX = null;
        }
        private void LlenarComboProg()
        {
            intFac = int.Parse(this.ddlFacultad.SelectedValue);
            clsPrograma objXX = new clsPrograma(strApp);
            if (!objXX.LlenarCombo(this.ddlPrograma,intFac))
            {
               
                Mensaje(objXX.Error);
                objXX = null;
                return;
            }
            objXX = null;
        }
        private void LlenarJornada()
        {
            clsJornada objXX = new clsJornada(strApp);
            if (!objXX.LlenarRBL(rblJornada))
            {
                Mensaje(objXX.Error);
                objXX = null;
                return;
            }
            objXX = null;
        }

        private void Limpiar() 
        {
            this.ddlFacultad.SelectedIndex = 0;
            this.ddlFacultad_SelectedIndexChanged(null, null);
            this.ddlPrograma.SelectedIndex = 0;
            this.rblJornada.SelectedIndex = 3;
            this.txtCarne.Text = string.Empty;
            this.txtNroDoc.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.chkActivo.Checked = true;
            this.txtObservac.Text = string.Empty;
        }

        private bool CapturarInfo()
        {
            try
            {
                intFac = Convert.ToInt32(this.ddlFacultad.SelectedValue);
                intProg = Convert.ToInt32(this.ddlPrograma.SelectedValue);
                strCarnet = this.txtCarne.Text.Trim();
                intNroDoc = Convert.ToInt32(this.txtNroDoc.Text);
                strNombres = this.txtNombre.Text.Trim();
                blnAct = this.chkActivo.Checked;
                intJor = Convert.ToInt32(this.rblJornada.SelectedValue);
                strObser = this.txtObservac.Text.Trim();

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
            if (intOpcion <= 0 || intOpcion > 2)
            {
                Mensaje("Opción no válida, Buscar o ingresar info de un Estudiante primero");
                return;
            }

            if (!CapturarInfo())
            {
                Mensaje("Fallo la captura de la información");
                return;
            }

            clsEstudiante objXX = new clsEstudiante(strApp);
            objXX.Facultad = intFac;
            objXX.Programa = intProg;
            objXX.Carnet = strCarnet;
            objXX.Nro_Documento = intNroDoc;
            objXX.Nombre = strNombres;
            objXX.Activo = blnAct;
            objXX.Jornada = intJor;
            objXX.Observacion = strObser;

            if (intOpcion == 1)
            {
                if (!objXX.GrabarMaestro())
                {
                    Mensaje(objXX.Error);
                    objXX = null;
                    return;
                }
            }
            else
            {
                if (!objXX.ModificarMaestro())
                {
                    Mensaje(objXX.Error);
                    objXX = null;
                    return;
                } 
            }

            strCarnet = objXX.Carnet;

            if (strCarnet == "-1")
            {
                Mensaje("Error al Grabar, Ya existe un estudiante con el mismo número de Carné");
                objXX = null;
                return;
            }
            else if (strCarnet == "0")
            {
                Mensaje("Error al Grabar, Consulte con el Admón del sistema");
                objXX = null;
                return;
            }

            Mensaje("Registro gravado con éxito");
            objXX = null;
        }
      
      #endregion

    
        //tecnoogia cliente-servidor
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)//cargue el formulario por primera vez
            {
                intOpcion = 0;
                strApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;//nombre Proyecto
                LlenarComboFac();
                ddlFacultad_SelectedIndexChanged(null, null);
                ddlPrograma.SelectedIndex = 0;
                LlenarJornada();
                this.rblJornada.SelectedIndex = 3;

            }
        }

        protected void ddlFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboProg();
        }

        protected void mnnOpciones_MenuItemClick(object sender, MenuEventArgs e)
        {
            this.ibtnBuscar.Visible = false;
            this.txtCarne.ReadOnly = true;
            Mensaje(string.Empty);

            switch (this.mnnOpciones.SelectedValue)
            {
                case "opcBuscar":
                    intOpcion = 0;
                    Limpiar();
                    this.ibtnBuscar.Visible = true;
                    this.txtCarne.ReadOnly = false;
                    this.txtCarne.Focus();
                    break;
                case "opcAgregar":
                    intOpcion = 1;
                    Limpiar();
                    this.txtCarne.ReadOnly = false;
                    this.ddlFacultad.Focus();
                    break;
                case "opcModificar":

                    intOpcion = 2;
                    this.ddlFacultad.Focus();

                    break;
                case "opcGrabar":

                    Grabar();
                    intOpcion = 0;

                    break;
                case "opcCancelar":

                    intOpcion = 0;
                    Limpiar();
                    this.ddlFacultad.Focus();

                    break;
                case "opcImprimir":

                    intOpcion = 0;
                    strCarnet = this.txtCarne.Text.Trim();
                    if (string.IsNullOrEmpty(strCarnet))
                    {
                        Mensaje("Buscar el estudiante por carné primero");
                        return;
                    }
                    Session["Carnet"] = strCarnet;
                    Response.Redirect("frmInformeEstudiante.aspx");

                    break;
                default:
                    Mensaje("Opción no válida");
                    intOpcion = 0;
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

                this.ddlFacultad.SelectedValue = estudiante.Facultad.ToString();
                this.ddlFacultad_SelectedIndexChanged(null, null);
                this.ddlPrograma.SelectedValue = estudiante.Programa.ToString();
                this.txtNroDoc.Text = estudiante.Nro_Documento.ToString();
                this.txtNombre.Text = estudiante.Nombre;
                this.txtObservac.Text = estudiante.Observacion;
                this.chkActivo.Checked = estudiante.Activo;
                this.rblJornada.SelectedValue = estudiante.Jornada.ToString();
                this.ibtnBuscar.Visible = false;
                this.txtCarne.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }

        protected void rblJornada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}