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
    public partial class FormContabilidadGastosConsultarReembolsos : Form
    {
        CnVentas venta = new CnVentas();
        DataTable datos = new DataTable();

        public FormContabilidadGastosConsultarReembolsos()
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
                datos = venta.consultarReembolsos(dtpInicio.Text, dtpFinal.Text);
                dgvVentas.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido unerror al inentar conectar con la base de datos: "+ex);
            }
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

            DataTable justificacion = venta.consultaJustificacion(Int32.Parse(dgvVentas.CurrentRow.Cells[0].Value.ToString()));
            txtJustificacion.Text = justificacion.Rows[0][0].ToString();

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            DatosReembolso reemb = new DatosReembolso();
            ReporteReembolso rep = new ReporteReembolso();

            reemb.Nombre = datos.Rows[0][0].ToString() + " " + datos.Rows[0][1].ToString();
            reemb.Identificacion = datos.Rows[0][2].ToString();
            reemb.Salida = datos.Rows[0][3].ToString();
            reemb.Llegada = datos.Rows[0][4].ToString();
            reemb.Origen = datos.Rows[0][5].ToString();
            reemb.Destino = datos.Rows[0][6].ToString();
            if (datos.Rows[0][7].ToString() == "1")
            {
                reemb.Clase = "Primera clase";
                reemb.Valor = datos.Rows[0][9].ToString();
            }
            else
            {
                reemb.Clase = "Clase turista";
                reemb.Valor = datos.Rows[0][8].ToString();
            }

            DataTable justificacion = venta.consultaJustificacion(Int32.Parse(dgvVentas.CurrentRow.Cells[0].Value.ToString()));
            reemb.Fecha = justificacion.Rows[0][1].ToString();
            reemb.Justificacion = justificacion.Rows[0][0].ToString();
            reemb.Tiquete = dgvVentas.CurrentRow.Cells[0].Value.ToString();

            rep.reembolso.Add(reemb);
            rep.ShowDialog();
        }
    }
}
