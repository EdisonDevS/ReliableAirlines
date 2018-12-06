using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CapaNegociacion
{
    public class CnSesion
    {
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public string documento { get; set; }
        public string permisos { get; set; }

        public Boolean iniciarSesion(string usuario,string contraseña)
        {
            CdSesion inicio = new CdSesion();

            using (MD5 md5Hash = MD5.Create())
            {
                contraseña = GetMd5Hash(md5Hash, contraseña);
            }

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
