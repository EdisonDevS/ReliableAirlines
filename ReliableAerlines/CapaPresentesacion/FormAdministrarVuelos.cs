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
    public partial class FormAdministrarVuelos : Form
    {
        public FormAdministrarVuelos()
        {
            InitializeComponent();
        }

        private void btnConsultaVuelos_Click(object sender, EventArgs e)
        {
            FormConsultarVuelo Consultar = new FormConsultarVuelo();
            Consultar.Show();
        }

        private void btnAdministrarVuelos_Click(object sender, EventArgs e)
        {
            FormAdministracionVuelos Administrar = new FormAdministracionVuelos();
            Administrar.Show();
        }
    }
}
