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

            DataTable paises = new DataTable();
            try
            {
                paises = consultas.ConsultarPaises();
            }
            catch
            {

            }

            cbbEstPais.DataSource = paises;
            cbbEstPais.DisplayMember = "nombre";
            cbbEstPais.ValueMember = "id";

            cbbCiuPais.DataSource = paises;
            cbbCiuPais.DisplayMember = "nombre";
            cbbCiuPais.ValueMember = "id";

            cbbAerPais.DataSource = paises;
            cbbAerPais.DisplayMember = "nombre";
            cbbAerPais.ValueMember = "id";
        }

        private void btnCrearPais_Click(object sender, EventArgs e)
        {
            consultas.CrearPais(txtPais.Text);
        }

        private void btnCrearEstado_Click(object sender, EventArgs e)
        {
            int pais = Convert.ToInt32(cbbEstPais.SelectedValue);
            consultas.CrearEstado(pais, txtEstado.Text);
        }

        private void btnCrearCiudad_Click(object sender, EventArgs e)
        {
            int pais = Convert.ToInt32(cbbCiuPais.SelectedValue);
            int estado = Convert.ToInt32(cbbCiuEstado.SelectedValue);
            consultas.CrearCiudad(pais, estado, txtCiudad.Text);
        }

        private void btnCrearAeropuerto_Click(object sender, EventArgs e)
        {
            int ciudad = Convert.ToInt32(cbbAerCiudad.SelectedValue);
            consultas.CrearAeropuerto(ciudad, txtAeropuerto.Text);
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
    }
}
