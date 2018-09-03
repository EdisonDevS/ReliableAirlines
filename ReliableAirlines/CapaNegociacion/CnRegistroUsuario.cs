using System;
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
    public class CnRegistroUsuario
    {
        CdRegistroUsuario registrar = new CdRegistroUsuario();
        CnFechas conversorFecha = new CnFechas();
        CnPermisos permiso = new CnPermisos();

        //sobrecarga para empleados
        public void registro(string documento, string tipoDoc, string usuario,
            string contraseña, string tipoUsuario, string nombres, string apellidos, string nacimiento,
            string email, string telefono, string tipoContra, string puesto, string cuenta,
            string tipoCuenta, string banco, string eps, string direccion, string ciudad, string info)
        {
            nacimiento = conversorFecha.convertirAFormatoSQL(nacimiento);
            string permisos = permiso.generarPermisos(tipoUsuario);

            try
            {
                registrar.registro(documento, tipoDoc, usuario, contraseña, permisos, nombres, apellidos, nacimiento,
                email, telefono, tipoContra, puesto, cuenta, tipoCuenta, banco, eps, direccion, ciudad, info);
            }catch(Exception)
            {
                MessageBox.Show("Ohh ohh, parece que ya existe un usuario con esta identificación,\n" +
                                "verifica tus datos e intentalo nuevamente.");
            }
            

        }
    }
}
