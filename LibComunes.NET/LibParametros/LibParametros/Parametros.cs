using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.Windows.Forms;


namespace LibParametros
{   // ESTA CLASE GENERA EL STRING DE CONEXION
    public class Parametros
    {
        #region "Atributos"
        private string servidor; // COMO SE LLAMA EL SERVIDOR (.) O ES LOCALHOST
        private string baseDatos; // COMO SE LLAMA LA DB
        private string usuario; // SI SEGURIDAD INTEGRADA ESTA ACTIVA
        private string clave;   // SI SEGURIDAD INTEGRADA ESTA ACTIVA
        private bool seguridadIntegrada; // CON AUTENCITACION WINDOWS O AUTENTICACION POR USUARIO
        private string archivoParametros; // ARCHIVO DE PAREMETROS SQL ESTEN EXTERNOS EN UN XML
        private string cadenaConexion;// LA QUE GENERA
        private string error;
        private XmlDocument xml = new XmlDocument();// LA REPRESENTACION DEL ARCHIVO XML EN MEMORIA COMO UN OBJETO
        private XmlNode nodo;// PARA LEER LAS LLAVES DEL XML
        #endregion

        #region "Constructor"
        public Parametros()
        {
            servidor = "";
            baseDatos = "";
            usuario= "";
            clave = "";
            seguridadIntegrada =true;
            archivoParametros = "";
            cadenaConexion = "";
            error = "";
        }
        #endregion

        #region "Propiedades"
        public string CadenaConexion
        {
            get { return cadenaConexion; }
        }
        public string Error
        {
            get { return error; }
        }
        #endregion

        #region "Métodos públicos"
        public bool GenerarCadenaConexion(string nombreArchivoParametros)
        {
            archivoParametros = Application.StartupPath + "\\" + nombreArchivoParametros;
            try
            {
                xml.Load(archivoParametros);
                nodo = xml.SelectSingleNode("//Servidor");
                servidor = nodo.InnerText;
                nodo = xml.SelectSingleNode("//BaseDatos");
                baseDatos = nodo.InnerText;
                nodo = xml.SelectSingleNode("//Usuario");
                usuario = nodo.InnerText;
                nodo = xml.SelectSingleNode("//Clave");
                clave = nodo.InnerText;
                nodo = xml.SelectSingleNode("//SeguridadIntegrada");
                seguridadIntegrada = Convert.ToBoolean(nodo.InnerText);

                if (seguridadIntegrada) // Autenticacion Windows
                {
                    cadenaConexion = "Data Source=" + servidor
                        + ";Initial Catalog=" + baseDatos
                        + ";Integrated Security=True";
                }
                else // Autenticacion SQL
                {
                    cadenaConexion = "Data Source=" + servidor
                        + ";Initial Catalog=" + baseDatos
                        + ";User Id=" + usuario
                        + ";Password=" + clave
                        + ";Integrated Security=False";
                }
                xml = null;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                xml = null;
                return false;
            }
        }
        #endregion
    }
}
