using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegociacion
{
    public class CnRegistros
    {
        CdRegistros registro = new CdRegistros();
        public void generarRegistroTripulacion(int vuelo, string calificacion, string comentarios, string tripulante)
        {
            registro.generarRegistroTripulacion(vuelo, calificacion, comentarios, tripulante);
        }

        public void generarRegistroEmpleado(string comentarios, string doc)
        {
            registro.generarRegistroEmpleado(comentarios, doc);
        }

        public DataTable consultaInformesEmpleados()
        {
            DataTable datos = new DataTable();
            datos = registro.consultaInformesEmpleados();
            
            datos.Columns[0].ColumnName = "Nombres";
            datos.Columns[1].ColumnName = "Apellidos";
            datos.Columns[2].ColumnName = "Documento";
            datos.Columns[3].ColumnName = "Comentrio";
            datos.Columns[4].ColumnName = "Fecha";

            return datos;
        }

        public DataTable consultaInformesVuelos()
        {
            DataTable datos = new DataTable();
            datos = registro.consultaInformesVuelos();

            datos.Columns[0].ColumnName = "Nombres";
            datos.Columns[1].ColumnName = "Apellidos";
            datos.Columns[2].ColumnName = "Documento";
            datos.Columns[3].ColumnName = "Comentrio";
            datos.Columns[4].ColumnName = "Fecha";
            datos.Columns[5].ColumnName = "Calificación";

            return datos;
        }
    }
}
