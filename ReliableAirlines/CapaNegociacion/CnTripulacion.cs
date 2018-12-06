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

        public void AgregarTripulanteAvuelo(string doc, int vuelo, string rol)
        {
            trip.AgregarTripulanteAvuelo(doc, vuelo, rol);
        }

        public DataTable CargarTripulante(string doc)
        {
            DataTable tabla = new DataTable();
            tabla = trip.CargarTripulante(doc);
            return tabla;
        }

        public DataTable ConsultarTripulantes(int vuelo)
        {
            DataTable datos = new DataTable();
            datos = trip.ConsultarTripulantes(vuelo);
            datos.Columns[0].ColumnName = "Documento";
            datos.Columns[1].ColumnName = "Rol";
            return datos;
        }

        public DataTable tripulantes()
        {
            DataTable datos = new DataTable();
            datos = trip.tripulantes();
            return datos;
        }
    }
}
