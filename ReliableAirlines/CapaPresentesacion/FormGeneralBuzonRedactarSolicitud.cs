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
    public partial class FormGeneralBuzonRedactarSolicitud : Form
    {
        public FormGeneralBuzonRedactarSolicitud()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelLlenarSolicitud.Controls.Count > 0)
                this.panelLlenarSolicitud.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelLlenarSolicitud.Controls.Add(hijo);
            this.panelLlenarSolicitud.Tag = hijo;
            hijo.Show();
        }

        private void rbReembolso_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarSolicitudReembolso());
        }

        private void rbIncapacidad_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarSolicitudOtra());
        }

        private void rbPrestamo_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarSolicitudOtra());
        }

        private void rbQueja_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarSolicitudOtra());
        }

        private void rbReclamo_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarSolicitudOtra());
        }

        private void rbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarSolicitudOtra());
        }

        private void rbRenuncia_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarSolicitudOtra());
        }

        private void rbSugerencia_CheckedChanged(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarSolicitudOtra());
        }
    }
}
