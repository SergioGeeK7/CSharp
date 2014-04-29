using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LibLlenarCombos;
using LibLlenarGrids;

namespace WebMatricula
{
    public class clsFacultad
    {
        #region "Atributos
        private string strApp;
        private string strSQL;
        private string strError;
        #endregion

        #region "Constructor"
        public clsFacultad(string NombreApp)
        {
            strApp = NombreApp;
            strSQL = string.Empty;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"
        public string Error
        { get { return strError; } }
        #endregion

        #region "Metodos Publicos"
        public bool LlenarGrid(GridView Grid) 
        {
            try
            {
                if(Grid==null)
                {
                    strError = "Grid Nulo";
                    return false;
                }
                clsLlenarGrids objLlenar = new clsLlenarGrids(strApp);
                objLlenar.SQL = "EXEC USP_Facultad_BuscarGeneral";
                if(!objLlenar.LlenarGrid_Web(Grid))
                {
                    strError = objLlenar.Error;
                    objLlenar = null;
                    return false;
                }
                objLlenar = null;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
                
            }
        }
        public bool LlenarCombo(DropDownList Combo)
        {
            try
            {
                if (Combo == null)
                {
                    strError = "Combo Nulo";
                    return false;
                }

                clsLlenarCombos objLlenar = new clsLlenarCombos(strApp);
                objLlenar.SQL = "EXEC USP_Facultad_BuscarGeneral";
                objLlenar.CampoID = "Codigo";//nombre del campo que tiene la clave primaria
                objLlenar.CampoTexto = "Nombre";//nombre del campo que contiene la informacion que va ser despligada en la lista desplegable

                if (!objLlenar.LlenarCombo_Web(Combo))
                {
                    strError = objLlenar.Error;
                    objLlenar = null;
                    return false;
                }
                objLlenar = null;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion
    }
}