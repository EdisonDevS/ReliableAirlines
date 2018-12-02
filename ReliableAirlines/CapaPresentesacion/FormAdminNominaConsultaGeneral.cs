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
    public partial class FormAdminNominaConsultaGeneral : Form
    {
        public FormAdminNominaConsultaGeneral()
        {
            InitializeComponent();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FormContabilidadGastosConsultarNomina nomina = new FormContabilidadGastosConsultarNomina();
            nomina.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            nomina.StartPosition = FormStartPosition.CenterScreen;
            nomina.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}
