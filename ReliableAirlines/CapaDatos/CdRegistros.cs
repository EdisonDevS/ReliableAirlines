using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdRegistros
    {
        CdConexion conexion = new CdConexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader filas;

        public void generarRegistroTripulacion(int vuelo, string calificacion, string comentarios, string tripulante)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "GENERAR_INFORME_VUELO";
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.AddWithValue("@numVuelo", vuelo);
            comando.Parameters.AddWithValue("@calificacion", calificacion);
            comando.Parameters.AddWithValue("@comentarios", comentarios);
            comando.Parameters.AddWithValue("@tripulante", tripulante);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void generarRegistroEmpleado(string comentarios, string doc)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "GENERAR_INFORME_EMPLEADO";
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.AddWithValue("@comentarios", comentarios);
            comando.Parameters.AddWithValue("@empleado", doc);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable consultaInformesEmpleados()
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_INFORMES_EMPLEADOS";
            comando.Connection = conexion.AbrirConexion();
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();

            return datos;
        }

        public DataTable consultaInformesVuelos()
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_INFORMES_VUELOS";
            comando.Connection = conexion.AbrirConexion();
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();

            return datos;
        }
    }
}
