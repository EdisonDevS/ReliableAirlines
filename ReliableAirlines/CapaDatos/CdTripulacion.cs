using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class CdTripulacion
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
    }
}
