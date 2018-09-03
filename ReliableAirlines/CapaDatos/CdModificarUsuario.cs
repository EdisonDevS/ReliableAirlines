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
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;
        } 

        public void modificar(string documento, string tipoDoc, string usuario,
            string nombres, string apellidos, string nacimiento,string email, 
            string telefono, string tipoContra, string puesto, string cuenta,
            string tipoCuenta, string banco, string eps, string direccion,
            string ciudad, string info, string sueldo)
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "ACTUALIZAR_DATOS_EMPLEADO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@tipoDocumento", tipoDoc);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@nombres", nombres);
            comando.Parameters.AddWithValue("@apellidos", apellidos);
            comando.Parameters.AddWithValue("@fechaNacimiento", nacimiento);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@tipoContrato", tipoContra);
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@cuenta", cuenta);
            comando.Parameters.AddWithValue("@tipoCuenta", tipoCuenta);
            comando.Parameters.AddWithValue("@banco", banco);
            comando.Parameters.AddWithValue("@EPS", eps);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@infoAdicional", info);
            comando.Parameters.AddWithValue("@sueldo", sueldo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            conexion.CerrarConexion();
        }
    }
}
