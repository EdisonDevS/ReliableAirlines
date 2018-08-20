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
    public partial class FormGeneralBuzonRecibidos : Form
    {
        public FormGeneralBuzonRecibidos()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelRecibidos.Controls.Count > 0)
                this.panelRecibidos.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelRecibidos.Controls.Add(hijo);
            this.panelRecibidos.Tag = hijo;
            hijo.Show();
        }

        private void btnMensajes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarMensaje());
            this.btnMensajes.BackColor = Color.FromArgb(23, 185, 120);
            this.btnSolicitudes.BackColor = Color.FromArgb(46, 61, 79);
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            this.btnMensajes.BackColor = Color.FromArgb(46, 61, 79);
            this.btnSolicitudes.BackColor = Color.FromArgb(23, 185, 120);
        }
    }
}
