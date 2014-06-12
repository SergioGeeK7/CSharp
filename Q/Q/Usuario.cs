using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LibConexionBD;
using LibLlenarGrids;

namespace Q
{
    public class Usuario
    {
        private int id;
        private string nombres;
        private string apellidos;
        private int cedula;
        private string error;
        private string strApp;

        // para mas info formEstudiante menu
        // dgv formMatricula

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Error
        {
            get { return error; }
        }

        public Usuario(string strApp)
        {
            this.strApp = strApp;
        }




        public bool getUsuario(int cedula)
        {

            clsConexionBD obj = new clsConexionBD(strApp);

            // EXEC USP_Estudiante_BuscarXCodigo
            obj.SQL = "SELECT * FROM usuarioss WHERE id="+cedula;
            if (!obj.Consultar(false))
            {
                error = obj.Error;
                return false;
            }


            if (!obj.DataReader_Lleno.HasRows)
            {
                error = "No se encontro Ningun Registro: " + Cedula;
                obj.DataReader_Lleno.Close();
                obj = null;
                return false;
            }

            obj.DataReader_Lleno.Read();
            id = obj.DataReader_Lleno.GetInt32(0);
            nombres = obj.DataReader_Lleno.GetString(1);
            apellidos = obj.DataReader_Lleno.GetString(2);
            this.cedula = obj.DataReader_Lleno.GetInt32(3);
            obj.DataReader_Lleno.Close();
            obj = null;
            return true;

        }


        public bool ModificarUsuario()
        {
            try
            {
                // EXEC USP_Estudiante_Modificar
                string sql = "sql para modificar usuario";
              
                return Grabar(sql);
            }
            catch (Exception ex)
            {

                error = ex.Message;
                return false;
            }
        }


        public bool GrabarUsuario()
        {
            try
            {
                // int Act = (blnActivo) ? 1 : 0;
                // EXEC USP_Esudiante_Grabar


                string strSQL = "sql para grabar nuevo usuario";
                return Grabar(strSQL);


            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;

            }

        }



        private bool Grabar(string sql)
        {
            try
            {
                clsConexionBD obj = new clsConexionBD(strApp);
                obj.SQL = sql;
                if (!obj.ConsultarValorUnico(false))
                {
                   // segun lo que devuelva es el error
                  //  cedula = obj.Valor_Unico.ToString().Trim(); 
                    obj = null;
                    return false;
                }
                cedula = Convert.ToInt32(obj.Valor_Unico.ToString().Trim());
                obj = null;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;

            }
        }


        public bool LlenaGridview(GridView Grid_A_llenar)
        {
            try
            {
                if (Grid_A_llenar == null)
                {
                    error = "Grid es Nulo";
                    return false;
                }
              //  strSQL = "EXEC USP_Matricula_LlenarGrid '" + strCarnet + "', " + intPeriodo + ";";
              // segun el carnet y periodo llenaba las materias.... 

                string strSQL = "SELECT * FROM usuarioss";
                clsLlenarGrids obj = new clsLlenarGrids(strApp);
                obj.SQL = strSQL;
                if (!obj.LlenarGrid_Web(Grid_A_llenar))
                {
                    error = obj.Error;
                    obj = null;
                    return false;
                }
                obj = null;
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;

            }

        }






    }
}