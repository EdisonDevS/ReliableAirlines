using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegociacion
{
    public class CnContacto
    {
        CdContacto contacto = new CdContacto();
        public void crearContacto(string nit, string nombre, string direccion, string correo)
        {
            contacto.crearContacto(nit, nombre, direccion, correo);
        }

        public void añadirTelefono(string nit, string telefono, string contesta)
        {
            contacto.añadirTelefono(nit, telefono, contesta);
        }

        public DataTable consultaNumeros(string nit)
        {
            DataTable numeros = contacto.consultaNumeros(nit);

            numeros.Columns[0].ColumnName = "ID Contacto";
            numeros.Columns[1].ColumnName = "Contesta";
            numeros.Columns[2].ColumnName = "Número";

            return numeros;
        }

        public DataTable consultaContacto(string nit)
        {
            DataTable datos = contacto.consultaContacto(nit);

            return datos;
        }

        public void actualizarNumero(int id, string num, string contesta)
        {
            contacto.actualizarNumero(id, num, contesta);
        }

        public void modificarContacto(string nit, string nombre, string direccion, string correo)
        {
            contacto.modificarContacto(nit, nombre, direccion, correo);
        }

        public DataTable consultaGralContactos()
        {
            DataTable datos = contacto.consultaGralContactos();

            return datos;
        }

    }
}
