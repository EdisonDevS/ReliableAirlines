using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdAeronaves
    {
        CdConexion conexion = new CdConexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader filas;

        public void CrearAeronaves(string id, string tipo, int pclase, int claset, string prov, int equi, string adquisicion,string estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CREAR_AERONAVE";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@capPclase", pclase);
            comando.Parameters.AddWithValue("@capCturista", claset);
            comando.Parameters.AddWithValue("@proveedor", prov);
            comando.Parameters.AddWithValue("@equipaje", equi);
            comando.Parameters.AddWithValue("@adquisicion", adquisicion);
            comando.Parameters.AddWithValue("@estado", estado);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable ConsultarMatriculas()
        {
            DataTable resultados = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_MATRICULAS";
            filas = comando.ExecuteReader();
            resultados.Load(filas);
            filas.Close();
            return resultados;
        }

        public void ActualizarDatos(string id, string tipo, int pclase, int claset, string prov, int equi, string adquisicion, string estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "ACTUALIZAR_DATOS_AERONAVE";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@capPclase", pclase);
            comando.Parameters.AddWithValue("@capCturista", claset);
            comando.Parameters.AddWithValue("@proveedor", prov);
            comando.Parameters.AddWithValue("@equipaje", equi);
            comando.Parameters.AddWithValue("@adquisicion", adquisicion);
            comando.Parameters.AddWithValue("@estado", estado);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable ConsultaPorMatricula(string matricula)
        {
            DataTable resultado = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_AERONAVE_MATRICULA";
            comando.Parameters.AddWithValue("@matricula", matricula);

            filas = comando.ExecuteReader();
            resultado.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return resultado;
        }
    }
}
