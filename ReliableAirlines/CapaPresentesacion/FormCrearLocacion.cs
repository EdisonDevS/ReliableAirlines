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
using System.Data.SqlClient;

namespace CapaPresentesacion
{
    public partial class FormCrearLocacion : Form
    {
        CnCiudadesAeropuertos consultas = new CnCiudadesAeropuertos();

        public FormCrearLocacion()
        {
            InitializeComponent();
        }

        private void btnCrearPais_Click(object sender, EventArgs e)
        {
            consultas.CrearPais(txtPais.Text);
            MessageBox.Show("Pais creado exitosamente");
            txtPais.Clear();
        }

        private void btnCrearEstado_Click(object sender, EventArgs e)
        {
            int pais = Convert.ToInt32(cbbEstPais.SelectedValue);
            consultas.CrearEstado(pais, txtEstado.Text);
            MessageBox.Show("Estado creado exitosamente");
            txtEstado.Clear();
        }

        private void btnCrearCiudad_Click(object sender, EventArgs e)
        {
            int estado = Convert.ToInt32(cbbCiuEstado.SelectedValue);
            consultas.CrearCiudad(estado, txtCiudad.Text);
            MessageBox.Show("Ciudad creada exitosamente");
            txtCiudad.Clear();
        }

        private void btnCrearAeropuerto_Click(object sender, EventArgs e)
        {
            int ciudad = Convert.ToInt32(cbbAerCiudad.SelectedValue);
            consultas.CrearAeropuerto(ciudad, txtAeropuerto.Text);
            MessageBox.Show("Aeropuerto creado exitosamente");
            txtAeropuerto.Clear();
        }

        private void rbPais_CheckedChanged(object sender, EventArgs e)
        {
            txtPais.Enabled = true;
            btnCrearPais.Enabled = true;
            cbbEstPais.Enabled = false;
            txtEstado.Enabled = false;
            btnCrearEstado.Enabled = false;
            cbbCiuPais.Enabled = false;
            cbbCiuEstado.Enabled = false;
            txtCiudad.Enabled = false;
            btnCrearCiudad.Enabled = false;
            cbbAerPais.Enabled = false;
            cbbAerEstado.Enabled = false;
            cbbAerCiudad.Enabled = false;
            txtAeropuerto.Enabled = false;
            btnCrearAeropuerto.Enabled = false;
        }

        private void rbEstado_CheckedChanged(object sender, EventArgs e)
        {
            DataTable paises = new DataTable();

            paises = consultas.ConsultarPaises();
            cbbEstPais.DataSource = paises;
            cbbEstPais.DisplayMember = "nombre";
            cbbEstPais.ValueMember = "id";

            txtPais.Enabled = false;
            btnCrearPais.Enabled = false;
            cbbEstPais.Enabled = true;
            txtEstado.Enabled = true;
            btnCrearEstado.Enabled = true;
            cbbCiuPais.Enabled = false;
            cbbCiuEstado.Enabled = false;
            txtCiudad.Enabled = false;
            btnCrearCiudad.Enabled = false;
            cbbAerPais.Enabled = false;
            cbbAerEstado.Enabled = false;
            cbbAerCiudad.Enabled = false;
            txtAeropuerto.Enabled = false;
            btnCrearAeropuerto.Enabled = false;
        }

        private void rbCiudad_CheckedChanged(object sender, EventArgs e)
        {
            DataTable paises = new DataTable();
            paises = consultas.ConsultarPaises();
            cbbCiuPais.DataSource = paises;
            cbbCiuPais.DisplayMember = "nombre";
            cbbCiuPais.ValueMember = "id";

            DataTable tablaCiuEst = new DataTable();
            tablaCiuEst = consultas.ConsultarEstados(Convert.ToInt32(cbbCiuPais.SelectedValue));
            cbbCiuEstado.DataSource = tablaCiuEst;
            cbbCiuEstado.DisplayMember = "nombre";
            cbbCiuEstado.ValueMember = "id";

            txtPais.Enabled = false;
            btnCrearPais.Enabled = false;
            cbbEstPais.Enabled = false;
            txtEstado.Enabled = false;
            btnCrearEstado.Enabled = false;
            cbbCiuPais.Enabled = true;
            cbbCiuEstado.Enabled = true;
            txtCiudad.Enabled = true;
            btnCrearCiudad.Enabled = true;
            cbbAerPais.Enabled = false;
            cbbAerEstado.Enabled = false;
            cbbAerCiudad.Enabled = false;
            txtAeropuerto.Enabled = false;
            btnCrearAeropuerto.Enabled = false;
        }

        private void rbAeropuerto_CheckedChanged(object sender, EventArgs e)
        {
            DataTable paises = new DataTable();
            paises = consultas.ConsultarPaises();
            cbbAerPais.DataSource = paises;
            cbbAerPais.DisplayMember = "nombre";
            cbbAerPais.ValueMember = "id";

            DataTable tablaAerEst = new DataTable();
            tablaAerEst = consultas.ConsultarEstados(Convert.ToInt32(cbbAerEstado.SelectedValue));
            cbbAerEstado.DataSource = tablaAerEst;
            cbbAerEstado.DisplayMember = "nombre";
            cbbAerEstado.ValueMember = "id";

            DataTable tablaAerCiu = new DataTable();
            tablaAerCiu = consultas.ConsultarPaises();
            cbbAerPais.DataSource = tablaAerCiu;
            cbbAerPais.DisplayMember = "nombre";
            cbbAerPais.ValueMember = "id";

            txtPais.Enabled = false;
            btnCrearPais.Enabled = false;
            cbbEstPais.Enabled = false;
            txtEstado.Enabled = false;
            btnCrearEstado.Enabled = false;
            cbbCiuPais.Enabled = false;
            cbbCiuEstado.Enabled = false;
            txtCiudad.Enabled = false;
            btnCrearCiudad.Enabled = false;
            cbbAerPais.Enabled = true;
            cbbAerEstado.Enabled = true;
            cbbAerCiudad.Enabled = true;
            txtAeropuerto.Enabled = true;
            btnCrearAeropuerto.Enabled = true;
        }

        private void cbbCiuPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCiuEstado.Text = "";

            try
            {
                DataTable tablaCiuEst = new DataTable();
                tablaCiuEst = consultas.ConsultarEstados(Convert.ToInt32(cbbCiuPais.SelectedValue));
                cbbCiuEstado.DataSource = tablaCiuEst;
                cbbCiuEstado.DisplayMember = "nombre";
                cbbCiuEstado.ValueMember = "id";
            }
            catch(Exception)
            {

            }
            
        }

        private void cbbAerPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbAerEstado.Text = "";
            try
            {
                DataTable tablaAerEst = new DataTable();
                tablaAerEst = consultas.ConsultarEstados(Convert.ToInt32(cbbAerPais.SelectedValue));
                cbbAerEstado.DataSource = tablaAerEst;
                cbbAerEstado.DisplayMember = "nombre";
                cbbAerEstado.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }

        private void cbbAerEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbAerCiudad.Text = "";
            try
            {
                DataTable tablaAerCiu = new DataTable();
                tablaAerCiu = consultas.ConsultarCiudades(Convert.ToInt32(cbbAerEstado.SelectedValue));
                cbbAerCiudad.DataSource = tablaAerCiu;
                cbbAerCiudad.DisplayMember = "nombre";
                cbbAerCiudad.ValueMember = "id";
            }
            catch (Exception)
            {

            }
        }
    }
}
