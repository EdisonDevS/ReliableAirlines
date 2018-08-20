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
    public partial class FormGeneralBuzon : Form
    {
        public FormGeneralBuzon()
        {
            InitializeComponent();
        }

        private void btnRecibidos_Click(object sender, EventArgs e)
        {
            FormGeneralBuzonRecibidos recibidos = new FormGeneralBuzonRecibidos();
            recibidos.Show();
        }

        private void btnRedactar_Click(object sender, EventArgs e)
        {
            FormGeneralBuzonRedactar redactar = new FormGeneralBuzonRedactar();
            redactar.Show();
        }
    }
}
