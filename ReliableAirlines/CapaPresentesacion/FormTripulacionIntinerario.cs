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
    public partial class FormTripulacionIntinerario : Form
    {
        public FormTripulacionIntinerario()
        {
            InitializeComponent();
        }

        private void btnProximos_Click(object sender, EventArgs e)
        {
            btnProximos.BackColor = Color.FromArgb(23, 185, 120);
            btnHistorial.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            btnProximos.BackColor = Color.FromArgb(44, 61, 79);
            btnHistorial.BackColor = Color.FromArgb(23, 185, 120);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTripulacionIntinerarioInfo informacion = new FormTripulacionIntinerarioInfo();
            informacion.Show();
        }
    }
}
