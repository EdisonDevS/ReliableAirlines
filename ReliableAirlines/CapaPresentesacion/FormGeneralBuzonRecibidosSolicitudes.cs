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
    public partial class FormGeneralBuzonRecibidosSolicitudes : Form
    {
        public FormGeneralBuzonRecibidosSolicitudes()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelCargarSolicitudes.Controls.Count > 0)
                this.panelCargarSolicitudes.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelCargarSolicitudes.Controls.Add(hijo);
            this.panelCargarSolicitudes.Tag = hijo;
            hijo.Show();
        }

        private void rbReembolso_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRecibidosSolicitudesGargar());//en el constructor se manda el tipo
        }
    }
}
