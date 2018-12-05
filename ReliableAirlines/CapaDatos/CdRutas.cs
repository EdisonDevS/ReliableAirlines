using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdRutas
    {
        CdConexion conexion = new CdConexion();
        SqlCommand consultas = new SqlCommand();
        SqlDataReader filas;
        public void CrearRuta(string nombre, int origen, int destino, string estado)
        {
            consultas.Connection = conexion.AbrirConexion();
            consultas.CommandType = CommandType.StoredProcedure;
            consultas.CommandText = "CREAR_RUTA";
            consultas.Parameters.AddWithValue("@nombre", nombre);
            consultas.Parameters.AddWithValue("@origen", origen);
            consultas.Parameters.AddWithValue("@destino", destino);
            consultas.Parameters.AddWithValue("@estado", estado);

            consultas.ExecuteNonQuery();
            consultas.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable ConsultaGralRutas()
        {
            DataTable tabla = new DataTable();
            consultas.Connection = conexion.AbrirConexion();
            consultas.CommandType = CommandType.StoredProcedure;
            consultas.CommandText = "CONSULTA_GENERAL_RUTAS";
            filas = consultas.ExecuteReader();
            tabla.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultaEspecificaRutas(int ruta)
        {
            DataTable tabla = new DataTable();
            consultas.Connection = conexion.AbrirConexion();
            consultas.CommandType = CommandType.StoredProcedure;
            consultas.CommandText = "CONSULTA_ESPECIFICA_RUTAS";
            consultas.Parameters.AddWithValue("@id", ruta);
            filas = consultas.ExecuteReader();
            tabla.Load(filas);
            filas.Close();
            consultas.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public void ActualizarEstadoRuta(int ruta, string estado)
        {
            consultas.Connection = conexion.AbrirConexion();
            consultas.CommandType = CommandType.StoredProcedure;
            consultas.CommandText = "ACTUALIZAR_ESTADO_RUTA";
            consultas.Parameters.AddWithValue("@idRuta", ruta);
            consultas.Parameters.AddWithValue("@estado", estado);
            consultas.ExecuteNonQuery();
            consultas.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable consultaSumaPasajerosMes(int mes, string Año, int ruta)
        {
            DataTable tabla = new DataTable();
            consultas.Connection = conexion.AbrirConexion();
            consultas.CommandType = CommandType.StoredProcedure;
            consultas.CommandText = "CONSULTA_SUM_PASAJEROS_RUTA";
            consultas.Parameters.AddWithValue("@idRuta", ruta);
            consultas.Parameters.AddWithValue("@año", Año);
            consultas.Parameters.AddWithValue("@mes", mes);
            filas = consultas.ExecuteReader();
            tabla.Load(filas);
            filas.Close();
            consultas.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
