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
        CnFechas conversor = new CnFechas();
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

        public DataTable obtenerInfoVentaReembolso(int reserva)
        {
            DataTable resultados = new DataTable();
            resultados = venta.obtenerInfoVentaReembolso(reserva);

            return resultados;
        }

        public void validarReserva(string reserva)
        {
            venta.validarReserva(Int32.Parse(reserva));
        }

        public DataTable consultarVentas(string inicio, string final)
        {
            DataTable datos = new DataTable();

            inicio = conversor.convertirAFormatoSQL(inicio);
            final = conversor.convertirAFormatoSQL(final);

            datos = venta.consultarVentas(inicio, final);

            datos.Columns[0].ColumnName = "Tiquete";
            datos.Columns[1].ColumnName = "Vuelo";
            datos.Columns[2].ColumnName = "Reserva";
            datos.Columns[3].ColumnName = "Nombres";
            datos.Columns[4].ColumnName = "Apellidos";
            datos.Columns[5].ColumnName = "Documento";

            return datos;
        }

        public void gererarReembolso(string aut, string justifica, int tiquete)
        {
            venta.gererarReembolso(aut, justifica, tiquete);
        }

        public DataTable consultarReembolsos(string inicio, string final)
        {
            DataTable datos = new DataTable();

            inicio = conversor.convertirAFormatoSQL(inicio);
            final = conversor.convertirAFormatoSQL(final);

            datos = venta.consultarReembolsos(inicio, final);

            datos.Columns[0].ColumnName = "Tiquete";
            datos.Columns[1].ColumnName = "Vuelo";
            datos.Columns[2].ColumnName = "Reserva";
            datos.Columns[3].ColumnName = "Nombres";
            datos.Columns[4].ColumnName = "Apellidos";
            datos.Columns[5].ColumnName = "Documento";

            return datos;
        }

        public DataTable consultaJustificacion(int tiquete)
        {
            DataTable datos = new DataTable();
            datos = venta.consultaJustificacion(tiquete);
            return datos;
        }

        public int consultaIDTiquete(int vuelo, string doc)
        {
            int id = Int32.Parse(venta.consultaIDTiquete(vuelo, doc).Rows[0][0].ToString());  
            return id;
        }

        public bool verificarReembolso(int tiquete)
        {
            DataTable reembolso = new DataTable();

            reembolso = venta.verificarReembolso(tiquete);

            if(Int32.Parse(reembolso.Rows[0][0].ToString())>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
