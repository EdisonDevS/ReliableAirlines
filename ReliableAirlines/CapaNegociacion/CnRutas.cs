using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegociacion
{
    public class CnRutas
    {
        CdRutas consulta = new CdRutas();
        
        public void CrearRuta(string nombre, int origen, int destino, string estado)
        {
            consulta.CrearRuta(nombre, origen, destino, estado);
        }
    }
}
