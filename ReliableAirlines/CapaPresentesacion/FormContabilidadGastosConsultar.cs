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
    public partial class FormContabilidadGastosConsultar : Form
    {
        public FormContabilidadGastosConsultar()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelConsultarGasto.Controls.Count > 0)
                this.panelConsultarGasto.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelConsultarGasto.Controls.Add(hijo);
            this.panelConsultarGasto.Tag = hijo;
            hijo.Show();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            btnNomina.BackColor = Color.FromArgb(23, 185, 120);
            btnOtros.BackColor = Color.FromArgb(44, 61, 79);
            abrirFormularioHijo(new FormContabilidadGastosConsultarNomina());
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            btnNomina.BackColor = Color.FromArgb(44, 61, 79);
            btnOtros.BackColor = Color.FromArgb(23, 185, 120);
            abrirFormularioHijo(new FormContabilidadGastosConsultarOtros());
        }
    }
}
