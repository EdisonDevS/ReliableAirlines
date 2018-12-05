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
    public partial class FormEstadisticaOtros : Form
    {
        public FormEstadisticaOtros()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            FormEstadisticaOtrosGrafica grafica = new FormEstadisticaOtrosGrafica();
            grafica.Show();
        }
    }
}
