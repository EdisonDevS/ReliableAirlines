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
    public partial class FormContabilidadIngresos : Form
    {
        public FormContabilidadIngresos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FormContabilidadIngresosGenerar generar = new FormContabilidadIngresosGenerar();
            generar.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FormContabilidadIngresosConsultar consulta = new FormContabilidadIngresosConsultar();
            consulta.Show();
        }
    }
}
