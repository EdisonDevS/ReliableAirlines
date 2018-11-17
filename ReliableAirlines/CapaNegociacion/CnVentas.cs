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
        CdVentas venta = new CdVentas();
        public void nuevoTiquete(string doc, int estado, int numVuelo, int clase)
        {
            venta.nuevoTiquete(doc, estado, numVuelo, clase);
        }

        public void cancelacionDeTiquete(string documento, int vuelo)
        {
            venta.cancelacionDeTiquete(documento, vuelo);
        }

        public DataTable obtenerInfoVenta(string reserva)
        {
            DataTable resultados = new DataTable();
            resultados = venta.obtenerInfoVenta(Int32.Parse(reserva));

            return resultados;
        }

        public void validarReserva(string reserva)
        {
            venta.validarReserva(Int32.Parse(reserva));
        }
    }
}
