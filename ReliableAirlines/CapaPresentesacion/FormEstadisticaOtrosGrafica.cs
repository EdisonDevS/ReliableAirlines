using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegociacion;

namespace CapaPresentesacion
{
    public partial class FormEstadisticaOtrosGrafica : Form
    {
        public FormEstadisticaOtrosGrafica()
        {
            InitializeComponent();
        }
        string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };
        private void cargarGrafico()
        {
            graCiudades.Series.Clear();
            graCiudades.Series.Add("Ventas");
            graCiudades.Series["Ventas"].IsValueShownAsLabel = true;
            graCiudades.Series.Add("Reembolsos");
            graCiudades.Series["Reembolsos"].IsValueShownAsLabel = true;
            graCiudades.Series.Add("Ingresos externos");
            graCiudades.Series["Ingresos externos"].IsValueShownAsLabel = true;
            graCiudades.Series.Add("Gastos externos");
            graCiudades.Series["Gastos externos"].IsValueShownAsLabel = true;
            CnMovimientosFinancieros mov = new CnMovimientosFinancieros();
            for (int i = 0; i < 12; i++)
            {
                graCiudades.Series["Ventas"].Points.AddXY(meses[i], mov.consultaSumaVentasMes(i + 1, txtAño.Text));
                graCiudades.Series["Reembolsos"].Points.AddXY(meses[i], mov.consultaSumaReembolsosMes(i + 1, txtAño.Text));
                graCiudades.Series["Ingresos externos"].Points.AddXY(meses[i], mov.consultaSumaIngresosExternosMes(i + 1, txtAño.Text));
                graCiudades.Series["Gastos externos"].Points.AddXY(meses[i], mov.consultaSumaGastosExternosMes(i + 1, txtAño.Text));
            }
        }


        private void btnVer_Click(object sender, EventArgs e)
        {
            cargarGrafico();
        }
    }
}
