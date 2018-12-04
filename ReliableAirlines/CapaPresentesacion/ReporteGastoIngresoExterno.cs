using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CapaPresentesacion
{
    public partial class ReporteGastoIngresoExterno : Form
    {

        public List<DatosGastoIngresoExterno> gastoIngresoExternos = new List<DatosGastoIngresoExterno>();
        public ReporteGastoIngresoExterno()
        {
            InitializeComponent();
        }

        private void ReporteGastoIngresoExterno_Load(object sender, EventArgs e)
        {

            this.ReporteGastoIgreso.RefreshReport();
            ReporteGastoIgreso.LocalReport.DataSources.Clear();
            ReporteGastoIgreso.LocalReport.DataSources.Add(new ReportDataSource("DatosGastoIngresoExterno", gastoIngresoExternos));
            ReporteGastoIgreso.RefreshReport();
            this.ReporteGastoIgreso.RefreshReport();
        }

        private void ReporteGastoIgreso_Load(object sender, EventArgs e)
        {

        }
    }
}
