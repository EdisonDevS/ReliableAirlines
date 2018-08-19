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
    class CD_Conexion
    {

        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-EMQ2NTE\\SQLEXPRESS; Initial catalog = <Nombre de la DB>; Integrated Security = True");

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
                        "Por favor verifique su conección e intentelo nuevamente\n");
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