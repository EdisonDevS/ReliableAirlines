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
            string email, string telefono,string eps, string direccion,int ciudad,string info, string estado)
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
            consulta.Parameters.AddWithValue("@EPS", eps);
            consulta.Parameters.AddWithValue("@direccion", direccion);
            consulta.Parameters.AddWithValue("@ciudad", ciudad);
            consulta.Parameters.AddWithValue("@infoAdicional", info);
            consulta.Parameters.AddWithValue("@estado", estado);

            consulta.ExecuteNonQuery();
            consulta.Parameters.Clear();

            conexion.CerrarConexion();
        }

        public void contratoEmpleado(string documento, string tipo, string puesto, string sueldo, string inicio, string final, string numcuenta, string tipocuenta, string banco)
        {
            consulta.Connection = conexion.AbrirConexion();
            consulta.CommandType = CommandType.StoredProcedure;

            consulta.CommandText = "CREAR_CNTRATO";
            consulta.Parameters.AddWithValue("@documento", documento);
            consulta.Parameters.AddWithValue("@tipo", tipo);
            consulta.Parameters.AddWithValue("@puesto", puesto);
            consulta.Parameters.AddWithValue("@sueldo", sueldo);
            consulta.Parameters.AddWithValue("@inicio", inicio);
            consulta.Parameters.AddWithValue("@fin", final);
            consulta.Parameters.AddWithValue("@numCuenta", numcuenta);
            consulta.Parameters.AddWithValue("@tipoCuenta", tipocuenta);
            consulta.Parameters.AddWithValue("@banco", banco);

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
            string telefono, string eps, string direccion,
            int ciudad, string info, string estado)
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
            consulta.Parameters.AddWithValue("@EPS", eps);
            consulta.Parameters.AddWithValue("@direccion", direccion);
            consulta.Parameters.AddWithValue("@ciudad", ciudad);
            consulta.Parameters.AddWithValue("@infoAdicional", info);
            consulta.Parameters.AddWithValue("@estado", estado);

            consulta.ExecuteNonQuery();
            consulta.Parameters.Clear();

            conexion.CerrarConexion();
        }

        public DataTable validarUsuario(string doc)
        {
            DataTable info = new DataTable();
            consulta.CommandType = CommandType.StoredProcedure;
            consulta.CommandText = "CONSULTA_USUARIO";
            consulta.Connection = conexion.AbrirConexion();
            consulta.Parameters.AddWithValue("@doc", doc);
            fila = consulta.ExecuteReader();
            info.Load(fila);
            fila.Close();
            consulta.Parameters.Clear();
            conexion.CerrarConexion();
            return info;
        }

        public DataTable verificarDocumento(string doc)
        {
            DataTable usuario = new DataTable();
            consulta.CommandType = CommandType.StoredProcedure;
            consulta.CommandText = "VERIFICAR_DOCUMENTO";
            consulta.Connection = conexion.AbrirConexion();
            consulta.Parameters.AddWithValue("@doc", doc);
            fila = consulta.ExecuteReader();
            usuario.Load(fila);
            fila.Close();
            conexion.CerrarConexion();
            consulta.Parameters.Clear();

            return usuario;
        }
    }
}
