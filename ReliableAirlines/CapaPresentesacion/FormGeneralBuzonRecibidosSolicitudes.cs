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
            abrirFormularioHijo(new FormGeneralBuzonRecibidosSolicitudesGargar("reembolso"));//en el constructor se manda el tipo
        }

        private void rbRenuncia_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRecibidosSolicitudesGargar("denuncia"));
        }

        private void rbSugerencia_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRecibidosSolicitudesGargar("sugerencia"));
        }

        private void rbQueja_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRecibidosSolicitudesGargar("queja"));
        }

        private void rbReclamo_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRecibidosSolicitudesGargar("reclamo"));
        }

        private void rbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRecibidosSolicitudesGargar("consulta"));
        }

        private void rbIncapacidad_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRecibidosSolicitudesGargar("incapacidad"));
        }

        private void rbPrestamo_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRecibidosSolicitudesGargar("prestamo"));
        }
    }
}
