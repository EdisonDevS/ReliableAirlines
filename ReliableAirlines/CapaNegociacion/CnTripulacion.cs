using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegociacion
{
    public class CnTripulacion
    {
        CdTripulacion trip = new CdTripulacion();

        public void AgregarTripulanteAvuelo(string doc, int vuelo)
        {
            trip.AgregarTripulanteAvuelo(doc, vuelo);
        }

        public DataTable CargarTripulante(string doc)
        {
            DataTable tabla = new DataTable();
            tabla = trip.CargarTripulante(doc);
            return tabla;
        }
    }
}
