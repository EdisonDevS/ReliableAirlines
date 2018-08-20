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
    public partial class FormAdminVuelosGestion : Form
    {
        public FormAdminVuelosGestion()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelAdminVuelo.Controls.Count > 0)
                this.panelAdminVuelo.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelAdminVuelo.Controls.Add(hijo);
            this.panelAdminVuelo.Tag = hijo;
            hijo.Show();
        }

        private void btnNuevoVuelo_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdminVuelosGestionNuevo());
            this.btnNuevoVuelo.BackColor = Color.FromArgb(23, 185, 120);
            this.btnVueloExistente.BackColor = Color.FromArgb(46, 61, 79);
        }

        private void btnVueloExistente_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdminVuelosGestionExistente());
            this.btnNuevoVuelo.BackColor = Color.FromArgb(46, 61, 79);
            this.btnVueloExistente.BackColor = Color.FromArgb(23, 185, 120);
        }
    }
}
