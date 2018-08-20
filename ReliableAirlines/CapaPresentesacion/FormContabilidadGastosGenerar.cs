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
    public partial class FormContabilidadGastosGenerar : Form
    {
        public FormContabilidadGastosGenerar()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelGenerarGasto.Controls.Count > 0)
                this.panelGenerarGasto.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelGenerarGasto.Controls.Add(hijo);
            this.panelGenerarGasto.Tag = hijo;
            hijo.Show();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            
        }
    }
}
