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
    public partial class FormContabilidad : Form
    {
        public FormContabilidad()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelEleccionContabilidad.Controls.Count > 0)
                this.panelEleccionContabilidad.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelEleccionContabilidad.Controls.Add(hijo);
            this.panelEleccionContabilidad.Tag = hijo;
            hijo.Show();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormContabilidadGeneral());
            pnlActivoGeneral.Visible = true;
            pnlActivoGastos.Visible = false;
            pnlActivoIngresos.Visible = false;
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormContabilidadGastos());
            pnlActivoGeneral.Visible = false;
            pnlActivoGastos.Visible = true;
            pnlActivoIngresos.Visible = false;
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormContabilidadIngresos());
            pnlActivoGeneral.Visible = false;
            pnlActivoGastos.Visible = false;
            pnlActivoIngresos.Visible = true;
        }
    }
}
