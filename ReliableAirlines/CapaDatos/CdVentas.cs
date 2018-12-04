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

                MessageBox.Show("La reserva se ha realizado de forma exitosa\n" + "Su código único de reserva es: " +
                    Int32.Parse(prueba.Rows[0]["idTiquete"].ToString()) + 1);
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

        public DataTable obtenerInfoVenta(int reserva)
        {
            DataTable resultados = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INFO_VENTA";
            comando.Parameters.AddWithValue("@id", reserva);
            filas = comando.ExecuteReader();
            resultados.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();

            return resultados;
        }

        public DataTable obtenerInfoVentaReembolso(int reserva)
        {
            DataTable resultados = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_TIQUETE_REEMBOLSO";
            comando.Parameters.AddWithValue("@id", reserva);
            filas = comando.ExecuteReader();
            resultados.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();

            return resultados;
        }

        public void validarReserva(int reserva)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VALIDAR_TIQUETE";
            comando.Parameters.AddWithValue("@id", reserva);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
            comando.Parameters.Clear();

            MessageBox.Show("Reserva validada exitosamente!!!");
            
        }

        public DataTable consultarVentas(string inicio, string final)
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTAR_VENTAS";
            comando.Parameters.AddWithValue("@inicio", inicio);
            comando.Parameters.AddWithValue("@final", final);

            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return datos;
        }

        public void gererarReembolso(string aut, string justifica, int tiquete)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GENERAR_REEMBOLSO";
            comando.Parameters.AddWithValue("@autoriza", aut);
            comando.Parameters.AddWithValue("@justificacion", justifica);
            comando.Parameters.AddWithValue("@tiquete", tiquete);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
        }

        public DataTable consultarReembolsos(string inicio, string final)
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTAR_REEMBOLSOS";
            comando.Parameters.AddWithValue("@inicio", inicio);
            comando.Parameters.AddWithValue("@final", final);

            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return datos;
        }

        public DataTable consultaJustificacion(int tiquete)
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_JUSTIFICACION_REEMBOLSO";
            comando.Parameters.AddWithValue("@id", tiquete);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return datos;
        }

        public DataTable consultaIDTiquete(int vuelo, string doc)
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_ID_TIQUETE";
            comando.Parameters.AddWithValue("@vuelo", vuelo);
            comando.Parameters.AddWithValue("@doc", doc);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return datos;
        }
    }
}
