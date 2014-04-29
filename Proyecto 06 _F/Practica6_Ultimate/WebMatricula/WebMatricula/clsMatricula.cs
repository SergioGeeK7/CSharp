using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using LibConexionBD;
using LibLlenarGrids;
namespace WebMatricula
{
    public class clsMatricula
    {
        #region "Atributos"
        private string strApp;
        private int intPeriodo;
        private string strCarnet;
        private string strAsignatura;
        private string strNombre;
        private int intPrograma;
        private string strSQL;
        private string strError;
        private clsConexionBD objCnx;
        private SqlDataReader Reader_Local;
        #endregion

        #region "Constructor"
        public clsMatricula(string NombreApp)
        {
            strApp = NombreApp;
            intPeriodo = 0;
            strCarnet = string.Empty;
            strAsignatura = string.Empty;
            strNombre = String.Empty;
            intPrograma = 0;
            strSQL = String.Empty;
            strError = String.Empty;
        }
        #endregion


        #region "Propiedades"
        public int Periodo
        {
            set { intPeriodo = value; }
            get { return intPeriodo; }
        }
        public string Carnet
        {
            set { strCarnet = value; }
            get { return strCarnet; }
        }
        public string Asignatura
        {
            set { strAsignatura = value; }
            get { return strAsignatura; }
        }
        public int Programa
        {
            get { return intPrograma; }
        }
        public string Nombre
        {
            get { return strNombre; }
        }
        public string Error
        {
            get { return strError; }
        }
        #endregion


        #region "Metodos Privados"
        public bool Grabar(string SQL)
        {
            try
            {
                objCnx = new clsConexionBD(strApp);
                objCnx.SQL = SQL;
                if (!objCnx.ConsultarValorUnico(false))
                {
                    strError = objCnx.Error;
                    objCnx = null;
                    return false;
                }
                strCarnet = objCnx.Valor_Unico.ToString().Trim();
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


        #region "Metodos Públicos"
        private bool BuscarMaestro() 
        {
            try
            {
                if (string.IsNullOrEmpty(strCarnet)) 
                {
                    strError = "Parametro no Valido";
                    return false;
                }
                strSQL = "EXEC USP_Matricula_Buscar '" + strCarnet + "'," + intPeriodo + ";";
                objCnx = new clsConexionBD(strApp);
                objCnx.SQL = strSQL;
                if(!objCnx.Consultar(false))
                {
                    strError = objCnx.Error;
                    return false;
                }
                Reader_Local = objCnx.DataReader_Lleno;
                if (!Reader_Local.HasRows)
                {
                    strError = "No se encontro Ningun Registro: " + strCarnet;
                    Reader_Local.Close();
                    objCnx = null;
                    return false;
                }
                Reader_Local.Read();
                strNombre = Reader_Local.GetString(0);
                intPrograma = Reader_Local.GetInt32(1);
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
                strSQL = "EXEC USP_Matricula_Grabar " +
                                     intPeriodo + ", " +
                         " '" + strCarnet + "', " +
                         " '" + strAsignatura + "'; ";

                return Grabar(strSQL);
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
                
            }
        }
        public bool LlenarGrid(GridView Grid_A_llenar)
        {
            try
            {
                if(Grid_A_llenar==null)
                {
                    strError = "Grid es Nulo";
                    return false;
                }
                strSQL = "EXEC USP_Matricula_LlenarGrid '" + strCarnet + "', " + intPeriodo + ";";
                clsLlenarGrids objllenar = new clsLlenarGrids(strApp);
                objllenar.SQL = strSQL;
                if(!objllenar.LlenarGrid_Web(Grid_A_llenar))
                {
                    strError = objllenar.Error;
                    objllenar = null;
                    return false;
                }
                objllenar = null;
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