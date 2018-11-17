using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CdVentas
    {
        CdConexion conexion = new CdConexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader filas;

        public void nuevoTiquete(string doc, int estado, int numVuelo, int clase)
        {
            DataTable prueba = new DataTable();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM TIQUETE WHERE docCliente='" + doc + "' AND numVuelo=" + numVuelo + " ORDER BY idTiquete DESC";
            comando.Connection = conexion.AbrirConexion();
            prueba.Load(comando.ExecuteReader());
            conexion.CerrarConexion();

            if (prueba.Rows.Count > 0 && (Int32.Parse(prueba.Rows[0]["estadoDeReserva"].ToString()) != 4 && Int32.Parse(prueba.Rows[0]["estadoDeReserva"].ToString()) != 5))
            {
                MessageBox.Show("Ya tiene un puesto reservado en este vuelo");
            }
            else
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "NUEVO_TIQUETE";
                comando.Parameters.AddWithValue("@doc", doc);
                comando.Parameters.AddWithValue("@estado", estado.ToString());
                comando.Parameters.AddWithValue("@numVuelo", numVuelo);
                comando.Parameters.AddWithValue("@clase", clase);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                MessageBox.Show("La reserva se ha realizado de forma exitosa");
            }
        }

        public void cancelacionDeTiquete(string documento, int vuelo)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CANCELAR_TIQUETE";
            comando.Parameters.AddWithValue("@doc", documento);
            comando.Parameters.AddWithValue("@vuelo", vuelo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
