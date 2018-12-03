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
    public partial class FormVistaPrincipalTripulante : Form
    {
        CnSesion sesion = new CnSesion();
        public FormVistaPrincipalTripulante(CnSesion datos)
        {
            InitializeComponent();
            this.sesion = datos;
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

        private void btnIntinerario_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormTripulacionIntinerario(sesion));
            btnIntinerario.BackColor = Color.FromArgb(23, 185, 120);
            btnInformes.BackColor = Color.FromArgb(44, 61, 79);
            btnMiCuenta.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormTripulacionInformes(sesion));
            btnIntinerario.BackColor = Color.FromArgb(44, 61, 79);
            btnInformes.BackColor = Color.FromArgb(23, 185, 120);
            btnMiCuenta.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormMiCuenta(sesion));
            btnIntinerario.BackColor = Color.FromArgb(44, 61, 79);
            btnInformes.BackColor = Color.FromArgb(44, 61, 79);
            btnMiCuenta.BackColor = Color.FromArgb(23, 185, 120);
        }
    }
}
