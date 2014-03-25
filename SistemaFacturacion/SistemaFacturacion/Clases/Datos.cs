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



        internal static bool ProductoNuevo(Producto producto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }


            conexion.SQL = "select * from Producto "+
                           "INSERT INTO Producto (Descripcion,Precio,Stock,Notas,IDIVA,IDDepartamento)"+
                           "values ('"+producto.Descipcion+"',"+producto.Precio+","+producto.Stock+
                           ",'"+producto.Notas+"',"+producto.Idiva+","+producto.IdDepartamento+")";
            if (!conexion.EjecutarSentencia(false)) // store procedure ?
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            mensaje = "Producto Ingresado Correctamente";
            conexion.CerrarConexion();
            return true;
        }

        internal static bool ActualizarProducto(Producto producto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }


            conexion.SQL = "UPDATE Producto SET " +
                           "Descripcion = '" + producto.Descipcion +
                           "',Precio =" + producto.Precio +
                           ",Stock = " + producto.Stock + 
                           ",Notas ='" + producto.Notas + "'," +
                           "IDIVA=" + producto.Idiva + 
                           ",IDDepartamento = " + producto.IdDepartamento +
                           " WHERE IDProducto = " + producto.IdProducto + "";
            
            
            if (!conexion.EjecutarSentencia(false)) // store procedure ?
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            mensaje = "Producto Actualizado Correctamente";
            conexion.CerrarConexion();
            return true;


        }

        internal static bool EliminarProducto(int idProducto)
        {

            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }


            conexion.SQL = "DELETE FROM Producto " +
                           "WHERE IDProducto = " + idProducto;


            if (!conexion.EjecutarSentencia(false)) // store procedure ?
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            mensaje = "Producto Eliminado Correctamente";
            conexion.CerrarConexion();
            return true;

        }

        public static Usuario GetUsuario(string idUsuario)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return null;
            }

            conexion.SQL = "select * from Usuario where Usuario = '"+idUsuario+"'";

            if (!conexion.LlenarDataSet(false)) // false no estamos ejecutando un store procediure
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return null;
            }

            if (conexion.Ds == null)
            {
                mensaje = "Usuario no existe";
                conexion.CerrarConexion();
                return null;
            }

            if (conexion.Ds.Tables[0].Rows.Count == 0) // dataset tiene una coleccion. varias tablas
                                                       // un dataset esta compuesto por varias tablas
                                                        // como estamos haciendo una consulta de una sola tabla tables[0]
                                                        // dentro de las tablas hay una coleccion llamada Rows 
                                                        // Rows == numero de filas de cada tabla
            {
                mensaje = "Usuario no existe";
                conexion.CerrarConexion();
                return null;
            }

            Usuario usuario = new Usuario();
                                // dataset rows[0]primer fila -> ItemArray[0] cada campo -> 
            usuario.IdUsuario = conexion.Ds.Tables[0].Rows[0].ItemArray[0].ToString();
            usuario.Clave= conexion.Ds.Tables[0].Rows[0].ItemArray[1].ToString();
            usuario.Nombres= conexion.Ds.Tables[0].Rows[0].ItemArray[2].ToString();
            usuario.Apellidos = conexion.Ds.Tables[0].Rows[0].ItemArray[3].ToString();
            usuario.IdPerfil =  (int)conexion.Ds.Tables[0].Rows[0].ItemArray[4];
            conexion.CerrarConexion();
            return usuario;
        }



    }
}
