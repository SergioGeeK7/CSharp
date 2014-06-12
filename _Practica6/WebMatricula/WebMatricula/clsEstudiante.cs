using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibConexionBD;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebMatricula
{
    public class clsEstudiante
    {
        #region "Atributos"
        private string strApp;
        private string strCodigo;
        private int intNroDoc;
        private string strNombre;
        private int intPrograma;
        private bool blnActivo;
        private int intJornada;
        private string strObservac;
        private int intFacultad;
        private string strPrograma;
        private string strError;
        private string strSQL;
        private clsConexionBD objCnx;
        private SqlDataReader Reader_Local;
        #endregion
        
        #region "Constructor"
        public clsEstudiante(string NombreApp)
        {
            strApp = NombreApp;
            strCodigo = string.Empty;
            intNroDoc = 0;
            strNombre = string.Empty;
            intPrograma = 0;
            blnActivo = false;
            intJornada = 0;
            strObservac = string.Empty;
            intFacultad = 0;
            strSQL = string.Empty;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"

            public string Carnet
            {
                set { strCodigo = value; }
                get { return strCodigo; }
            }

            public int Nro_Documento
            {
                set { intNroDoc = value; }
                get { return intNroDoc; }
            }

            public string Nombre
            {
                set { strNombre = value; }
                get { return strNombre; }
            }
            public int Programa
            {
                set { intPrograma = value; }
                get { return intPrograma; }
            }

            public bool Activo
            {
                set { blnActivo = value; }
                get { return blnActivo; }
            }

            public int Jornada
            {
                set { intJornada = value; }
                get { return intJornada; }
            }

            public string Observacion
            {
                set { strObservac = value; }
                get { return strObservac; }
            }

            public int Facultad
            {
                set { intFacultad = value; }
                get { return intFacultad; }
            }

            public string Nombre_Programa
            {
                set { strPrograma = value; }
                get { return strPrograma; }
            }

            public string Error
            { get { return strError; } 
            }

        #endregion
        
        #region "Metodos Privados"

        private bool Grabar(string SQL)
        {
            try
            {
                objCnx = new clsConexionBD(strApp);
                objCnx.SQL = SQL;
                if (!objCnx.ConsultarValorUnico(false))
                {
                    strCodigo = objCnx.Valor_Unico.ToString().Trim();
                    objCnx = null;
                    return false;
                }
                strCodigo = objCnx.Valor_Unico.ToString().Trim();
                objCnx = null;
                return true;
                }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
                
            }
        
        }
        
        #endregion
       
        #region "Metodos Publicos"

        public bool BuscarMaestro(string Carnet)
        {
            try
            {
                if (string.IsNullOrEmpty(Carnet))
                {
                    strError = "Carné no Valido";
                    return false;
                }
                strSQL = "EXEC USP_Estudiante_BuscarXCodigo '"+ Carnet +"';";
                objCnx = new clsConexionBD(strApp);
                objCnx.SQL = strSQL;
                if(!objCnx.Consultar(false))
                {
                    strError = objCnx.Error;
                    return false;
                }
                Reader_Local = objCnx.DataReader_Lleno;
                if(!Reader_Local.HasRows)
                {
                    strError = "No se encontro Ningun Registro: " + Carnet;
                    Reader_Local.Close();
                    objCnx = null;
                    return false;
                }
                Reader_Local.Read();
                strCodigo = Reader_Local.GetString(0);
                intNroDoc = Reader_Local.GetInt32(1);
                strNombre = Reader_Local.GetString(2);
                intFacultad = Reader_Local.GetInt32(3);
                intPrograma = Reader_Local.GetInt32(4);
                blnActivo = Reader_Local.GetBoolean(5);
                intJornada = Reader_Local.GetInt32(6);
                strObservac = Reader_Local.GetString(7);
                strPrograma = Reader_Local.GetString(8);
                Reader_Local.Close();
                objCnx = null;
                return true;

            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
                
            }
        }

        public bool GrabarMaestro()
        {
            try
            {
                int Act = (blnActivo) ? 1 : 0;
                strSQL = "EXEC USP_Estudiante_Grabar " +
                         " '" + strCodigo + "', " +
                              intNroDoc + ",  " +
                         " '" + strNombre + "', " +
                              intPrograma + ", " +
                              Act + "," +
                              intJornada + ", " +
                         " '" + strObservac + "'; ";
                return Grabar(strSQL);
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
                
            }
        }
        public bool ModificarMaestro()
        {
            try
            {
                int Act = (blnActivo) ? 1 : 0;
                strSQL = "EXEC USP_Estudiante_Modificar " +
                         " '" + strCodigo + "', " +
                              intNroDoc + ",  " +
                         " '" + strNombre + "', " +
                              intPrograma + ", " +
                              Act + "," +
                              intJornada + ", " +
                         " '" + strObservac + "'; ";
                return Grabar(strSQL);
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