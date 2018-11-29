using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegociacion
{
    public class CnMovimientosFinancieros
    {
        CdMovimientosFinancieros mov = new CdMovimientosFinancieros();
        public void nuevoMovimiento(string descripcion, string valor, string destino, int tipo, string fecha)
        {
            CnFechas conversor = new CnFechas();
            fecha = conversor.convertirAFormatoSQL(fecha);
            mov.nuevoMovimiento(descripcion, valor, destino, tipo, fecha);
        }

        public void generarPagosPendientes()
        {
            mov.generarPagosPendientes();
        }
    }
}
