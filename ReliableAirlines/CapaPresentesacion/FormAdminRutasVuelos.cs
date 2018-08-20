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
    public partial class FormAdminRutasVuelos : Form
    {
        public FormAdminRutasVuelos()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelRutas.Controls.Count > 0)
                this.panelRutas.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelRutas.Controls.Add(hijo);
            this.panelRutas.Tag = hijo;
            hijo.Show();
        }

        private void btnRegistrarEmpleado_Click_1(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormCrearRuta());
            this.btnCrearRuta.BackColor = Color.FromArgb(23, 185, 120);
            this.btnAdministrarRuta.BackColor = Color.FromArgb(46, 61, 79);
        }

        private void btnAdministrarRuta_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdminVuelos());
            this.btnCrearRuta.BackColor = Color.FromArgb(46, 61, 79);
            this.btnAdministrarRuta.BackColor = Color.FromArgb(23, 185, 120);
        }
    }
}
