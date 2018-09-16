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
    public partial class FormAdminRutasVerRutas : Form
    {
        CnRutas rutas = new CnRutas();
        public FormAdminRutasVerRutas()
        {
            InitializeComponent();

            dgvRutas.DataSource = rutas.ConsultaGralRutas();
            this.dgvRutas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            int idRuta = Convert.ToInt32(dgvRutas.CurrentRow.Cells[0].Value);
            DataTable info = new DataTable();
            info = rutas.ConsultaEspecificaRutas(idRuta);
            lblId.Text = info.Rows[0][0].ToString();
            lblNombre.Text = info.Rows[0][1].ToString();
            lblCiuOrigen.Text = info.Rows[0][3].ToString();
            lblCiuDestino.Text = info.Rows[0][5].ToString();
            lblAerOrigen.Text = info.Rows[0][2].ToString();
            lblAerDestino.Text = info.Rows[0][4].ToString();
            cbbEstado.Text = info.Rows[0][6].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int ruta = Convert.ToInt32(lblId.Text);
            rutas.ActualizarEstadoRuta(ruta, cbbEstado.Text);
            MessageBox.Show("Se ha cambiad el estado correctamente");
        }
    }
}
