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
        static string strApp;
        static int intOpcion;
        int  intIdProg;
        static string strCarnet;
        string  strIdAsig ;
        int intIdPeriodo;

        private void Mensaje(string msj)
        {
            lblMsj.Text = msj;
        }

        private void LlenarComboAPer()
        {
            clsFacultad obj = new clsFacultad(strApp);
            if (!obj.LlenarCombo(ddlPeriodo))
            {
                Mensaje(obj.Error);
                obj = null;
                return;
            }
            obj = null;
        }

        private void LlenarComboPer()
        {
            clsPeriodo obj = new clsPeriodo(strApp);
            if (!obj.LlenarCombo(ddlPeriodo))
            {
                Mensaje(obj.Error);
                obj = null;
                return;
            }
            obj = null;
        }

       private void Limpiar()
        {
            ddlPeriodo.SelectedValue = "59";
            txtCarnet.Text = string.Empty;
            lblNombre.Text = string.Empty;
            lblPrograma.Text = string.Empty;
            ddlAsignatura.Items.Clear();
            grvDatos.DataSource = null;
            grvDatos.DataBind();

         

        }

       private void Grabar()
       {

           try
           {
               
               Mensaje("");
               // mirar que tengo que capturar en los procillors
               intIdPeriodo =Convert.ToInt32(this.ddlPeriodo.SelectedValue) ;
               strIdAsig = this.ddlAsignatura.SelectedValue;
               

               if(string.IsNullOrEmpty(strCarnet))
               {
                Mensaje("carnet no valido");
                   this.txtCarnet.Focus();
                   return;
               }

               if(string.IsNullOrEmpty(strIdAsig))
               {
                Mensaje("Asignaruta no valida, seleccione la asignaruta a matricular");
                   this.ddlAsignatura.Focus();
                   return;
               }

               clsMatricula obj = new clsMatricula(strApp);
               obj.Carnet = strCarnet;
               obj.Periodo = intIdPeriodo;
               obj.Asignatura = strIdAsig;
               if(!obj.GrabarMaestro())
               {
                   Mensaje(obj.Error); 
                   return;
               }

               strCarnet = obj.Carnet;

            if (strCarnet == "-1")
            {
                Mensaje("El estudiante ya matriculo la asignatura para este periodo");
                obj = null;
                return;
            }

            else  if (strCarnet == "0")
            {
                Mensaje("Error al Grabar, Consulte con el Adminnistrador del Sistema ");
                obj = null;
                return;
            }

            Mensaje("Matricula realizada con exito");
            obj = null;
            LlenarComboGrid();

               
           }
           catch (Exception ex)
           {
               
               Mensaje(ex.Message);
           }
       }



       private void GGrabar() 
       {
           try
           {
               
               Mensaje("");
               // mirar que tengo que capturar en los procillors
               intIdPeriodo =Convert.ToInt32(this.ddlPeriodo.SelectedValue) ;
               strIdAsig = this.ddlAsignatura.SelectedValue;
               

               if(string.IsNullOrEmpty(strCarnet))
               {
                Mensaje("carnet no valido");
                   this.txtCarnet.Focus();
                   return;
               }

               if(string.IsNullOrEmpty(strIdAsig))
               {
                Mensaje("Asignaruta no valida, seleccione la asignaruta a matricular");
                   this.ddlAsignatura.Focus();
                   return;
               }

               clsMatricula obj = new clsMatricula(strApp);
               obj.Carnet = strCarnet;
               obj.Periodo = intIdPeriodo;
               obj.Asignatura = strIdAsig;
               if(!obj.GrabarMaestro())
               {
                   Mensaje(obj.Error); 
                   return;
               }

               strCarnet = obj.Carnet;

            if (strCarnet == "-1")
            {
                Mensaje("El estudiante ya matriculo la asignatura para este periodo");
                obj = null;
                return;
            }

            else  if (strCarnet == "0")
            {
                Mensaje("Error al Grabar, Consulte con el Adminnistrador del Sistema ");
                obj = null;
                return;
            }

            Mensaje("Matricula realizada con exito");
            obj = null;
            

               
           }
           catch (Exception ex)
           {
               
               Mensaje(ex.Message);
           }
       }


       private void LlenarComboGrid()
       {
           clsMatricula obj = new clsMatricula(strApp);

           obj.Carnet = strCarnet;
           obj.Periodo = intIdPeriodo;


           if (!obj.LlenarGrid(grvDatos)) // datagridview del diseno
           {
               Mensaje(obj.Error);
               obj = null;
               return;
           }
           obj = null;
       }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                strApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                LlenarComboPer();

            }


        }

        protected void ddlPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void mnuOpciones_MenuItemClick(object sender, MenuEventArgs e)
        {
            txtCarnet.ReadOnly = true;
            ibtnBuscar.Visible = false;
            Mensaje(string.Empty);

            switch (mnuOpciones.SelectedValue){
            
                case "opcNuevo":
                     Limpiar();
                     txtCarnet.ReadOnly = false;
                     ibtnBuscar.Visible = true;
                    break;

                case "opcMatricular":
                    Grabar();
                    break;

                case "opcImprimir":
                    break;

            
            }
        }

        protected void ibtnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                Mensaje(string.Empty);
                strCarnet = txtCarnet.Text.Trim();
                // here
                
               // mirar que tengo que capturar en los procillors
               intIdPeriodo =Convert.ToInt32(this.ddlPeriodo.SelectedValue) ;

                clsEstudiante obj = new clsEstudiante(strApp);
                if (!obj.BuscarMaestro(strCarnet))
                {
                    Mensaje(obj.Error);
                    obj = null;
                    return;
                }
                intIdProg = obj.Programa;
                lblNombre.Text = obj.Nombre;
                lblPrograma.Text = obj.Nombre_Programa;

                clsAsignatura objy = new clsAsignatura(strApp);
                if (!objy.LlenarCombo(ddlAsignatura, intIdProg))
                {
                    Mensaje(objy.Error);
                    objy = null;
                    return;
                }
                objy = null;

               // llenar grids
                LlenarComboGrid();
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