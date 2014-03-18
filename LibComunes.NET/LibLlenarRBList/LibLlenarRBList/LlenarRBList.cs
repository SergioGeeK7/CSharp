using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibConexionBD;
using System.Web.UI.WebControls;

namespace LibLlenarRBList
{
    public class LlenarRBList
    {
        #region "Atributos"
        private string archivoParametros;
        private string sql;
        private string campoID;
        private string campoTexto;
        private string error;
        #endregion

        #region "Propiedades"
        public string SQL
        { 
            set { sql = value; } 
        }
        public string CampoID
        { 
            set { campoID = value; } 
        }
        public string CampoTexto
        { 
            set { campoTexto = value; } 
        }
        public string Error
        { 
            get { return error; } 
        }
        #endregion

        #region "Constructor"
        public LlenarRBList(string archivoParametros)
        {
            this.archivoParametros = archivoParametros;
            sql = string.Empty;
            campoID = string.Empty;
            campoTexto = string.Empty;
            error = string.Empty;
        }
        #endregion

        #region "Métodos Privados"
        private bool Validar()
        {
            if (string.IsNullOrEmpty(sql))
            {
                error = "Debe definir una instrucción SQL";
                return false;
            }
            if (string.IsNullOrEmpty(campoID))
            {
                error = "Debe definir el nombre del Campo con la PK(Id)";
                return false;
            }
            if (string.IsNullOrEmpty(campoTexto))
            {
                error = "Debe definir el nombre del Campo con valores Texto";
                return false;
            }
            return true;
        }
        #endregion

        #region "Métodos Públicos"
        public bool LlenarRadioBLWeb(RadioButtonList Generico)
        {
            if (!Validar()) return false;

            ConexionBD conexion = new ConexionBD(archivoParametros);
            conexion.SQL = sql;
            if (!conexion.LlenarDataSet(false))
            {
                error = conexion.Error;
                conexion.CerrarConexion();
                conexion = null;
                return false;
            }
            Generico.DataSource = conexion.Ds.Tables[0];
            Generico.DataValueField = campoID;
            Generico.DataTextField = campoTexto;
            Generico.DataBind();
            conexion.CerrarConexion();
            conexion = null;
            return true;
        }
        #endregion
    }
}
