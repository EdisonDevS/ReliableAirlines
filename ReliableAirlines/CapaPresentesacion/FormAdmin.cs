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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelEleccionAdmin.Controls.Count > 0)
                this.panelEleccionAdmin.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelEleccionAdmin.Controls.Add(hijo);
            this.panelEleccionAdmin.Tag = hijo;
            hijo.Show();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdminNomina());
            this.pnlActivoNomina.Visible = true;
            this.pnlActivoClientes.Visible = false;
            this.pnlActivoBuzon.Visible = false;
            this.pnlActivoRuta.Visible = false;
            this.pnlActivoAeronave.Visible = false;
        }
        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private void btnAeronaves_Click(object sender, EventArgs e)
        {

        }

        private void btnRutas_Click(object sender, EventArgs e)
        {

        }

        private void btnBuzon_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void pnlActivoBuzón_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdminClientes());
            this.pnlActivoNomina.Visible = false;
            this.pnlActivoClientes.Visible = true;
            this.pnlActivoBuzon.Visible = false;
            this.pnlActivoRuta.Visible = false;
            this.pnlActivoAeronave.Visible = false;
        }

        private void btnBuzon_Click_1(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzon());
            this.pnlActivoNomina.Visible = false;
            this.pnlActivoClientes.Visible = false;
            this.pnlActivoBuzon.Visible = true;
            this.pnlActivoRuta.Visible = false;
            this.pnlActivoAeronave.Visible = false;
        }

        private void btnRutas_Click_1(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdminRutasVuelos());
            this.pnlActivoNomina.Visible = false;
            this.pnlActivoClientes.Visible = false;
            this.pnlActivoBuzon.Visible = false;
            this.pnlActivoRuta.Visible = true;
            this.pnlActivoAeronave.Visible = false;
        }

        private void btnAeronaves_Click_1(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormAdminAeronaves());
            this.pnlActivoNomina.Visible = false;
            this.pnlActivoClientes.Visible = false;
            this.pnlActivoBuzon.Visible = false;
            this.pnlActivoRuta.Visible = false;
            this.pnlActivoAeronave.Visible = true;
        
        }
    }
}
