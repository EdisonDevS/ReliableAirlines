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
            FormGeneralBuzonRedactar responder = new FormGeneralBuzonRedactar();
            responder.Show();//se debe hacer que el destinatario vaya en el constructor
        }
    }
}
