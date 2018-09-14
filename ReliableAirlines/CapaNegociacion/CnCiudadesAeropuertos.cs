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
    public class CnCiudadesAeropuertos
    {
        CdCiudadesAeropuertos consultas = new CdCiudadesAeropuertos();

        public void CrearPais(string pais)
        {
            consultas.CrearPais(pais);
        }

        public void CrearEstado(int pais, string estado)
        {
            consultas.CrearEstado(estado, pais);
        }

        public void CrearCiudad(int pais, int estado, string ciudad)
        {
            consultas.CrearCiudad(pais, estado, ciudad);
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
    }
}
