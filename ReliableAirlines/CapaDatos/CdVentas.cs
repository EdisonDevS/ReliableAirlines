using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CdVentas
    {
        CdConexion conexion = new CdConexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader filas;

        public void nuevoTiquete(string doc, int estado, int numVuelo, int clase)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "NUEVO_TIQUETE";
            comando.Parameters.AddWithValue("@doc", doc);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@numVuelo", numVuelo);
            comando.Parameters.AddWithValue("@clase", clase);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
