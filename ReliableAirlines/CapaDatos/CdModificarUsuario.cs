using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdModificarUsuario
    {
        CdConexion conexion = new CdConexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader fila;

        public DataTable cargaDatos(string documento)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_DATOS_EMPLEADO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@document", documento);
            fila = comando.ExecuteReader();
            tabla.Load(fila);
            fila.Close();
            conexion.CerrarConexion();

            return tabla;
        }
    }
}
