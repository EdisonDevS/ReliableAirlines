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
    public partial class FormTripulacionIntinerarioInfo : Form
    {
        int vueloSeleccionado;
        CnVuelos vuelo = new CnVuelos();
        public FormTripulacionIntinerarioInfo(int numVuelo)
        {
            InitializeComponent();
            this.vueloSeleccionado = numVuelo;
            this.dgvTripulacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable info = vuelo.cargarVuelosTripulanteInfo(vueloSeleccionado);
            lblClaseT.Text += info.Rows[0][1].ToString();
            lblPclase.Text += info.Rows[0][0].ToString();
            lblVlrClaseT.Text += info.Rows[0][5].ToString();
            lblVlrPclase.Text += info.Rows[0][4].ToString();
            dtpFechaSalida.Text += info.Rows[0][2].ToString();
            dtpHoraSalida.Text += info.Rows[0][2].ToString();
            dtpFechaLlegada.Text += info.Rows[0][3].ToString();
            dtpHoraLlegada.Text += info.Rows[0][3].ToString();

            DataTable tripu = vuelo.datosPersonalesTripulacion(vueloSeleccionado);
            dgvTripulacion.DataSource = tripu;
        }
    }
}
