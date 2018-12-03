using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegociacion;

namespace CapaPresentesacion
{
    public partial class FormVistaPrincipalCaja : Form
    {
        CnSesion sesion = new CnSesion();
        public FormVistaPrincipalCaja(CnSesion datos)
        {
            InitializeComponent();
            this.sesion = datos;
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

        private void btnVenta_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormCajaVentas());
        }

        private void btnReembolso_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormCajaReembolsos(sesion));
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormMiCuenta(sesion));
        }
    }
}
