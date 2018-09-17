﻿using System;
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
    }
}