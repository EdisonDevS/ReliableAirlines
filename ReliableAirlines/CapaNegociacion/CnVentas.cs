using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegociacion
{
    public class CnVentas
    {
        public void nuevoTiquete(string doc, int estado, int numVuelo)
        {
            CdVentas venta = new CdVentas();
            venta.nuevoTiquete(doc, estado, numVuelo);
        }
    }
}
