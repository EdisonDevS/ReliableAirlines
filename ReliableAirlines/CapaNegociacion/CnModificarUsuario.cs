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

        public void realizarCambios(string documento, string tipoDoc, string usuario,
            string nombres, string apellidos, string nacimiento,
            string email, string telefono, string tipoContra, string puesto, string cuenta,
            string tipoCuenta, string banco, string eps, string direccion, string ciudad, string info, string sueldo)
        {
            CdModificarUsuario cambiar = new CdModificarUsuario();
            CnFechas fechas = new CnFechas();
            nacimiento = fechas.convertirAFormatoSQL(nacimiento);
        
            cambiar.modificar(documento, tipoDoc, usuario, nombres, apellidos, nacimiento,
                email, telefono, tipoContra, puesto, cuenta, tipoCuenta, banco, eps, direccion, ciudad, info, sueldo);

        }
    }
}
