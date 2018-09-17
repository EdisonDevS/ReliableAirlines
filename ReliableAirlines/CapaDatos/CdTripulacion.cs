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

        public DataTable ConsultarTripulante(string documento)
        {
            DataTable resultado = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_TRIPULANTE";
            comando.Parameters.AddWithValue("@documento", documento);
            fila = comando.ExecuteReader();
            resultado.Load(fila);
            fila.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return resultado;
        }

        public void AgregarTripulanteAvuelo(string doc, int vuelo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "INGRESO_TRIPULANTE";
            comando.Parameters.AddWithValue("@documento", doc);
            comando.Parameters.AddWithValue("@vuelo", vuelo);
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
        
    }
}
