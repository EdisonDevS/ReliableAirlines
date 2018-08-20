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
    public partial class FormGeneralBuzonRecibidosSolicitudesGargar : Form
    {

        private string tipo;
        public FormGeneralBuzonRecibidosSolicitudesGargar(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void btnVerSeleccionado_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case "reembolso":
                    FormGeneralBuzonRecibidosSolicitudGargarReembolso reembolso = new FormGeneralBuzonRecibidosSolicitudGargarReembolso();
                    reembolso.Show();
                    break;
                //poner default para los otros
            }
        }
    }
}
