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
    public partial class FormGeneralBuzonRecibidosSolicitudGargarOtras : Form
    {
        public FormGeneralBuzonRecibidosSolicitudGargarOtras()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            string destinatario = "Prueba";
            FormGeneralBuzonRedactar responder = new FormGeneralBuzonRedactar(destinatario);
            responder.Show();
        }
    }
}
