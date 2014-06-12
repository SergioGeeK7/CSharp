using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibConexionBD;

namespace Q
{
    public class Login
    {

        private string mensaje;
        private string nombreApp;
        private int codEmpleado;
        private string nombreUsuario;


        public Login(string nombreApp)
        {
            this.nombreApp = nombreApp;
        }


        public int CodEmpleado
        {
            get { return codEmpleado; }
            set { codEmpleado = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public  bool logear(string usuario,string password)
        {


            try
            {
                string sql = "EXEC Login "+usuario+", '" + password+"'";

                // SELECT codEmpleado FROM empleados WHERE usuario='' AND password=''

                clsConexionBD obj = new clsConexionBD(nombreApp);
                obj.SQL = sql;
                if (!obj.ConsultarValorUnico(false))
                {
                    // segun lo que devuelva es el error
                    this.mensaje=obj.Error;
                    obj = null;
                    return false;
                }
                
               

                if (obj.Valor_Unico != null)
                {
                    this.codEmpleado = Convert.ToInt32(obj.Valor_Unico.ToString().Trim());
                    obj = null;
                    return true;
                }

                 return false;
                 obj = null;
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                return false;

            }


        }


    }
}