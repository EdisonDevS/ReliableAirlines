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

        public DataTable consultarMovimientosExternos(int tipo, string inicio, string fin)
        {
            CnFechas conversor = new CnFechas();
            inicio = conversor.convertirAFormatoSQL(inicio);
            fin = conversor.convertirAFormatoSQL(fin);

            DataTable datos = new DataTable();
            datos = mov.consultarMovimientosExternos(tipo, inicio, fin);
            datos.Columns[0].ColumnName = "Descripción";
            datos.Columns[1].ColumnName = "Fecha";
            datos.Columns[2].ColumnName = "Valor";
            datos.Columns[3].ColumnName = "Contacto";
            datos.Columns[4].ColumnName = "NIT";
            return datos;
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

        public DataTable consultarPagosRealizados()
        {
            DataTable datos = new DataTable();
            datos = mov.consultarPagosRealizados();
            datos.Columns[0].ColumnName = "Documento";
            datos.Columns[1].ColumnName = "Nombres";
            datos.Columns[2].ColumnName = "Apelidos";
            datos.Columns[3].ColumnName = "Sueldo/Hora";
            datos.Columns[4].ColumnName = "ID";
            datos.Columns[5].ColumnName = "Fecha";

            return datos;
        }

        public DataTable consultarPagosRealizados(string doc)
        {
            DataTable datos = new DataTable();
            datos = mov.consultarPagosRealizados(doc);
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

        public DataTable consultarDatosPagoRealizado(int id)
        {
            DataTable datos = new DataTable();
            datos = mov.consultarDatosPagoRealizado(id);
            return datos;
        }

        public void validarPago(int id, int dias, int horas, string total)
        {
            mov.validarPago(id, dias, horas, total);
        }

        public int consultaSumaGastosMes(int mes, string Año)
        {
            DataTable suma = new DataTable();
            suma = mov.consultaSumaGastosMes(mes, Año);
            return Int32.Parse(suma.Rows[0][0].ToString());
        }

        public int consultaSumaIngresosMes(int mes, string Año)
        {
            DataTable suma = new DataTable();
            suma = mov.consultaSumaIngresosMes(mes, Año);
            return Int32.Parse(suma.Rows[0][0].ToString());
        }
    }
}
