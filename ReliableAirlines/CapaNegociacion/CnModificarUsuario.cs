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
    public class CnModificarUsuario
    {
        public DataTable cargarDatos(string document)
        {
            CdModificarUsuario cargar = new CdModificarUsuario();
            DataTable tabla = new DataTable();
            tabla = cargar.cargaDatos(document);

            return tabla;
        }
    }
}
