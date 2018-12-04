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
    public partial class ReporteTiquetes : Form
    {
        public List<DatosTiquete> Tiquete = new List<DatosTiquete>();
        public ReporteTiquetes()
        {
            InitializeComponent();
        }

        private void ReporteTiquetes_Load(object sender, EventArgs e)
        {

            this.ReporteTiquete.RefreshReport();
            ReporteTiquete.LocalReport.DataSources.Clear();
            ReporteTiquete.LocalReport.DataSources.Add(new ReportDataSource("DatosTiquete", Tiquete));
            ReporteTiquete.RefreshReport();
        }

        private void ReporteTiquete_Load(object sender, EventArgs e)
        {

        }
    }
}
