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

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            pnlActivoGeneral.Visible = true;
            pnlActivoGastos.Visible = false;
            pnlActivoIngresos.Visible = false;
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            pnlActivoGeneral.Visible = false;
            pnlActivoGastos.Visible = true;
            pnlActivoIngresos.Visible = false;
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            pnlActivoGeneral.Visible = false;
            pnlActivoGastos.Visible = false;
            pnlActivoIngresos.Visible = true;
        }
    }
}
