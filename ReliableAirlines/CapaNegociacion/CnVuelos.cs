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
        CnFechas Fechas = new CnFechas();
        public void CrearVuelo(int numVuelo, int idRuta, string idAeronave, string salida, string hsalida, 
                                string llegada, string hllegada, string vlrPclase, string vlrCturista)
        {
            CnFechas fecha = new CnFechas();

            salida = fecha.convertirAFormatoSQL(salida, hsalida);
            llegada = fecha.convertirAFormatoSQL(llegada, hllegada);

            vuelo.CrearVuelo(numVuelo, idRuta, idAeronave, salida, llegada, vlrPclase, vlrCturista);
        }

        public DataTable CargarDatos(int numVuelo)
        {
            return vuelo.CargarDatos(numVuelo);
        }

        public DataTable CargarDatosPorAeropuerto(int aerOrigen, int aerDestino)
        {
            return vuelo.CargarDatosPorAeropuerto(aerOrigen, aerDestino);
        }

        public void ActualizarVuelos(int numVuelo, int idRuta, string idAeronave, string salida, string hsalida,
                                     string llegada, string hllegada, string vlrPclase, string vlrCturista)
        {
            CnFechas fecha = new CnFechas();

            salida = fecha.convertirAFormatoSQL(salida, hsalida);
            llegada = fecha.convertirAFormatoSQL(llegada, hllegada);

            vuelo.ActualizarVuelo(numVuelo, idRuta, idAeronave, salida, llegada, vlrPclase, vlrCturista);
        }
        public DataTable CargarVuelosFecha(string fecha, int salida, int llegada)
        {
            fecha = Fechas.convertirAFormatoSQL(fecha);
            DataTable datos = vuelo.CargarVuelosFecha(fecha, salida, llegada);

            datos.Columns[0].ColumnName = "Vuelo";
            datos.Columns[1].ColumnName = "Cupos primera clase";
            datos.Columns[2].ColumnName = "Cupos clase turista";
            datos.Columns[3].ColumnName = "Salida";
            datos.Columns[4].ColumnName = "Llegada";
            datos.Columns[5].ColumnName = "Valor primera clase";
            datos.Columns[6].ColumnName = "Valor clase turista";

            return datos;
        }

        public DataTable ConsultaVuelosPendientes(string documento)
        {
            DataTable resultado = new DataTable();
            resultado = vuelo.ConsultaVuelosPendientes(documento);
            resultado.Columns[0].ColumnName = "Numero de vuelo";
            resultado.Columns[1].ColumnName = "Lugar de salida";
            resultado.Columns[2].ColumnName = "Lugar de llegada";
            resultado.Columns[3].ColumnName = "Hora de salida";
            resultado.Columns[4].ColumnName = "Hora de llegada";
            resultado.Columns[5].ColumnName = "Estado";
            resultado.Columns[6].ColumnName = "ID reserva";
            return resultado;
        }

        public DataTable ConsultaHistorialVuelos(string documento)
        {
            DataTable resultado = new DataTable();
            resultado = vuelo.ConsultaHistorialVuelos(documento);
            resultado.Columns[0].ColumnName = "Numero de vuelo";
            resultado.Columns[1].ColumnName = "Lugar de salida";
            resultado.Columns[2].ColumnName = "Lugar de llegada";
            resultado.Columns[3].ColumnName = "Hora de salida";
            resultado.Columns[4].ColumnName = "Hora de llegada";
            resultado.Columns[5].ColumnName = "Estado";
            resultado.Columns[6].ColumnName = "ID reserva";
            return resultado;
        }

        public DataTable cargarVuelosTripulante(string doc, int caso)
        {
            DataTable datos = new DataTable();
            datos = vuelo.cargarVuelosTripulante(doc, caso);
            datos.Columns[0].ColumnName = "Vuelo";
            datos.Columns[1].ColumnName = "Salida";
            datos.Columns[2].ColumnName = "Llegada";
            datos.Columns[3].ColumnName = "Ruta";
            return datos;
        }

        public DataTable cargarVuelosTripulanteInfo(int numVuelo)
        {
            DataTable datos = new DataTable();
            datos = vuelo.cargarVuelosTripulanteInfo(numVuelo);

            return datos;
        }

        public DataTable datosPersonalesTripulacion(int numVuelo)
        {
            DataTable datos = new DataTable();
            datos = vuelo.datosPersonalesTripulacion(numVuelo);
            datos.Columns[0].ColumnName = "Documento";
            datos.Columns[1].ColumnName = "Nombres";
            datos.Columns[2].ColumnName = "Apellidos";
            datos.Columns[3].ColumnName = "Rol";

            return datos;
        }
    }
}
