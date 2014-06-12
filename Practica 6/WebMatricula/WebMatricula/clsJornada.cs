using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LibLlenarRBList;
namespace WebMatricula
{
    public class clsJornada
    {
         private string strApp;
        private string strSQL;
        private string strError;

        public clsJornada(string NombreApp)
        {
            strApp = NombreApp;
            strSQL = String.Empty;
            strError = String.Empty;

        }

        public string Error
        {
            get { return strError; }
      
        }

        public bool LlenarRBL(RadioButtonList RBL_A_llenar)
        {
            try
            {
                if (RBL_A_llenar == null)
                {
                    strError = "RadioButonList Nulo";
                    return false;
                }
                clsLlenarRBList obj = new clsLlenarRBList(strApp);
                obj.SQL = "EXEC USP_Jornada_BuscarGeneral";
                obj.CampoID = "Codigo";
                obj.CampoTexto = "Nombre";
                if (!obj.LlenarRadioBL_Web(RBL_A_llenar))
                {
                    strError = obj.Error;
                    obj = null;
                    return false;
                }
                obj = null;
                return true;

            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;

            }
        }
    }
}