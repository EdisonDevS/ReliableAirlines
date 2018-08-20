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
    public partial class FormContabilidadGeneral : Form
    {
        public FormContabilidadGeneral()
        {
            InitializeComponent();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            FormContabilidadGeneralEstadistica estadistica = new FormContabilidadGeneralEstadistica();
            estadistica.Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FormContabilidadGeneralInforme informe = new FormContabilidadGeneralInforme();
            informe.Show();
        }
    }
}
