using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace CapaDatos
{
    class CdConexion
    {

        SqlConnection Conexion = new SqlConnection("Data Source = den1.mssql8.gear.host;" +
            " Initial catalog = reliableairlines; user id = reliableairlines; password = Hr39!?AY8P34");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                try
                {
                    Conexion.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido conectar con la base de datos\n" +
                        "Por favor verifique su conexión e intentelo nuevamente\n");
                }

            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}