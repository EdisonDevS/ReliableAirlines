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
    public partial class FormContabilidadGeneralEstadistica : Form
    {
        public FormContabilidadGeneralEstadistica()
        {
            InitializeComponent();
        }

        string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

        private void cargarGrafico()
        {
            graGeneral.Series.Clear();
            graGeneral.Series.Add("Gastos");
            graGeneral.Series["Gastos"].IsValueShownAsLabel = true;
            graGeneral.Series.Add("Ingresos");
            graGeneral.Series["Ingresos"].IsValueShownAsLabel = true;
            CnMovimientosFinancieros movimiento = new CnMovimientosFinancieros();
            for (int i = 0; i < 12; i++)
            {
                graGeneral.Series["Gastos"].Points.AddXY(meses[i], movimiento.consultaSumaGastosMes(i + 1, txtAño.Text));
                graGeneral.Series["Ingresos"].Points.AddXY(meses[i], movimiento.consultaSumaIngresosMes(i + 1, txtAño.Text));
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            cargarGrafico();
        }
    }
}
