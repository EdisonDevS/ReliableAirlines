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
    public class CnSesion
    {
    
        public string documento { get; set; }
        public string permisos { get; set; }

        public Boolean iniciarSesion(string usuario,string contraseña)
        {
            CdSesion inicio = new CdSesion();
            DataTable tabla = inicio.buscarSesion(usuario, contraseña);

            if(tabla.Rows.Count>0)
            {
                this.documento = tabla.Rows[0]["documento"].ToString();
                this.permisos = tabla.Rows[0]["permisos"].ToString();
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
