﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CapaNegociacion
{
    public class CnAdministracionUsuarios
    {
        CdAdministracionUsuarios registrar = new CdAdministracionUsuarios();
        CnFechas conversorFecha = new CnFechas();
        CnPermisos permiso = new CnPermisos();

        //Registro para los clientes
        public void registro(string documento, string tipoDoc, string usuario,
            string contraseña, string tipoUsuario, string nombres, string apellidos, string nacimiento,
            string email, string telefono)
        {
            nacimiento = conversorFecha.convertirAFormatoSQL(nacimiento);

            registrar.registro(documento, tipoDoc, usuario, contraseña, tipoUsuario, nombres, apellidos, nacimiento, email,
                telefono);
        }

        public DataTable CargarCiudades()
        {
            return registrar.CargarCiudades();
        }

        //sobrecarga para empleados
        public void registro(string documento, string tipoDoc, string usuario,
            string contraseña, string tipoUsuario, string nombres, string apellidos, string nacimiento,
            string email, string telefono, string eps, string direccion, int ciudad, string info, string estado)
        {
            nacimiento = conversorFecha.convertirAFormatoSQL(nacimiento);
            string permisos = permiso.generarPermisos(tipoUsuario);

            try
            {
                registrar.registro(documento, tipoDoc, usuario, contraseña, permisos, nombres, apellidos, nacimiento,
                email, telefono, eps, direccion, ciudad, info, estado);
            }catch(Exception ex)
            {
                MessageBox.Show("Ohh ohh, parece que ya existe un usuario con esta identificación,\n" +ex+
                                "verifica tus datos e intentalo nuevamente.");
            }
          
        }

        public DataTable cargarDatos(string document)
        {
            CdAdministracionUsuarios cargar = new CdAdministracionUsuarios();
            DataTable tabla = new DataTable();
            tabla = cargar.cargaDatos(document);

            return tabla;
        }

        public void realizarCambios(string documento, string tipoDoc, string usuario,
            string nombres, string apellidos, string nacimiento,
            string email, string telefono, string eps, string direccion, int ciudad, string info, string estado)
        {
            CdAdministracionUsuarios cambiar = new CdAdministracionUsuarios();
            CnFechas fechas = new CnFechas();
            nacimiento = fechas.convertirAFormatoSQL(nacimiento);

            cambiar.modificar(documento, tipoDoc, usuario, nombres, apellidos, nacimiento,
                email, telefono, eps, direccion, ciudad, info, estado);

        }

        public DataTable validarUsuario(string doc)
        {
            return registrar.validarUsuario(doc);
        }

        public void contratoEmpleado(string documento, string tipo, string puesto, string sueldo, string inicio, string final, string numcuenta, string tipocuenta, string banco)
        {
            inicio = conversorFecha.convertirAFormatoSQL(inicio);
            final = conversorFecha.convertirAFormatoSQL(final);

            registrar.contratoEmpleado(documento, tipo, puesto, sueldo,inicio, final, numcuenta, tipocuenta, banco);
        }
    }
}
