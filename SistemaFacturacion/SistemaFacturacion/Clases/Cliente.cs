using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFacturacion.Clases.DSFacturacionTableAdapters;

namespace SistemaFacturacion.Clases
{
    class Cliente
    {
        private static ClienteTableAdapter adaptador = new ClienteTableAdapter();

        public static void NuevoCliente(string IDCliente, string Nombres, string Apellidos,
                string Direccion, string Telefono, string Correo, string fechaNacimiento, int Cupo)
        {
            // Querys del DATAset
            adaptador.NuevoCliente(IDCliente, Nombres, Apellidos,
                Direccion, Telefono, Correo, fechaNacimiento, Cupo);
        }

        public static void ActualizarCliente(string IDCliente, string Nombres, string Apellidos,
                string Direccion, string Telefono, string Correo, string fechaNacimiento, int Cupo)
        {
            adaptador.ActualizarCliente(Nombres, Apellidos, Direccion, Telefono, Correo, fechaNacimiento, Cupo,
                IDCliente);
        }

        public static void EliminarCliente(string IDCliente)
        {
            adaptador.EliminarCliente(IDCliente);
        }

        public static bool ExisteCliente(string IDCliente)
        {
            return adaptador.ExisteCliente(IDCliente) == 1; // crear un booleano 
        }

    }
}
