using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegociacion
{
    public class CnPermisos
    {
        public string generarPermisos(string tipoUsuario)
        {
            string permisos = "";

            switch(tipoUsuario)
            {
                case "Admin":
                    permisos = permisos + "1";
                    break;
                case "Caja":
                    permisos = permisos + "2";
                    break;
                case "Tripulación":
                    permisos = permisos + "3";
                    break;
                case "Empleado":
                    permisos = permisos + "4";
                    break;
            }

            return permisos;
        }

        public List<string> traducirPermisos(string cadena)
        {
            List<string> permisos = new List<string>();

            foreach (char x in cadena)
            {
                string aux = Convert.ToString(Convert.ToInt32(((int)x).ToString("X"), 16), 2);
                int medida = aux.Length;
                if(aux.Length<8)
                {
                    for(int i=0; i<(8-medida);i++)
                    {
                        aux = "0" + aux;
                    }
                }
                permisos.Add(aux);
            }

            foreach(string x in permisos)
            {
                Console.WriteLine(x);
            }

            return permisos;
        }
    }
}
