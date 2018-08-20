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
    public partial class FormAdminNominaConsulta : Form
    {
        public FormAdminNominaConsulta()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelConsultaNomina.Controls.Count > 0)
                this.panelConsultaNomina.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelConsultaNomina.Controls.Add(hijo);
            this.panelConsultaNomina.Tag = hijo;
            hijo.Show();
        }

        private void consultaNomina_Load(object sender, EventArgs e)
        {

        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdminNominaConsultaGeneral());
            btnConsultaPersona.BackColor = Color.FromArgb(44, 61, 79);
            btnConsultaGenera.BackColor = Color.FromArgb(23, 185, 120);
        }

        private void btnConsultaPersona_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdminNominaConsultaAjuste());
            btnConsultaPersona.BackColor = Color.FromArgb(23, 185, 120);
            btnConsultaGenera.BackColor = Color.FromArgb(44, 61, 79);
        }
    }
}
