using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LibLlenarCombos;
using LibLlenarGrids;

namespace WebMatricula
{
    public class clsPeriodo
    {
        #region "Atributos
        private string strApp;
        private string strSQL;
        private string strError;
        #endregion

        #region "Constructor"
        public clsPeriodo(string NombreApp)
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
         public bool LlenarCombo(DropDownList Combo)
        {
            try
            {
                if(Combo==null)
                {
                    strError = "Combo Nulo";
                    return false;
                }
                clsLlenarCombos objLlenar = new clsLlenarCombos(strApp);
                objLlenar.SQL = "EXEC USP_Periodo_LlenarCombo";
                objLlenar.CampoID = "Codigo";
                objLlenar.CampoTexto = "Nombre";
                if (!objLlenar.LlenarCombo_Web(Combo))
                {
                    strError = objLlenar.Error;
                    objLlenar = null;
                    return false;
                }
                objLlenar = null;
                return false;
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