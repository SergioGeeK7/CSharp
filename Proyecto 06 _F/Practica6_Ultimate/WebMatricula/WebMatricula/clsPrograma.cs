using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LibLlenarCombos;
using LibLlenarGrids;


namespace WebMatricula
{
    public class clsPrograma
    {
          #region "Atributos
        private string strApp;
        private string strSQL;
        private string strError;
        #endregion

        #region "Constructor"
        public clsPrograma(string NombreApp)
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
        public bool LlenarCombo(DropDownList Combo_A_llenar, int Facultad)
        {
            try
            {
                if(Combo_A_llenar==null)
                {
                    strError = "Combo nulo";
                    return false;
                
                }
                clsLlenarCombos objLlenar = new clsLlenarCombos(strApp);
                objLlenar.SQL = "EXEC USP_Programa_llenarCombo " + Facultad;
                objLlenar.CampoID = "Codigo";
                objLlenar.CampoTexto = "Nombre";
                if (!objLlenar.LlenarCombo_Web(Combo_A_llenar))
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