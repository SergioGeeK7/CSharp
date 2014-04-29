using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LibLlenarCombos;
using LibLlenarGrids;
using LibLlenarRBList;
namespace WebMatricula
{
    public class clsJornada
    {
        #region "Atributos
        private string strApp;
        private string strSQL;
        private string strError;
        #endregion

        #region "Constructor"
        public clsJornada(string NombreApp)
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
        public bool LlenarRBL(RadioButtonList RBL_A_llenar)
        {
            try
            {
                if (RBL_A_llenar == null)
                {
                    strError = "RadioButtonList nulo";
                    return false;
                }
                clsLlenarRBList objLlenar = new clsLlenarRBList(strApp);
                objLlenar.SQL = "EXEC USP_jornada_BuscarGeneral";
                objLlenar.CampoID = "Codigo";
                objLlenar.CampoTexto = "Nombre";
                if (!objLlenar.LlenarRadioBL_Web(RBL_A_llenar))
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