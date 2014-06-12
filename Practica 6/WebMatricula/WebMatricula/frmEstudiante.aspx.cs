using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMatricula
{
    public partial class Formulario_web14 : System.Web.UI.Page
    {
        static string strApp;
        static int intOpcion;
        byte intFac;
        int  intProg, intNroDoc, intJor;
        string strCarnet, strNombres, strObserv;
        bool blnAct;

        private void Mensaje(string msj)
        {
            lblMsj.Text = msj;         }

        private void LlenarComboFac()
        {
            clsFacultad obj = new clsFacultad( strApp );
            if (!obj.LlenarCombo(ddlFacultad))
            {
                Mensaje(obj.Error);
                obj = null;
                return;
            }
            obj = null;
        }

        private void LlenarJornada()
        {
            clsJornada obj = new clsJornada(strApp);
            if (!obj.LlenarRBL(rblJornada))
            {
                Mensaje(obj.Error);
                obj = null;
                return;
            }
            obj = null;
        }
        private void LlenarComboProg()
        {
            intFac = byte.Parse(ddlFacultad.SelectedValue);
            clsPrograma obj = new clsPrograma(strApp);
           if (!obj.LlenarCombo(ddlPrograma, intFac))
            {
                Mensaje(obj.Error);
                obj = null;
                return;
            }
           obj = null;
        }

        private void Limpiar()
        {
            ddlFacultad.SelectedIndex = 0;
            ddlFacultad_SelectedIndexChanged(null, null);
            ddlPrograma.SelectedIndex = 0;
            rblJornada.SelectedIndex = 3;
            txtCarnet.Text = string.Empty;
            txtNroDoc.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtObservac.Text =  string.Empty;
            chkActivo.Checked = true;

        }

        private void Grabar()
        {

            if (intOpcion <= 0 || intOpcion > 2)
            {
                Mensaje("Opcion no validad, Buscar o Ingresar Info de un Estudiante");
                return;
            }

            if (!CapurarInfo())
            {
                Mensaje("Fallo la captura de informacion");
                return;
            }

            clsEstudiante obj = new clsEstudiante (strApp);
            obj.Facultad = intFac;
            obj.Programa = intProg;
            obj.Carnet = strCarnet;
            obj.Nro_Documento = intNroDoc;
            obj.Nombre = strNombres;
            obj.Activo = blnAct;
            obj.Jornada = intJor;
            obj.Observacion = strObserv;
            if (intOpcion == 1)
            {
                if (!obj.GrabarMaestro())
                {
                    Mensaje(obj.Error);
                    obj = null;
                    return;
                }
            }
            else
            {
                if (!obj.ModificarMaestro())
                {
                    Mensaje(obj.Error);
                    obj = null;
                    return;
                }
            }
            strCarnet = obj.Carnet;
            if (strCarnet == "-1")
            {
                Mensaje("Error al Grabar,Ya Existe un estudiante con el mismo numero de carne ");
                obj = null;
                return;
            }

            else  if (strCarnet == "0")
            {
                Mensaje("Error al Grabar, Consulte con el Adminnistrador del Sistema ");
                obj = null;
                return;
            }

            Mensaje("Registro Grabado con exito");
            obj = null;
        }

        private bool CapurarInfo()
        {
            try
            {
                intFac = byte.Parse(this.ddlFacultad.SelectedValue);
                intProg = int.Parse(this.ddlPrograma.SelectedValue);
                strCarnet = txtCarnet.Text.Trim();
                strNombres = txtNombre.Text.Trim();
                blnAct = chkActivo.Checked;
                intJor = int.Parse(rblJornada.SelectedValue);
                strObserv = txtObservac.Text;

                return true;
            }
            catch (Exception ex)
            {

                Mensaje(ex.Message);
                return false;

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                strApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                LlenarComboFac();
                ddlFacultad_SelectedIndexChanged(null, null);
                ddlPrograma.SelectedIndex = 0;
                LlenarJornada();
                rblJornada.SelectedIndex = 3;
                intOpcion = 0;
            }

        }

        protected void ddlFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
           LlenarComboProg();
        }

        protected void mnuOpciones_MenuItemClick(object sender, MenuEventArgs e)
        {
            ibtnBuscar.Visible = false;
            txtCarnet.ReadOnly = true;
            rblJornada.Enabled = false;
            Mensaje(string.Empty); 
           
            switch (mnuOpciones.SelectedValue)
            {
                case "opcBuscar":

                    Limpiar();
                    ibtnBuscar.Visible = true;
                    txtCarnet.ReadOnly = false;
                    txtCarnet.Focus();

                    break;

                case "opcAgregar":
                    intOpcion = 1;
                    Limpiar();
                    txtCarnet.ReadOnly = false;
                    rblJornada.Enabled = true;
                    ddlFacultad.Focus();

                    break;

                case "opcModificar":
                    intOpcion = 2;
                    ddlFacultad.Focus();
                    rblJornada.Enabled = true;
                   
                    break;

                case "opcGrabar":
                    Grabar();
                    intOpcion = 0;
                    rblJornada.Enabled = true;
                    break;

                case "opcCancelar":
                    intOpcion = 0;
                    Limpiar();
                    break;

                case "opcImprimir":
                    intOpcion = 0;
                    break;
                default:
                    Mensaje("ERROR FALTAL! Auto destrucion en 2 mins!, Alejese y corra!!");
                    break;
            }

        }

        protected void ibtnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                Mensaje(string.Empty);
                strCarnet = txtCarnet.Text.Trim();
                clsEstudiante obj = new clsEstudiante(strApp);
                if (!obj.BuscarMaestro(strCarnet))
                {
                    Mensaje(obj.Error);
                    obj = null;
                    return;
                }
                ddlFacultad.SelectedValue = obj.Facultad.ToString();
                LlenarComboProg();
                ddlPrograma.SelectedValue = obj.Programa.ToString();
                txtNombre.Text = obj.Nombre;
                txtNroDoc.Text = obj.Nro_Documento.ToString();
                rblJornada.SelectedIndex = obj.Jornada;
                txtObservac.Text = obj.Observacion;

                ibtnBuscar.Visible = false;
                txtCarnet.ReadOnly = true;

            }
            catch (Exception ex)
            {

                Mensaje(ex.Message);
            }
        }
    }
}