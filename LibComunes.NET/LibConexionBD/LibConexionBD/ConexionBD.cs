using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibParametros; // una libreria esta usando otra libreria que usa otra libreria otra otra otra otra otra otra otra

namespace LibConexionBD
{
    public class ConexionBD
    {
        #region "Atríbutos"
        private string archivoParametros;
        private string cadenaConexion; // string de conexion para sql server, mysql posgrest oracle
        private object valorUnico; // SI SOLO DEVUELVE UN mero valor ; object para luego castearlo como el tipo de dato esperado
        private string sql;// el    Query
        private string error;
        private bool hayConexion;// si no hay coneccion conectarme si hago una consulta
        private SqlConnection cnn; // permite engancharme a la base de datos, establece la conexion
        private SqlCommand cmd; // delete from productos (valas) -- son los comandos que le tiro a la db
        private SqlDataReader dr; // -- aqui devuelve para mas datos
        private SqlDataAdapter da; // tirale conecciones .... (pistola)
        private DataSet ds; // select * from productos ...-- aqui los devuelve
        #endregion

        #region "Propiedades"
        public string SQL
        {
            set { sql = value; }
        }
        public object ValorUnico
        {
            get { return valorUnico; }
        }
        public SqlDataReader Dr
        {
            get { return dr; }
        }
        public SqlConnection Cnn
        {
            get { return cnn; }
        }
        public DataSet Ds
        {
            get { return ds; }
        }
        public SqlDataAdapter Da
        {
            get { return da; }
        }
        public string Error
        {
            get { return error; }
        }
        #endregion

        #region "Constructor"
        public ConexionBD(string archivoParametros)
        {
            this.archivoParametros = archivoParametros;
            hayConexion = false;
            cnn = new SqlConnection(); // nos sirve para abrir la conexion
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            ds = new DataSet();
        }
        #endregion

        #region "Métodos Privados"
        private bool GenerarCadenaConexion()
        {
            try
            {
                Parametros parametros = new Parametros();
                if (!parametros.GenerarCadenaConexion(archivoParametros))
                {
                    error = parametros.Error;
                    parametros = null;
                    return false;
                }
                cadenaConexion = parametros.CadenaConexion;
                parametros = null;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        #endregion

        #region "Métodos Públicos"
        public bool AbrirConexion()
        {
            if (!GenerarCadenaConexion()) return false;

            cnn.ConnectionString = cadenaConexion;
            try
            {
                cnn.Open();
                hayConexion = true;
                return true;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                hayConexion = false;
                return false;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                cnn.Close(); // EL PROGRAMA FUNCIONE FUNCIONE CUANDO PUCK SE REVENTA LA APLICACION;POR EL PULL DE CONEXIONES 
                             // HABIERTAS Y NO CERRADAS
                hayConexion = false;
            }
            catch (Exception ex)
            {
                error = "No se cerró o liberó la conexión, " + ex.Message;
            }
        }

        public bool Consultar(bool blnParametros)
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                {
                    error = "No definió la instrucción SQL";
                    return false;
                }
                if (!hayConexion)
                {
                    if (!AbrirConexion())
                        return false;
                }

                //Preparar el Comando para ejecutar la transacción SQL en la BD
                cmd.Connection = cnn;
                cmd.CommandText = sql;
                if (blnParametros)
                    cmd.CommandType = CommandType.StoredProcedure;
                else
                    cmd.CommandType = CommandType.Text;

                //Realizar la transacción en la BD
                dr = cmd.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool ConsultarValorUnico(bool blnParametros) // ejecuta el SQLQuery para valorUnico
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                {
                    error = "No definió la instrucción SQL";
                    return false;
                }
                if (!hayConexion)
                {
                    if (!AbrirConexion()) return false;
                }

                //Preparar el Comando para ejecutar la transacción SQL en la BD
                cmd.Connection = cnn; // el que permite conectarnos a la db
                cmd.CommandText = sql; // le cargamos la el Query
                if (blnParametros)
                    cmd.CommandType = CommandType.StoredProcedure;
                else
                    cmd.CommandType = CommandType.Text;

                //Realizar la transacción en la BD
                valorUnico = cmd.ExecuteScalar(); // tira el Query y queda en el objeto valor unico
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool EjecutarSentencia(bool blnParametros)
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                {
                    sql = "No definió la instrucción SQL";
                    return false;
                }
                if (!hayConexion)
                {
                    if (!AbrirConexion()) return false;
                }

                //Preparar el Comando para ejecutar la transacción SQL en la BD
                cmd.Connection = cnn;
                cmd.CommandText = sql;
                if (blnParametros)
                    cmd.CommandType = CommandType.StoredProcedure;
                else
                    cmd.CommandType = CommandType.Text;

                //Realizar la transacción en la BD
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool LlenarDataSet(bool blnParametros)
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                {
                    sql = "No definió la instrucción SQL";
                    return false;
                }
                if (!hayConexion)
                {
                    if (!AbrirConexion()) return false;
                }

                //Preparar el Comando para el DataAdapter
                cmd.Connection = cnn;
                cmd.CommandText = sql;
                if (blnParametros)
                    cmd.CommandType = CommandType.StoredProcedure;
                else
                    cmd.CommandType = CommandType.Text;

                //Preparar el DataAdapter parael uso del comando en la BD
                da.SelectCommand = cmd; //El DataAdapter Utiliza el Command para la transacción
                //Realizar la transacción en la BD y el llenado del DataSet/Datatable
                ds.Clear();
                da.Fill(ds); // llenar el dataset
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
