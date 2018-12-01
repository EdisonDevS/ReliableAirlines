using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

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

        public void generarPago()
        {
            mov.generarPago();
        }

        public DataTable consultarPagosPendientes()
        {
            DataTable datos = new DataTable();
            datos = mov.consultarPagosPendientes();
            datos.Columns[0].ColumnName = "Documento";
            datos.Columns[1].ColumnName = "Nombres";
            datos.Columns[2].ColumnName = "Apelidos";
            datos.Columns[3].ColumnName = "Sueldo/Hora";
            datos.Columns[4].ColumnName = "ID";
            datos.Columns[5].ColumnName = "Fecha";

            return datos;
        }

        public DataTable consultarDatosPago(string doc)
        {
            DataTable datos = new DataTable();
            datos = mov.consultarDatosPago(doc);
            return datos;
        }

        public void validarPago(int id, int dias, int horas, string total)
        {
            mov.validarPago(id, dias, horas, total);
        }
    }
}
