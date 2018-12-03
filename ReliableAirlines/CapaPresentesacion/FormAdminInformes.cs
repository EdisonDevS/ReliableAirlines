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
    public partial class FormAdminInformes : Form
    {
        public FormAdminInformes()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelInformes.Controls.Count > 0)
                this.panelInformes.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelInformes.Controls.Add(hijo);
            this.panelInformes.Tag = hijo;
            hijo.Show();
        }

        private void btnInformeEmpleado_Click(object sender, EventArgs e)
        {
            this.btnInformeEmpleado.BackColor = Color.FromArgb(23, 185, 120);
            this.btnInformeVuelos.BackColor = Color.FromArgb(46, 61, 79);
            abrirFormularioHijo(new FormAdminInformesEmpleados());
        }

        private void btnInformeVuelos_Click(object sender, EventArgs e)
        {
            this.btnInformeEmpleado.BackColor = Color.FromArgb(46, 61, 79);
            this.btnInformeVuelos.BackColor = Color.FromArgb(23, 185, 120);
            abrirFormularioHijo(new FormAdminInformesVuelos());
        }
    }
}
