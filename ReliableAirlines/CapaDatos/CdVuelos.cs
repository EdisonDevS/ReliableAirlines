using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdVuelos
    {
        CdConexion conexion = new CdConexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader filas;

        public void CrearVuelo(int numVuelo, int idRuta, string idAeronave, string salida, string llegada, 
                               string vlrPclase, string vlrCturista)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CREAR_VUELO";
            comando.Parameters.AddWithValue("@numVuelo", numVuelo);
            comando.Parameters.AddWithValue("@idRuta", idRuta);
            comando.Parameters.AddWithValue("@idAeronave", idAeronave);
            comando.Parameters.AddWithValue("@pClase", 0);
            comando.Parameters.AddWithValue("@tClase", 0);
            comando.Parameters.AddWithValue("@salida", salida);
            comando.Parameters.AddWithValue("@llegada", llegada);
            comando.Parameters.AddWithValue("@vlrPrimeraClase", vlrPclase);
            comando.Parameters.AddWithValue("@vlrClaseTurista", vlrCturista);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void ActualizarVuelo(int numVuelo, int idRuta, string idAeronave, string salida, string llegada,
                               string vlrPclase, string vlrCturista)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "ACTUALIZAR_DATOS_VUELO";
            comando.Parameters.AddWithValue("@vuelo", numVuelo);
            comando.Parameters.AddWithValue("@idRuta", idRuta);
            comando.Parameters.AddWithValue("@idAer", idAeronave);
            comando.Parameters.AddWithValue("@pClase", 0);
            comando.Parameters.AddWithValue("@tClase", 0);
            comando.Parameters.AddWithValue("@salida", salida);
            comando.Parameters.AddWithValue("@llegada", llegada);
            comando.Parameters.AddWithValue("@vlrPrimeraClase", vlrPclase);
            comando.Parameters.AddWithValue("@vlrClaseTurista", vlrCturista);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable CargarDatos(int numVuelo)
        {
            DataTable resultado = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CARGAR_DATOS_VUELO";
            comando.Parameters.AddWithValue("@vuelo", numVuelo);
            filas = comando.ExecuteReader();
            resultado.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return resultado;
        }

        public DataTable CargarDatosPorAeropuerto(int aerOrigen, int aerDestino)
        {
            DataTable resultado = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CARGAR_DATOS_VUELO_AERO";
            comando.Parameters.AddWithValue("@origen", aerOrigen);
            comando.Parameters.AddWithValue("@destino", aerDestino);
            filas = comando.ExecuteReader();
            resultado.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return resultado;
        }

        public DataTable CargarVuelosFecha(string fecha, int salida, int llegada)
        {
            DataTable datos = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_VUELO_FECHA";
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@aerSalida", salida);
            comando.Parameters.AddWithValue("@aerLlegada", llegada);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return datos;
        }

        public DataTable ConsultaVuelosPendientes(string documento)
        {
            DataTable resultado = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "VUELOS_PENDIENTES";
            comando.Parameters.AddWithValue("@doc", documento);
            filas = comando.ExecuteReader();
            resultado.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return resultado;
        }

        public DataTable ConsultaHistorialVuelos(string documento)
        {
            DataTable resultado = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "HISTORIAL_VUELOS";
            comando.Parameters.AddWithValue("@doc", documento);
            filas = comando.ExecuteReader();
            resultado.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return resultado;
        }

        public DataTable cargarVuelosTripulante(string doc, int caso)
        {
            DataTable datos = new DataTable();

            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();

            if(caso==1)
            {
                comando.CommandText = "CONSULTA_VUELOS_PASADOS_TRIPULANTE";
            }
            else
            {
                comando.CommandText = "CONSULTA_VUELOS_FUTUROS_TRIPULANTE";
            }
            comando.Parameters.AddWithValue("@doc", doc);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return datos;
        }

        public DataTable cargarVuelosTripulanteInfo(int vuelo)
        {
            DataTable datos = new DataTable();

            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_ESPECIFICA_VUELO_TRIPULANTE";
            comando.Parameters.AddWithValue("@vuelo", vuelo);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return datos;
        }

        public DataTable datosPersonalesTripulacion(int vuelo)
        {
            DataTable datos = new DataTable();

            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_ESPECIFICA_VUELO_TRIPULACION";
            comando.Parameters.AddWithValue("@vuelo", vuelo);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return datos;
        }

        public DataTable buscarCiudadesTiquete(int id)
        {
            DataTable datos = new DataTable();

            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_CIUDADES_TIQUETE";
            comando.Parameters.AddWithValue("@id", id);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return datos;
        }

        public DataTable consultaNumerosDeVuelo()
        {
            DataTable datos = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "VUELOS_FUTUROS";
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return datos;
        }
    }
}
