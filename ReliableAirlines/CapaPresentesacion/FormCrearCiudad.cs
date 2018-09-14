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
    public partial class FormCrearCiudad : Form
    {
        CnCiudadesAeropuertos crear = new CnCiudadesAeropuertos();

        public FormCrearCiudad()
        {
            InitializeComponent();
        }

        private void btnCrearPais_Click(object sender, EventArgs e)
        {
            crear.CrearPais(txtPais.Text);
        }

        private void btnCrearEstado_Click(object sender, EventArgs e)
        {
            int pais = Int32.Parse(cbbEstPais.SelectedValue.ToString());
            crear.CrearEstado(pais, txtEstado.Text);
        }

        private void btnCrearCiudad_Click(object sender, EventArgs e)
        {
            int pais = Int32.Parse(cbbCiuPais.SelectedValue.ToString());
            int estado = Int32.Parse(cbbCiuEstado.SelectedValue.ToString());
            crear.CrearCiudad(pais, estado, txtCiudad.Text);
        }

        private void btnCrearAeropuerto_Click(object sender, EventArgs e)
        {
            int ciudad = Int32.Parse(cbbAerCiudad.SelectedValue.ToString());
            crear.CrearAeropuerto(ciudad, txtAeropuerto.Text);
        }
    }
}
