using LibConexionBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Clases
{
    class Datos
    {
        private static string mensaje;
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");

        public static string Mensaje { get { return mensaje; } }

        public static bool ValidarUsuario(string usuario,string contrasena)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            conexion.SQL = "select (1) from Usuario where Usuario = '"+
                            usuario+"' and Clave='"+contrasena+"'";

            if (!conexion.ConsultarValorUnico(false)) // false no estamos ejecutando un store procediure
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            if (conexion.ValorUnico==null)
            {
                mensaje = "Usuario o Contrasena no valido";
                conexion.CerrarConexion();
                return false;
            }

            conexion.CerrarConexion();
            return true;


        }


    }
}
