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
    public partial class FormClientesReservas : Form
    {
        public FormClientesReservas()
        {
            InitializeComponent();
        }
        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(hijo);
            this.panelContainer.Tag = hijo;
            hijo.Show();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormClientesReservasReservar());
            btnReservar.BackColor = Color.FromArgb(23, 185, 120);
            btnMisVuelos.BackColor = Color.FromArgb(44, 61, 79);
            btnHistorial.BackColor = Color.FromArgb(44, 61, 79);
        }
        private void btnMisVuelos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormClientesReservasMisReservas());
            btnReservar.BackColor = Color.FromArgb(44, 61, 79);
            btnMisVuelos.BackColor = Color.FromArgb(23, 185, 120);
            btnHistorial.BackColor = Color.FromArgb(44, 61, 79);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormClientesReservasHistorial());
            btnReservar.BackColor = Color.FromArgb(44, 61, 79);
            btnMisVuelos.BackColor = Color.FromArgb(44, 61, 79);
            btnHistorial.BackColor = Color.FromArgb(23, 185, 120);
        }

        
    }
}
