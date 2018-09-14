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
    public partial class FormCrearCiudad : Form
    {
        CnCiudadesAeropuertos consultas = new CnCiudadesAeropuertos();

        public FormCrearCiudad()
        {
            InitializeComponent();

            DataTable paises = new DataTable();
            paises = consultas.ConsultarPaises();

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
            int pais = Int32.Parse(cbbEstPais.SelectedValue.ToString());
            consultas.CrearEstado(pais, txtEstado.Text);
        }

        private void btnCrearCiudad_Click(object sender, EventArgs e)
        {
            int pais = Int32.Parse(cbbCiuPais.SelectedValue.ToString());
            int estado = Int32.Parse(cbbCiuEstado.SelectedValue.ToString());
            consultas.CrearCiudad(pais, estado, txtCiudad.Text);
        }

        private void btnCrearAeropuerto_Click(object sender, EventArgs e)
        {
            int ciudad = Int32.Parse(cbbAerCiudad.SelectedValue.ToString());
            consultas.CrearAeropuerto(ciudad, txtAeropuerto.Text);
        }

    }
}
