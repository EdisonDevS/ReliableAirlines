using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegociacion
{
    class CnFechas
    {
        public string convertirAFormatoSQL(string fecha)
        {
            if (fecha.Length == 9)
            {
                fecha = "0" + fecha;
            }
            string yyyy = fecha[6].ToString() + fecha[7].ToString() + fecha[8].ToString() + fecha[9].ToString();
            string mm = fecha[0].ToString() + fecha[1].ToString();
            string dd = fecha[3].ToString() + fecha[4].ToString();

            string nuevaFecha = yyyy + "/" + dd + "/" + mm;

            return nuevaFecha;
        }

        public string convertirAFormatoSQL(string fecha, string hora)
        {
            if (fecha.Length == 9)
            {
                fecha = "0" + fecha;
            }
            string yyyy = fecha[6].ToString() + fecha[7].ToString() + fecha[8].ToString() + fecha[9].ToString();
            string mm = fecha[0].ToString() + fecha[1].ToString();
            string dd = fecha[3].ToString() + fecha[4].ToString();

            string nuevaFecha = yyyy + "/" + dd + "/" + mm + " " + hora;

            return nuevaFecha;
        }
    }
}
