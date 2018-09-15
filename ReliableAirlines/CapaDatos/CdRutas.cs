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
    }
}
