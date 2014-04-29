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
        int intNroDoc, intJor;
        string strNombres;
        bool blnAct;
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
            if (!objXX.LlenarCombo(this.ddlPrograma, intFac))
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

        #endregion


        //tecnoogia cliente-servidor
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//cargue el formulario por primera vez
            {
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


        private void Limpiar()
        {
            this.ddlFacultad.SelectedIndex = 0;
            ddlFacultad_SelectedIndexChanged(null, null);
            ddlPrograma.SelectedIndex = 0;
            this.rblJornada.SelectedIndex = 3;
            this.txtCarne.Text = "";
            this.txtNroDoc.Text = "";
            this.txtNombre.Text = "";
            this.chkActivo.Checked = true;
            this.txtObservac.Text = "";
        }

        protected void mnnOpciones_MenuItemClick(object sender, MenuEventArgs e)
        {
            this.ibtnBuscar.Visible = false;
            this.txtCarne.ReadOnly = true;

            switch (this.mnnOpciones.SelectedValue)
            {
                case "opcBuscar":
                    // falta algo    
                    Limpiar();
                    this.ibtnBuscar.Visible = true;
                    this.txtCarne.ReadOnly = false;
                    this.txtCarne.Focus();
                    break;
                case "opcAgregar":
                    break;
                case "opcModificar":
                    break;
                case "opcGrabar":
                    break;
                case "opcCancelar":
                    break;
                case "opcImprimir":
                    break;
                default: Mensaje("Opcion no valida,porfavor no siga hackeando");
                    break;
            }
        }

        protected void ibtnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            // consultar return datareader ver en clase estudiante tipos de consultas

            try
            {
                Mensaje(""); // limpia el output del error ...
                strCarnet = this.txtCarne.Text.Trim();
                clsEstudiante obj = new clsEstudiante(strApp);

                if (!obj.BuscarMaestro(strCarnet)) 
                {
                    Mensaje(obj.Error);
                    obj = null;
                    return;
                }
                this.ddlFacultad.SelectedValue = obj.Facultad.ToString(); // value valor normal numero
                ddlFacultad_SelectedIndexChanged(null, null); // se llene deacuerdo de la facultar (linea anterior)
                this.ddlPrograma.SelectedValue = obj.Programa.ToString(); // llenar al que falta
                this.txtNroDoc.Text = obj.Nro_Documento.ToString();
                this.txtCarne.ReadOnly = true;
                this.txtNombre.Text = obj.Nombre;
                this.txtObservac.Text = obj.Observacion;
                this.chkActivo.Checked = obj.Activo;
                



            }
            catch (Exception ex)
            {

                Mensaje(ex.Message);
            }

        }


    }
}