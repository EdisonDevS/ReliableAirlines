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
    public partial class FormVentasVenta : Form
    {
        public FormVentasVenta()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelEleccionVentas.Controls.Count > 0)
                this.panelEleccionVentas.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelEleccionVentas.Controls.Add(hijo);
            this.panelEleccionVentas.Tag = hijo;
            hijo.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            panelActivoValidacion.Visible = false;
            pnlActivoVenta.Visible = true;
        }

        private void btnValidacion_Click(object sender, EventArgs e)
        {
            panelActivoValidacion.Visible = true;
            pnlActivoVenta.Visible = false;
        }
    }
}
