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
    public partial class FormConsultarVuelo : Form
    {
        public FormConsultarVuelo()
        {
            InitializeComponent();
            rbNumeroVuelo.Checked = true;
        }

        private void rbNumeroVuelo_CheckedChanged(object sender, EventArgs e)
        {
            txtNumVuelo.Enabled = true;
            txtIDSalida.Enabled = false;
            txtIDDestino.Enabled = false;
        }

        private void rbRuta_CheckedChanged(object sender, EventArgs e)
        {
            txtNumVuelo.Enabled = false;
            txtIDSalida.Enabled = true;
            txtIDDestino.Enabled = true;
        }
    }
}
