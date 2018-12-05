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
    public partial class FormContabilidadIngresosGenerarVentas : Form
    {
        CnVentas venta = new CnVentas();
        public FormContabilidadIngresosGenerarVentas()
        {
            InitializeComponent();
            dtpHoraSalida.CustomFormat = "HH:mm";
            dtpHoraLlegada.CustomFormat = "HH:mm";
        }

        private void FormContabilidadIngresosGenerarVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtReserva.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                try
                {
                    DataTable datos = new DataTable();
                    datos = venta.obtenerInfoVenta(txtReserva.Text);
                    lblNombres.Text = lblNombres.Text + datos.Rows[0][0].ToString();
                    lblApellidos.Text = lblApellidos.Text + datos.Rows[0][1].ToString();
                    lblIdentificación.Text = lblIdentificación.Text + datos.Rows[0][2].ToString();
                    lblOrigen.Text = lblOrigen.Text + datos.Rows[0][5].ToString();
                    lblDestino.Text = lblDestino.Text + datos.Rows[0][6].ToString();
                    dtpSalida.Text = datos.Rows[0][3].ToString();
                    dtpLlegada.Text = datos.Rows[0][4].ToString();
                    dtpHoraSalida.Text = datos.Rows[0][3].ToString();
                    dtpHoraLlegada.Text = datos.Rows[0][4].ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha encontrado ningún tiquete con este código");
                }
            }

        }

        private void btnGenerarGasto_Click(object sender, EventArgs e)
        {
            venta.validarReserva(txtReserva.Text);
        }
    }
}
