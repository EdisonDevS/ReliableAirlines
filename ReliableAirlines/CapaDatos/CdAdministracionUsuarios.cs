using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdAdministracionUsuarios
    {
        CdConexion conexion = new CdConexion();
        SqlCommand consulta = new SqlCommand();
        SqlDataReader fila;

        //registro del cliente
        public void registro(string documento, string tipoDoc, string usuario,
            string contraseña, string permisos, string nombres, string apellidos, string nacimiento,
            string email, string telefono)
        {
            consulta.Connection = conexion.AbrirConexion();
            consulta.CommandText = ("REGISTRO_CLIENTE");
            consulta.CommandType = CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@documento",documento);
            consulta.Parameters.AddWithValue("@tipoDocumento",tipoDoc);
            consulta.Parameters.AddWithValue("@usuario",usuario);
            consulta.Parameters.AddWithValue("@contraseña",contraseña);
            consulta.Parameters.AddWithValue("@permisos",permisos);
            consulta.Parameters.AddWithValue("@nombres",nombres);
            consulta.Parameters.AddWithValue("@apellidos",apellidos);
            consulta.Parameters.AddWithValue("@fechaNacimiento",nacimiento);
            consulta.Parameters.AddWithValue("@email",email);
            consulta.Parameters.AddWithValue("@telefono",telefono);

            consulta.ExecuteNonQuery();
            consulta.Parameters.Clear();

        }

        public DataTable CargarCiudades()
        {
            DataTable resultado = new DataTable();
            consulta.Connection = conexion.AbrirConexion();
            consulta.CommandType = CommandType.StoredProcedure;
            consulta.CommandText = "CONSULTAR_CIUDADES";
            fila = consulta.ExecuteReader();
            resultado.Load(fila);
            fila.Close();
            return resultado;
        }

        //sobrecarga para el empleado
        public void registro (string documento, string tipoDoc, string usuario,
            string contraseña, string permisos, string nombres, string apellidos, string nacimiento,
            string email, string telefono,string tipoContra, string puesto,string cuenta,
            string tipoCuenta,string banco,string eps, string direccion,int ciudad,string info, string sueldo, string estado)
        {
            consulta.Connection = conexion.AbrirConexion();
            
            consulta.CommandText = "REGISTRO_EMPLEADO";
            consulta.CommandType = CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@documento",documento);
            consulta.Parameters.AddWithValue("@tipoDocumento",tipoDoc);
            consulta.Parameters.AddWithValue("@usuario",usuario);
            consulta.Parameters.AddWithValue("@contraseña",contraseña);
            consulta.Parameters.AddWithValue("@permisos",permisos);
            consulta.Parameters.AddWithValue("@nombres",nombres);
            consulta.Parameters.AddWithValue("@apellidos", apellidos);
            consulta.Parameters.AddWithValue("@fechaNacimiento", nacimiento);
            consulta.Parameters.AddWithValue("@email", email);
            consulta.Parameters.AddWithValue("@telefono", telefono);
            consulta.Parameters.AddWithValue("@tipoContrato", tipoContra);
            consulta.Parameters.AddWithValue("@puesto", puesto);
            consulta.Parameters.AddWithValue("@cuenta", cuenta);
            consulta.Parameters.AddWithValue("@tipoCuenta", tipoCuenta);
            consulta.Parameters.AddWithValue("@banco", banco);
            consulta.Parameters.AddWithValue("@EPS", eps);
            consulta.Parameters.AddWithValue("@direccion", direccion);
            consulta.Parameters.AddWithValue("@ciudad", ciudad);
            consulta.Parameters.AddWithValue("@infoAdicional", info);
            consulta.Parameters.AddWithValue("@sueldo",sueldo);
            consulta.Parameters.AddWithValue("@estado", estado);

            consulta.ExecuteNonQuery();
            consulta.Parameters.Clear();

            conexion.CerrarConexion();
        }

        public DataTable cargaDatos(string documento)
        {
            DataTable tabla = new DataTable();
            consulta.Connection = conexion.AbrirConexion();
            consulta.CommandText = "CONSULTA_DATOS_EMPLEADO";
            consulta.CommandType = CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@document", documento);
            fila = consulta.ExecuteReader();
            tabla.Load(fila);
            fila.Close();
            consulta.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;
        }

        public void modificar(string documento, string tipoDoc, string usuario,
            string nombres, string apellidos, string nacimiento, string email,
            string telefono, string tipoContra, string puesto, string cuenta,
            string tipoCuenta, string banco, string eps, string direccion,
            int ciudad, string info, string sueldo, string estado)
        {
            consulta.Connection = conexion.AbrirConexion();

            consulta.CommandText = "ACTUALIZAR_DATOS_EMPLEADO";
            consulta.CommandType = CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@documento", documento);
            consulta.Parameters.AddWithValue("@tipoDocumento", tipoDoc);
            consulta.Parameters.AddWithValue("@usuario", usuario);
            consulta.Parameters.AddWithValue("@nombres", nombres);
            consulta.Parameters.AddWithValue("@apellidos", apellidos);
            consulta.Parameters.AddWithValue("@fechaNacimiento", nacimiento);
            consulta.Parameters.AddWithValue("@email", email);
            consulta.Parameters.AddWithValue("@telefono", telefono);
            consulta.Parameters.AddWithValue("@tipoContrato", tipoContra);
            consulta.Parameters.AddWithValue("@puesto", puesto);
            consulta.Parameters.AddWithValue("@cuenta", cuenta);
            consulta.Parameters.AddWithValue("@tipoCuenta", tipoCuenta);
            consulta.Parameters.AddWithValue("@banco", banco);
            consulta.Parameters.AddWithValue("@EPS", eps);
            consulta.Parameters.AddWithValue("@direccion", direccion);
            consulta.Parameters.AddWithValue("@ciudad", ciudad);
            consulta.Parameters.AddWithValue("@infoAdicional", info);
            consulta.Parameters.AddWithValue("@sueldo", sueldo);
            consulta.Parameters.AddWithValue("@estado", estado);

            consulta.ExecuteNonQuery();
            consulta.Parameters.Clear();

            conexion.CerrarConexion();
        }

    }
}
