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
    public partial class FormAdminAeronaves : Form
    {
        public FormAdminAeronaves()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelAeronaves.Controls.Count > 0)
                this.panelAeronaves.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelAeronaves.Controls.Add(hijo);
            this.panelAeronaves.Tag = hijo;
            hijo.Show();
        }

        private void btnRegistrarAeronave_Click(object sender, EventArgs e)
        {
            this.btnRegistrarAeronave.BackColor = Color.FromArgb(23, 185, 120);
            this.btnAdministrarAeronave.BackColor = Color.FromArgb(46, 61, 79);
            abrirFormularioHijo(new FormAdminAeronavesRegistro());
        }

        private void btnAdministrarAeronave_Click(object sender, EventArgs e)
        {
            this.btnRegistrarAeronave.BackColor = Color.FromArgb(46, 61, 79);
            this.btnAdministrarAeronave.BackColor = Color.FromArgb(23, 185, 120);
            abrirFormularioHijo(new FormAdminAeronavesAeronave());
        }
    }
}
