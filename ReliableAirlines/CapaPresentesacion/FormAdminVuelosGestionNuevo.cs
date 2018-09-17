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
    public partial class FormAdminVuelosGestionNuevo : Form
    {
        CnRutas ruta = new CnRutas();
        CnAeronaves aer = new CnAeronaves();
        CnVuelos vuelo = new CnVuelos();
        CnTripulacion trip = new CnTripulacion();

        public FormAdminVuelosGestionNuevo()
        {
            InitializeComponent();

            dtpHoraSalida.CustomFormat = "HH:mm";
            dtpHoraLlegada.CustomFormat = "HH:mm";

            DataTable rutas = new DataTable();
            rutas = ruta.ConsultaGralRutas();
            cbbNombreRuta.DataSource = rutas;
            cbbNombreRuta.DisplayMember = "Nombre Ruta";
            cbbNombreRuta.ValueMember = "ID Ruta";

            DataTable aeronave = new DataTable();
            aeronave = aer.ConsultarMatriculas();
            cbbMatriculaAeronave.DataSource = aeronave;
            cbbMatriculaAeronave.DisplayMember = "idAeronave";
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
            catch(Exception)
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
            catch(Exception)
            {

            }
        }

        private void btnCrearVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                int numVuelo = Convert.ToInt32(txtNumVuelo.Text);
                int idRuta = Convert.ToInt32(cbbNombreRuta.SelectedValue);

                vuelo.CrearVuelo(numVuelo, idRuta, cbbMatriculaAeronave.Text, dtpSalida.Text, dtpHoraSalida.Text,
                                dtpLlegada.Text, dtpHoraLlegada.Text, txtVlrPclase.Text, txtVlrCturista.Text);
                MessageBox.Show("Vuelo creado correctamente");

                txtDocTripulante.Enabled = true;
                btnVerTripulante.Enabled = true;
                cbbAgregarComo.Enabled = true;
                btnAgregarTripu.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("El numero de vuelo solo puede contener\n digitos numericos enteros");
            }
            
        }

        private void btnVerTripulante_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable infoTrip = new DataTable();
                infoTrip = trip.CargarTripulante(txtDocTripulante.Text);
                lblNomTrip.Text = infoTrip.Rows[0][0].ToString() + infoTrip.Rows[0][1].ToString();
                lblEstTrip.Text = infoTrip.Rows[0][2].ToString();
                lblPuestoTrip.Text = infoTrip.Rows[0][3].ToString();
                lblTelefono.Text = infoTrip.Rows[0][5].ToString();
                lblEmailTrip.Text = infoTrip.Rows[0][4].ToString();
                lblCiuEmp.Text = infoTrip.Rows[0][6].ToString();
            }
            catch(Exception)
            {

            }
            
        }

        private void btnAgregarTripu_Click(object sender, EventArgs e)
        {
            trip.AgregarTripulanteAvuelo(txtDocTripulante.Text, Convert.ToInt32(txtNumVuelo.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nuevoVuelo_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        
    }
}
