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
    public partial class FormContabilidadGastos : Form
    {
        public FormContabilidadGastos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FormContabilidadGastosGenerar generar = new FormContabilidadGastosGenerar();
            generar.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FormContabilidadGastosConsultar consulta = new FormContabilidadGastosConsultar();
            consulta.Show();
        }
    }
}
