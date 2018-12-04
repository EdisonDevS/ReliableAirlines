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
    public partial class ReportePagoNomina : Form
    {
        public List<DatosPagoNomina> pago = new List<DatosPagoNomina>();
        public ReportePagoNomina()
        {
            InitializeComponent();
        }

        private void ReportePagoNomina_Load(object sender, EventArgs e)
        {
            this.ReporteNomina.RefreshReport();
            ReporteNomina.LocalReport.DataSources.Clear();
            ReporteNomina.LocalReport.DataSources.Add(new ReportDataSource("DatosPagoNomina", pago));
            ReporteNomina.RefreshReport();
            this.ReporteNomina.RefreshReport();
        }

        private void ReporteNomina_Load(object sender, EventArgs e)
        {

        }
    }
}
