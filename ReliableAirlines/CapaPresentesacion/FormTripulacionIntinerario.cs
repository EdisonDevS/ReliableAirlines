using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegociacion;

namespace CapaPresentesacion
{
    public partial class FormTripulacionIntinerario : Form
    {

        CnVuelos vuelos = new CnVuelos();
        CnSesion sesion = new CnSesion();
        public FormTripulacionIntinerario(CnSesion usuario)
        {
            InitializeComponent();
            this.sesion = usuario;
            this.dgvVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnProximos_Click(object sender, EventArgs e)
        {
            dgvVuelos.DataSource = vuelos.cargarVuelosTripulante(sesion.documento, 2);
            btnProximos.BackColor = Color.FromArgb(23, 185, 120);
            btnHistorial.BackColor = Color.FromArgb(44, 61, 79);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            dgvVuelos.DataSource = vuelos.cargarVuelosTripulante(sesion.documento, 1);
            btnProximos.BackColor = Color.FromArgb(44, 61, 79);
            btnHistorial.BackColor = Color.FromArgb(23, 185, 120);
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            int vueloSeleccionado = Int32.Parse(dgvVuelos.CurrentRow.Cells[0].Value.ToString());
            FormTripulacionIntinerarioInfo info = new FormTripulacionIntinerarioInfo(vueloSeleccionado);
            info.Show();
        }
    }
}
