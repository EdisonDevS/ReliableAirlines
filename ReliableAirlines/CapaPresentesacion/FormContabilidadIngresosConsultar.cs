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
    public partial class FormContabilidadIngresosConsultar : Form
    {
        public FormContabilidadIngresosConsultar()
        {
            InitializeComponent();
        }
        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelConsultarIngreso.Controls.Count > 0)
                this.panelConsultarIngreso.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelConsultarIngreso.Controls.Add(hijo);
            this.panelConsultarIngreso.Tag = hijo;
            hijo.Show();
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormContabilidadIngresosConsultarVentas());
            btnVentas.BackColor = Color.FromArgb(23, 185, 120);
            btnExternos.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnExternos_Click(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(44, 61, 79);
            btnExternos.BackColor = Color.FromArgb(23, 185, 120);
        }
    }
}
