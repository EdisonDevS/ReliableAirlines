using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegociacion
{
    public class CnCiudadesAeropuertos
    {
        CdCiudadesAeropuertos crear = new CdCiudadesAeropuertos();

        public void CrearPais(string pais)
        {
            crear.CrearPais(pais);
        }

        public void CrearEstado(int pais, string estado)
        {
            crear.CrearEstado(estado, pais);
        }

        public void CrearCiudad(int pais, int estado, string ciudad)
        {
            crear.CrearCiudad(pais, estado, ciudad);
        }

        public void CrearAeropuerto(int ciudad, string aeropuerto)
        {
            crear.CrearAeropuerto(aeropuerto, ciudad);
        }
    }
}
