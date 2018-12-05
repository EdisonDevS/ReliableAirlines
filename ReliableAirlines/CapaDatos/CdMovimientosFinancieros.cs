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
        SqlDataReader filas;
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

        public DataTable consultarMovimientosExternos(int tipo, string inicio, string fin)
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_MOVIMIENTOS_EXTERNOS";
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@inicio", inicio);
            comando.Parameters.AddWithValue("@fin", fin);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return datos;
        }

        public void generarPago()
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GENERAR_PAGO";
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable consultarPagosPendientes()
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_PAGOS_PENDIENTES";
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            return datos;
        }
        public DataTable consultarPagosRealizados()
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_PAGOS_REALIZADOS";
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            conexion.CerrarConexion();
            return datos;
        }

        public DataTable consultarPagosRealizados(string doc)
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_PERSONAL_PAGOS";
            comando.Parameters.AddWithValue("@doc", doc);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return datos;
        }

        public DataTable consultarDatosPago(string doc)
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_DATOS_DE_PAGO";
            comando.Parameters.AddWithValue("@doc", doc);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return datos;
        }

        public DataTable consultarDatosPagoRealizado(int id)
        {
            DataTable datos = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_DATOS_DE_PAGO_REALIZADO";
            comando.Parameters.AddWithValue("@id", id);
            filas = comando.ExecuteReader();
            datos.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return datos;
        }

        public void validarPago(int id, int dias, int horas, string total)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "VALIDAR_PAGO";
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@dias", dias);
            comando.Parameters.AddWithValue("@horas", horas);
            comando.Parameters.AddWithValue("@total", total);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public DataTable consultaSumaGastosMes(int mes, string Año)
        {
            DataTable suma = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_SUM_GRAL_MES_GASTOS";
            comando.Parameters.AddWithValue("@mes", mes);
            comando.Parameters.AddWithValue("@año", Año);
            filas = comando.ExecuteReader();
            suma.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return suma;
        }

        public DataTable consultaSumaIngresosMes(int mes, string Año)
        {
            DataTable suma = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_SUM_GRAL_MES_INGRESOS";
            comando.Parameters.AddWithValue("@mes", mes);
            comando.Parameters.AddWithValue("@año", Año);
            filas = comando.ExecuteReader();
            suma.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return suma;
        }

        public DataTable consultaSumaVentasMes(int mes, string Año)
        {
            DataTable suma = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_SUM_VENTAS_MES";
            comando.Parameters.AddWithValue("@mes", mes);
            comando.Parameters.AddWithValue("@año", Año);
            filas = comando.ExecuteReader();
            suma.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return suma;
        }
        public DataTable consultaSumaReembolsosMes(int mes, string Año)
        {
            DataTable suma = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_SUM_REEMBOLSOS_MES";
            comando.Parameters.AddWithValue("@mes", mes);
            comando.Parameters.AddWithValue("@año", Año);
            filas = comando.ExecuteReader();
            suma.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return suma;
        }
        public DataTable consultaSumaIngresosExternosMes(int mes, string Año)
        {
            DataTable suma = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_SUM_EXTERNOS_MES_INGRESOS";
            comando.Parameters.AddWithValue("@mes", mes);
            comando.Parameters.AddWithValue("@año", Año);
            filas = comando.ExecuteReader();
            suma.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return suma;
        }
        public DataTable consultaSumaGastosExternosMes(int mes, string Año)
        {
            DataTable suma = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CONSULTA_SUM_EXTERNOS_MES_GASTOS";
            comando.Parameters.AddWithValue("@mes", mes);
            comando.Parameters.AddWithValue("@año", Año);
            filas = comando.ExecuteReader();
            suma.Load(filas);
            filas.Close();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return suma;
        }
    }
}
