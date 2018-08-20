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
    public partial class FormGeneralBuzonRedactar : Form
    {
        
        public FormGeneralBuzonRedactar(string destinatario)
        {
            InitializeComponent();
            abrirFormularioHijo(new FormGeneralBuzonRedactarMensaje(destinatario));
        }

        public FormGeneralBuzonRedactar()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelRedactar.Controls.Count > 0)
                this.panelRedactar.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelRedactar.Controls.Add(hijo);
            this.panelRedactar.Tag = hijo;
            hijo.Show();
        }

        private void btnMensajes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarMensaje());
            this.btnMensajes.BackColor = Color.FromArgb(23, 185, 120);
            this.btnSolicitud.BackColor = Color.FromArgb(46, 61, 79);

        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FormGeneralBuzonRedactarSolicitud());
            this.btnMensajes.BackColor = Color.FromArgb(46, 61, 79);
            this.btnSolicitud.BackColor = Color.FromArgb(23, 185, 120);
        }

        private void FormVentanaRedactar_Load(object sender, EventArgs e)
        {

            
        }
    }
}
