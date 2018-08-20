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
    public partial class FormAdminVuelos : Form
    {
        public FormAdminVuelos()
        {
            InitializeComponent();
        }

        private void btnConsultaVuelos_Click(object sender, EventArgs e)
        {
            FormAdminVuelosConsulta Consultar = new FormAdminVuelosConsulta();
            Consultar.Show();
        }

        private void btnAdministrarVuelos_Click(object sender, EventArgs e)
        {
            FormAdminVuelosGestion Administrar = new FormAdminVuelosGestion();
            Administrar.Show();
        }
    }
}
