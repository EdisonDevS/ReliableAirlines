using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentesacion
{
    public partial class FormVistaPrincipalAdmin : Form
    {
        public FormVistaPrincipalAdmin()
        {
            InitializeComponent();
            abrirFormularioHijo(new FormInicio());
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

        private void btnAdministración_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdmin());
            lblRuta.Text = "Administración";
            btnAdministración.BackColor = Color.FromArgb(23, 185, 120);
            btnContabilidad.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormContabilidad());
            lblRuta.Text = "Contabilidad";
            btnContabilidad.BackColor = Color.FromArgb(23, 285, 120);
            btnAdministración.BackColor = Color.FromArgb(44, 61, 79);
        }
    }
}
