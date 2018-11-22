
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CdContacto
    {
        CdConexion conexion = new CdConexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader filas;
        public void crearContacto(string nit, string nombre, string direccion, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CREAR_CONTACTO";
            comando.Parameters.AddWithValue("@nit", nit);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@correo", correo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void añadirTelefono(string nit, string telefono, string contesta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CREAR_NUM_CONTACTO";
            comando.Parameters.AddWithValue("@nit", nit);
            comando.Parameters.AddWithValue("@num", telefono);
            comando.Parameters.AddWithValue("@contesta", contesta);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable consultaNumeros(string nit)
        {
            DataTable numeros = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONULTA_NUM_CONTACTO";
            comando.Parameters.AddWithValue("@nit", nit);
            filas = comando.ExecuteReader();
            numeros.Load(filas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            filas.Close();

            return numeros;
        }

        public DataTable consultaContacto(string nit)
        {
            DataTable datos = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_CONTACTO";
            comando.Parameters.AddWithValue("@nit", nit);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();

            return datos;
        }

        public void actualizarNumero(int id, string num, string contesta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "ACTUALIZAR_NUMERO";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@numero", num);
            comando.Parameters.AddWithValue("@contesta", contesta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void modificarContacto(string nit, string nombre, string direccion, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "MODIFICAR_CONTACTO";
            comando.Parameters.AddWithValue("@nit", nit);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
