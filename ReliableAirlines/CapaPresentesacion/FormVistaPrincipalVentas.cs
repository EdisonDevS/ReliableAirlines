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
    public partial class FormVistaPrincipalVentas : Form
    {
        public FormVistaPrincipalVentas()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(23, 185, 120);
            btnReembolso.BackColor = Color.FromArgb(44, 61, 79);
            btnBuzon.BackColor = Color.FromArgb(44, 61, 79);
            btnMiCuenta.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnReembolso_Click(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(44, 61, 79);
            btnReembolso.BackColor = Color.FromArgb(23, 185, 120);
            btnBuzon.BackColor = Color.FromArgb(44, 61, 79);
            btnMiCuenta.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnBuzon_Click(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(44, 61, 79);
            btnReembolso.BackColor = Color.FromArgb(44, 61, 79);
            btnBuzon.BackColor = Color.FromArgb(23, 185, 120);
            btnMiCuenta.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(44, 61, 79);
            btnReembolso.BackColor = Color.FromArgb(44, 61, 79);
            btnBuzon.BackColor = Color.FromArgb(44, 61, 79);
            btnMiCuenta.BackColor = Color.FromArgb(23, 185, 120);
        }
    }
}
