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
using System.Data;

namespace CapaPresentesacion
{
    public partial class FormContabilidadIngresosConsultarVentas : Form
    {
        CnVentas venta = new CnVentas();
        public FormContabilidadIngresosConsultarVentas()
        {
            InitializeComponent();
            this.dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtpHoraSalida.CustomFormat = "HH:mm";
            dtpHoraLlegada.CustomFormat = "HH:mm";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datos = new DataTable();
                datos = venta.consultarVentas(dtpInicio.Text, dtpFinal.Text);
                dgvVentas.DataSource = datos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido unerror al inentar conectar con la base de datos");
            }
            
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable datos = new DataTable();

            datos = venta.obtenerInfoVentaReembolso(Int32.Parse(dgvVentas.CurrentRow.Cells[0].Value.ToString()));

            lblNombres.Text = "Nombres: ";
            lblApellidos.Text = "Apellidos: ";
            lblIdentificación.Text = "Identificación: ";
            lblOrigen.Text = "Origen: ";
            lblDestino.Text = "Destino: ";
            lblClase.Text = "Clase: ";
            lblValor.Text = "Valor: ";

            lblNombres.Text += datos.Rows[0][0].ToString();
            lblApellidos.Text += datos.Rows[0][1].ToString();
            lblIdentificación.Text += datos.Rows[0][2].ToString();
            dtpSalida.Text = datos.Rows[0][3].ToString();
            dtpLlegada.Text = datos.Rows[0][4].ToString();
            lblOrigen.Text += datos.Rows[0][5].ToString();
            lblDestino.Text += datos.Rows[0][6].ToString();

            if (datos.Rows[0][7].ToString() == "1")
            {
                lblClase.Text += "Primera clase";
                lblValor.Text += datos.Rows[0][9].ToString();
            }
            else
            {
                lblClase.Text += "Clase turista";
                lblValor.Text += datos.Rows[0][8].ToString();
            }
        }
    }
}
