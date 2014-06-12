using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LibLlenarCombos;

namespace WebMatricula
{
    public class clsAsignatura
    {
        private string strApp;
        private string strSQL;
        private string strError;

        public clsAsignatura(string NombreApp)
        {
            strApp = NombreApp;
            strSQL = String.Empty;
            strError = String.Empty;

        }

        public string Error
        {
            get { return strError; }
      
        }

        public bool LlenarCombo(DropDownList Combo_A_llenar, int XX )
        {
            try
            {
                if (Combo_A_llenar == null)
                {
                    strError = "Combo Nulo";
                    return false;
                }
                clsLlenarCombos obj = new clsLlenarCombos(strApp);
                obj.SQL = "USP_Asignatura_LlenarCombo " + XX;
                obj.CampoID = "Codigo";
                obj.CampoTexto = "Nombre";
                if (!obj.LlenarCombo_Web(Combo_A_llenar))
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