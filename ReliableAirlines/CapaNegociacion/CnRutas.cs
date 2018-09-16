using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using System.Data;

namespace CapaNegociacion
{
    public class CnRutas
    {
        CdRutas consulta = new CdRutas();
        
        public void CrearRuta(string nombre, int origen, int destino, string estado)
        {
            consulta.CrearRuta(nombre, origen, destino, estado);
        }

        public DataTable ConsultaGralRutas()
        {
            DataTable tabla = consulta.ConsultaGralRutas();
            tabla.Columns[0].ColumnName = "ID Ruta";
            tabla.Columns[1].ColumnName = "Nombre Ruta";
            tabla.Columns[2].ColumnName = "Origen";
            tabla.Columns[3].ColumnName = "Destino";
            return tabla;
        }

        public DataTable ConsultaEspecificaRutas(int ruta)
        {
            DataTable tabla = consulta.ConsultaEspecificaRutas(ruta);
            return tabla;
        }

        public void ActualizarEstadoRuta(int ruta, string estado)
        {
            consulta.ActualizarEstadoRuta(ruta, estado);
        }
    }
}
