using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentesacion
{
    public partial class FormReporteTiquetes : Form
    {
        public FormReporteTiquetes()
        {
            InitializeComponent();
        }

        private void ReporteTiquetes_Load(object sender, EventArgs e)
        {

            this.ReporteTiquete.RefreshReport();
        }

        private void ReporteTiquete_Load(object sender, EventArgs e)
        {

        }
    }
}
