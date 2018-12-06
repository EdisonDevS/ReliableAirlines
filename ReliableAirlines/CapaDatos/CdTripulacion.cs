using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdTripulacion
    {

        CdConexion conexion = new CdConexion();
        SqlDataReader fila;
        SqlCommand comando = new SqlCommand();

        public DataTable ConsultarTripulantes(int vuelo)
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_TRIPULANTE";
            comando.Parameters.AddWithValue("@vuelo", vuelo);
            comando.Connection = conexion.AbrirConexion();
            fila = comando.ExecuteReader();
            datos.Load(fila);
            fila.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return datos;
        }

        public void AgregarTripulanteAvuelo(string doc, int vuelo, string rol)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INGRESO_TRIPULANTE";
            comando.Parameters.AddWithValue("@documento", doc);
            comando.Parameters.AddWithValue("@vuelo", vuelo);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable CargarTripulante(string doc)
        {
            DataTable resultado = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CARGAR_TRIPULANTE";
            comando.Parameters.AddWithValue("@doc", doc);
            fila = comando.ExecuteReader();
            resultado.Load(fila);
            fila.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return resultado;
        }

        public DataTable tripulantes()
        {
            DataTable resultado = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SOLICITAR_TRIPULANTES";
            fila = comando.ExecuteReader();
            resultado.Load(fila);
            fila.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return resultado;
        }
        
    }
}
