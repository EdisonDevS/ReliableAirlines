using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdMovimientosFinancieros
    {
        SqlCommand comando = new SqlCommand();
        CdConexion conexion = new CdConexion();
        public void nuevoMovimiento(string descripcion, string valor, string destino, int tipo, string fecha)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "MOVIMIENTO_FINANCIERO";
            comando.Parameters.AddWithValue("@desc", descripcion);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@destino", destino);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void generarPagosPendientes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "GENERAR_PAGOS";
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
    }
}
