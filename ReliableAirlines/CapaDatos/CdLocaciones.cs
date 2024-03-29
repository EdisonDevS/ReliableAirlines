﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CdLocaciones
    {
        CdConexion conexion = new CdConexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader filas;

        public void CrearPais(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CREAR_PAIS";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void CrearEstado(int pais, string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CREAR_ESTADO";
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void CrearCiudad(int estado, string ciudad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CREAR_CIUDAD";
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@ciudad", ciudad);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void CrearAeropuerto(string nombre, int ciudad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CREAR_AEROPUERTO";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@ciudad", ciudad);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable ConsultaPaises()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_PAISES";
            filas = comando.ExecuteReader();
            tabla.Load(filas);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultaEstados(int pais)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_ESTADOS";
            comando.Parameters.AddWithValue("@pais", pais);

            filas = comando.ExecuteReader();
            tabla.Load(filas);

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultaCiudad(int estado)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_CIUDADES";
            comando.Parameters.AddWithValue("@estado", estado);

            filas = comando.ExecuteReader();
            tabla.Load(filas);

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultaAeropuerto(int ciudad)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_AEROPUERTOS";
            comando.Parameters.AddWithValue("@ciudad", ciudad);

            filas = comando.ExecuteReader();
            tabla.Load(filas);

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable consultaPasajerosSalientes(int mes, string año, int ciudad)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_SUM_VUELOS_SALIDA_CIUDAD";
            comando.Parameters.AddWithValue("@idCiudad", ciudad);
            comando.Parameters.AddWithValue("@año", año);
            comando.Parameters.AddWithValue("@mes", mes);

            filas = comando.ExecuteReader();
            tabla.Load(filas);

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable consultaPasajerosEntrantes(int mes, string año, int ciudad)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CONSULTA_SUM_VUELOS_LLEGADA_CIUDAD";
            comando.Parameters.AddWithValue("@idCiudad", ciudad);
            comando.Parameters.AddWithValue("@año", año);
            comando.Parameters.AddWithValue("@mes", mes);

            filas = comando.ExecuteReader();
            tabla.Load(filas);

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
