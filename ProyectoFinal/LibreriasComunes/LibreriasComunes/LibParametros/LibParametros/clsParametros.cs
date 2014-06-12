using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Referenciar y usar
using System.Xml;
using System.Windows.Forms;


namespace LibParametros
{
    public class clsParametros
    {

    #region "Atributos"
        private string strServidor;
        private string strBaseDatos;
        private string strUsuario;
        private string strClave;
        private string strSegInt;
        private string strArchivoXml;
        private string strCadCnx;
        private string strError;
        private XmlDocument objDoc = new XmlDocument();
        private XmlNode objNodo;
    #endregion

    #region "Constructor"
        public  clsParametros()
        {   strServidor = String.Empty;
            strBaseDatos = String.Empty;
            strUsuario = String.Empty;
            strClave = String.Empty;
            strSegInt = String.Empty;
            strArchivoXml = String.Empty;
            strCadCnx = String.Empty;
            strError = String.Empty;
        }
    #endregion

    #region "Propiedades"
        public string  CadenaCnx
        {   get { return strCadCnx;   }       }
        public string Error
        {   get { return  strError;   }       }
    #endregion

    #region "Métodos Públicos"
        public bool GenerarCadenaCnx( string  strNombreAplicacion )
        {
            try
            {
                if ( string.IsNullOrEmpty( strNombreAplicacion ) )
                {
                    strError = "Sin Nombre de la aplicación";
                    return false;
                }
                strArchivoXml = Application.StartupPath + "\\CON_" + strNombreAplicacion + ".xml";
                objDoc.Load( strArchivoXml );
                objNodo = objDoc.SelectSingleNode("//Servidor");
                strServidor = objNodo.InnerText;
                objNodo = objDoc.SelectSingleNode("//BaseDatos");
                strBaseDatos = objNodo.InnerText;
                objNodo = objDoc.SelectSingleNode("//Usuario");
                strUsuario = objNodo.InnerText;
                objNodo = objDoc.SelectSingleNode("//Clave");
                strClave = objNodo.InnerText;
                objNodo = objDoc.SelectSingleNode("//SeguridadIntegrada");
                strSegInt = objNodo.InnerText;

                if ( strSegInt.ToLower() == "no" )   //Autenticación SQL SERVER   //ToLower convierte la cadena en minúscula
                    strCadCnx = "Data Source=" + strServidor + "; Initial Catalog=" + strBaseDatos + "; User Id =" + strUsuario + "; Password=" + strClave + ";";
                else   //Autenticación  Windows
                    strCadCnx = "Data Source=" + strServidor + "; Initial Catalog=" + strBaseDatos + "; Integrated Security=SSPI;"; 
                objDoc = null;
                return true;
            }
            catch ( Exception ex )
            {
                strError = ex.Message;
                objDoc = null;
                return false;
            }
        }
    #endregion
    }
}
