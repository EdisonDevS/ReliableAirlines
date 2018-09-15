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
    public partial class FormCrearRuta : Form
    {
        CnCiudadesAeropuertos consultas = new CnCiudadesAeropuertos();
        public FormCrearRuta()
        {
            InitializeComponent();
        }

        private void btnAgragarCiudad_Click(object sender, EventArgs e)
        {
            FormCrearLocacion ciudad = new FormCrearLocacion();
            ciudad.Show();
        }

        private void FormCrearRuta_Load(object sender, EventArgs e)
        {
            DataTable tablaPaisOrigen = new DataTable();
            tablaPaisOrigen = consultas.ConsultarPaises();
            cbbPaisOrigen.DataSource = tablaPaisOrigen;
            cbbPaisOrigen.DisplayMember = "nombre";
            cbbPaisOrigen.ValueMember = "id";

            DataTable tablaEstOrigen = new DataTable();
            tablaEstOrigen = consultas.ConsultarEstados(Convert.ToInt32(cbbPaisOrigen.SelectedValue));
            cbbEstadoOrigen.DataSource = tablaEstOrigen;
            cbbEstadoOrigen.DisplayMember = "nombre";
            cbbEstadoOrigen.ValueMember = "id";

            DataTable tablaCiuOrigen = new DataTable();
            tablaCiuOrigen = consultas.ConsultarCiudades(Convert.ToInt32(cbbEstadoOrigen.SelectedValue));
            cbbCiudadOrigen.DataSource = tablaCiuOrigen;
            cbbCiudadOrigen.DisplayMember = "nombre";
            cbbCiudadOrigen.ValueMember = "id";

            DataTable tablaAerOrigen = new DataTable();
            tablaAerOrigen = consultas.ConsultarAeropuertos(Convert.ToInt32(cbbCiudadOrigen.SelectedValue));
            cbbAerOrigen.DataSource = tablaAerOrigen;
            cbbAerOrigen.DisplayMember = "nombre";
            cbbAerOrigen.ValueMember = "idAeropuerto";

            DataTable tablaPaisDestino = new DataTable();
            tablaPaisDestino = consultas.ConsultarPaises();
            cbbPaisDestino.DataSource = tablaPaisDestino;
            cbbPaisDestino.DisplayMember = "nombre";
            cbbPaisDestino.ValueMember = "id";

            DataTable tablaEstDestino = new DataTable();
            tablaEstDestino = consultas.ConsultarEstados(Convert.ToInt32(cbbPaisDestino.SelectedValue));
            cbbEstadoDestino.DataSource = tablaEstDestino;
            cbbEstadoDestino.DisplayMember = "nombre";
            cbbEstadoDestino.ValueMember = "id";

            DataTable tablaCiuDestino = new DataTable();
            tablaCiuDestino = consultas.ConsultarCiudades(Convert.ToInt32(cbbEstadoDestino.SelectedValue));
            cbbCiudadDestino.DataSource = tablaCiuDestino;
            cbbCiudadDestino.DisplayMember = "nombre";
            cbbCiudadDestino.ValueMember = "id";

            DataTable tablaAerDestino = new DataTable();
            tablaAerDestino = consultas.ConsultarAeropuertos(Convert.ToInt32(cbbCiudadDestino.SelectedValue));
            cbbAerDestino.DataSource = tablaAerDestino;
            cbbAerDestino.DisplayMember = "nombre";
            cbbAerDestino.ValueMember = "idAeropuerto";
        }

        private void cbbPaisOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbEstadoOrigen.Text = "";
            cbbCiudadOrigen.Text = "";
            cbbAerOrigen.Text = "";

            try
            {
                DataTable tablaEstOrigen = new DataTable();
                tablaEstOrigen = consultas.ConsultarEstados(Convert.ToInt32(cbbPaisOrigen.SelectedValue));
                cbbEstadoOrigen.DataSource = tablaEstOrigen;
                cbbEstadoOrigen.DisplayMember = "nombre";
                cbbEstadoOrigen.ValueMember = "id";
            }
            catch(Exception)
            {

            }
        }

        private void cbbEstadoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCiudadOrigen.Text = "";
            cbbAerOrigen.Text = "";

            try
            {
                DataTable tablaCiuOrigen = new DataTable();
                tablaCiuOrigen = consultas.ConsultarCiudades(Convert.ToInt32(cbbEstadoOrigen.SelectedValue));
                cbbCiudadOrigen.DataSource = tablaCiuOrigen;
                cbbCiudadOrigen.DisplayMember = "nombre";
                cbbCiudadOrigen.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbCiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbAerOrigen.Text = "";

            try
            {
                DataTable tablaAerOrigen = new DataTable();
                tablaAerOrigen = consultas.ConsultarAeropuertos(Convert.ToInt32(cbbCiudadOrigen.SelectedValue));
                cbbAerOrigen.DataSource = tablaAerOrigen;
                cbbAerOrigen.DisplayMember = "nombre";
                cbbAerOrigen.ValueMember = "idAeropuerto";
            }
            catch(Exception)
            {

            }
        }

        private void cbbPaisDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbEstadoDestino.Text = "";
            cbbCiudadDestino.Text = "";
            cbbAerDestino.Text = "";

            try
            {
                DataTable tablaEstDestino = new DataTable();
                tablaEstDestino = consultas.ConsultarEstados(Convert.ToInt32(cbbPaisDestino.SelectedValue));
                cbbEstadoDestino.DataSource = tablaEstDestino;
                cbbEstadoDestino.DisplayMember = "nombre";
                cbbEstadoDestino.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbEstadoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCiudadDestino.Text = "";
            cbbAerDestino.Text = "";

            try
            {
                DataTable tablaCiuDestino = new DataTable();
                tablaCiuDestino = consultas.ConsultarCiudades(Convert.ToInt32(cbbEstadoDestino.SelectedValue));
                cbbCiudadDestino.DataSource = tablaCiuDestino;
                cbbCiudadDestino.DisplayMember = "nombre";
                cbbCiudadDestino.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbCiudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbAerDestino.Text = "";

            try
            {
                DataTable tablaAerDestino = new DataTable();
                tablaAerDestino = consultas.ConsultarAeropuertos(Convert.ToInt32(cbbCiudadDestino.SelectedValue));
                cbbAerDestino.DataSource = tablaAerDestino;
                cbbAerDestino.DisplayMember = "nombre";
                cbbAerDestino.ValueMember = "idAeropuerto";
            }
            catch (Exception)
            {

            }
        }

        private void btnCrearRuta_Click(object sender, EventArgs e)
        {

        }
    }
}
