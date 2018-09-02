using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegociacion
{
    class CnPermisos
    {
        public List<string> traducirPermisos(string cadena)
        {
            List<string> permisos = new List<string>();

            foreach (char x in cadena)
            {
                permisos.Add(Convert.ToString(Convert.ToByte(x)));
            }

            foreach(string x in permisos)
            {
                Console.WriteLine(x);
            }

            return permisos;
        }
    }
}
