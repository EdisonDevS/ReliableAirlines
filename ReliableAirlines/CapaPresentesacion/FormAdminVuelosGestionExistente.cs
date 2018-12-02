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
    public partial class FormAdminVuelosGestionExistente : Form
    {
        CnRutas ruta = new CnRutas();
        CnAeronaves aer = new CnAeronaves();
        CnVuelos vuelo = new CnVuelos();
        CnTripulacion trip = new CnTripulacion();
        public FormAdminVuelosGestionExistente()
        {
            InitializeComponent();
            this.dgvTripulacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtpHoraSalida.CustomFormat = "HH:mm";
            dtpHoraLlegada.CustomFormat = "HH:mm";
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            dgvTripulacion.DataSource = trip.ConsultarTripulantes(Int32.Parse(txtNumVuelo.Text));

            CnVuelos vuelo = new CnVuelos();
            DataTable datosPrimarios = new DataTable();
            datosPrimarios = vuelo.CargarDatos(Convert.ToInt32(txtNumVuelo.Text));

            DataTable rutas = new DataTable();
            rutas = ruta.ConsultaGralRutas();
            cbbNombreRuta.DataSource = rutas;
            cbbNombreRuta.DisplayMember = "Nombre Ruta";
            cbbNombreRuta.ValueMember = "ID Ruta";

            DataTable aeronave = new DataTable();
            aeronave = aer.ConsultarMatriculas();
            cbbMatriculaAeronave.DataSource = aeronave;
            cbbMatriculaAeronave.DisplayMember = "idAeronave";
            
            cbbMatriculaAeronave.Text = datosPrimarios.Rows[0][3].ToString();

            txtVlrPclase.Text = datosPrimarios.Rows[0][8].ToString();
            txtVlrCturista.Text = datosPrimarios.Rows[0][9].ToString();

            dtpLlegada.Text = datosPrimarios.Rows[0][7].ToString();
            dtpSalida.Text = datosPrimarios.Rows[0][6].ToString();
            dtpHoraLlegada.Text = datosPrimarios.Rows[0][7].ToString();
            dtpHoraSalida.Text = datosPrimarios.Rows[0][6].ToString();
        }

        private void cbbNombreRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable cargar = new DataTable();
                cargar = ruta.ConsultaEspecificaRutas(Convert.ToInt32(cbbNombreRuta.SelectedValue));
                lblCiuOri.Text = cargar.Rows[0][3].ToString();
                lblCiuDes.Text = cargar.Rows[0][5].ToString();
                lblAerOri.Text = cargar.Rows[0][2].ToString();
                lblAerDes.Text = cargar.Rows[0][4].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void cbbMatriculaAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable cargar = new DataTable();
                cargar = aer.ConsultaPorMatricula(cbbMatriculaAeronave.Text);
                lblCapPclas.Text = cargar.Rows[0][2].ToString();
                lblCapCtur.Text = cargar.Rows[0][3].ToString();
                lblTipoAer.Text = cargar.Rows[0][1].ToString();
                lblEstAct.Text = cargar.Rows[0][7].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnCrearVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                int numVuelo = Convert.ToInt32(txtNumVuelo.Text);
                int idRuta = Convert.ToInt32(cbbNombreRuta.SelectedValue);

                vuelo.ActualizarVuelos(numVuelo, idRuta, cbbMatriculaAeronave.Text, dtpSalida.Text, dtpHoraSalida.Text,
                                dtpLlegada.Text, dtpHoraLlegada.Text, txtVlrPclase.Text, txtVlrCturista.Text);
                MessageBox.Show("Vuelo actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error actualizando los datos:\n"+ex);
            }
        }

        private void btnVerTripulante_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable infoTrip = new DataTable();
                infoTrip = trip.CargarTripulante(txtDocTripulante.Text);
                lblNombreTrip.Text += infoTrip.Rows[0][0].ToString() + " " + infoTrip.Rows[0][1].ToString();
                lblPuestoTip.Text += infoTrip.Rows[0][2].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnAgregarTripu_Click(object sender, EventArgs e)
        {
            try
            {
                trip.AgregarTripulanteAvuelo(txtDocTripulante.Text, Convert.ToInt32(txtNumVuelo.Text), cbbAgregarComo.Text);
                MessageBox.Show("Se ha agregado el tripulante correctamente");
                dgvTripulacion.DataSource = trip.ConsultarTripulantes(Int32.Parse(txtNumVuelo.Text));
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo mas tarde");
            }
            

            
        }
    }
}
