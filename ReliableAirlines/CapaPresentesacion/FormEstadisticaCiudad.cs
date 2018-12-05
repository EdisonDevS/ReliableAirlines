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
    public partial class FormEstadisticaCiudad : Form
    {
        public FormEstadisticaCiudad()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            FormEstadisticaCiudadGrafica grafica = new FormEstadisticaCiudadGrafica();
            grafica.Show();
        }
    }
}
