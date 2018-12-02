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
    public partial class FormVistaPrincipalEmpleados : Form
    {
        CnSesion sesion = new CnSesion();
        public FormVistaPrincipalEmpleados(CnSesion datos)
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

        private void btnInformes_Click(object sender, EventArgs e)
        {
            btnInformes.BackColor = Color.FromArgb(23, 185, 120);
            btnMiCuenta.BackColor=Color.FromArgb(44, 61, 79);
            abrirFormularioHijo(new FormEmpleadosInformes());
        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            btnInformes.BackColor = Color.FromArgb(44, 61, 79);
            btnMiCuenta.BackColor = Color.FromArgb(23, 185, 120);
            abrirFormularioHijo(new FormMiCuenta(sesion));
        }

        private void FormVistaPrincipalEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
