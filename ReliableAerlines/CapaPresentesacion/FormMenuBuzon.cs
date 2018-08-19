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
    public partial class FormMenuBuzon : Form
    {
        public FormMenuBuzon()
        {
            InitializeComponent();
        }

        private void btnRecibidos_Click(object sender, EventArgs e)
        {
            FormVentanaRecibidos recibidos = new FormVentanaRecibidos();
            recibidos.Show();
        }

        private void btnRedactar_Click(object sender, EventArgs e)
        {
            FormVentanaRedactar redactar = new FormVentanaRedactar();
            redactar.Show();
        }
    }
}
