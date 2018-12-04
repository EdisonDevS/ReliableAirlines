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
    public partial class ReporteReembolso : Form
    {

        public List<DatosReembolso> reembolso = new List<DatosReembolso>();
        public ReporteReembolso()
        {
            InitializeComponent();
        }

        private void ReporteReembolso_Load(object sender, EventArgs e)
        {

            this.ReportReembolso.RefreshReport();
            ReportReembolso.LocalReport.DataSources.Clear();
            ReportReembolso.LocalReport.DataSources.Add(new ReportDataSource("DatosReembolso", reembolso));
            ReportReembolso.RefreshReport();
            this.ReportReembolso.RefreshReport();
        }

        private void ReportReembolso_Load(object sender, EventArgs e)
        {

        }
    }
}
