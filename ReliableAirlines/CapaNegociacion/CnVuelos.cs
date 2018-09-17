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
    public class CnVuelos
    {
        CdVuelos vuelo = new CdVuelos();
        public void CrearVuelo(int numVuelo, int idRuta, string idAeronave, string salida, string hsalida, 
                                string llegada, string hllegada, string vlrPclase, string vlrCturista)
        {
            CnFechas fecha = new CnFechas();

            salida = fecha.convertirAFormatoSQL(salida, hsalida);
            llegada = fecha.convertirAFormatoSQL(llegada, hllegada);

            vuelo.CrearVuelo(numVuelo, idRuta, idAeronave, salida, llegada, vlrPclase, vlrCturista);
        }
    }
}
