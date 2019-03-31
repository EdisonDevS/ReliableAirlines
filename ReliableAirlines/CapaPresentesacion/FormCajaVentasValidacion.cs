using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaNegociacion;

namespace CapaPresentesacion
{
    public partial class FormCajaVentasValidacion : Form
    {
        CnVentas venta = new CnVentas();
        DataTable datos = new DataTable();
        public FormCajaVentasValidacion()
        {
            InitializeComponent();
            dtpHoraSalida.CustomFormat = "HH:mm";
            dtpHoraLlegada.CustomFormat = "HH:mm";
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
                    if (Int32.Parse(datos.Rows[0][7].ToString()) == 1)
                        lblClase.Text += " Primera";
                    else
                        lblClase.Text += " Turista";

                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha encontrado ningún tiquete con este código");
                }
            }
  
        }

        private void btnGenerarGasto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReserva.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                try
                {
                    venta.validarReserva(txtReserva.Text);

                    DatosTiquete tiquete = new DatosTiquete();
                    ReporteTiquetes reporteTiquete = new ReporteTiquetes();

                    if (Int32.Parse(datos.Rows[0][7].ToString()) == 1)
                        tiquete.Clase = "Primera";
                    else
                        tiquete.Clase = "Turista";

                    tiquete.Nombre = datos.Rows[0][0].ToString() + " " + datos.Rows[0][1].ToString();
                    tiquete.Documento = datos.Rows[0][2].ToString();
                    tiquete.Origen = datos.Rows[0][5].ToString();
                    tiquete.Destino = datos.Rows[0][6].ToString();
                    tiquete.Salida = datos.Rows[0][3].ToString();
                    tiquete.Llegada = datos.Rows[0][4].ToString();
                    tiquete.Vuelo = datos.Rows[0][8].ToString();
                    tiquete.ID = txtReserva.Text;

                    reporteTiquete.Tiquete.Add(tiquete);
                    reporteTiquete.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error con la base de datos");
                }
            }
            
            
        }

        private void FormCajaVentasValidacion_Load(object sender, EventArgs e)
        {

        }
    }
}
