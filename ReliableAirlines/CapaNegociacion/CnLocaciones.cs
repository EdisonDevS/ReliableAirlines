using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegociacion
{
    public class CnLocaciones
    {
        CdLocaciones consultas = new CdLocaciones();

        public void CrearPais(string pais)
        {
            consultas.CrearPais(pais);
        }

        public void CrearEstado(int pais, string estado)
        {
            consultas.CrearEstado(pais, estado);
        }

        public void CrearCiudad(int estado, string ciudad)
        {
            consultas.CrearCiudad(estado, ciudad);
        }

        public void CrearAeropuerto(int ciudad, string aeropuerto)
        {
            consultas.CrearAeropuerto(aeropuerto, ciudad);
        }

        public DataTable ConsultarPaises()
        {
            return consultas.ConsultaPaises();
        }

        public DataTable ConsultarEstados(int pais)
        {
            return consultas.ConsultaEstados(pais);
        }

        public DataTable ConsultarCiudades(int estado)
        {
            return consultas.ConsultaCiudad(estado);
        }

        public DataTable ConsultarAeropuertos(int ciudad)
        {
            return consultas.ConsultaAeropuerto(ciudad);
        }

        public int consultaPasajerosSalientes(int mes, string año, int ciudad)
        {
            DataTable pasajeros = new DataTable();
            pasajeros = consultas.consultaPasajerosSalientes(mes, año, ciudad);

            return Int32.Parse(pasajeros.Rows[0][0].ToString());
        }

        public int consultaPasajerosEntrantes(int mes, string año, int ciudad)
        {
            DataTable pasajeros = new DataTable();
            pasajeros = consultas.consultaPasajerosEntrantes(mes, año, ciudad);

            return Int32.Parse(pasajeros.Rows[0][0].ToString());
        }
    }
}
