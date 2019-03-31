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
    public partial class FormAdminInformesEmpleados : Form
    {
        CnRegistros registro = new CnRegistros();
        public FormAdminInformesEmpleados()
        {
            InitializeComponent();
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable datos = new DataTable();
            datos = registro.consultaInformesEmpleados();
            dgvDatos.DataSource = datos;
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNombres.Text = "Nombres y apellidos: ";
            lblIdentificacion.Text = "Identificación: ";

            lblNombres.Text += dgvDatos.CurrentRow.Cells[0].Value.ToString() + " " + dgvDatos.CurrentRow.Cells[1].Value.ToString();
            lblIdentificacion.Text += dgvDatos.CurrentRow.Cells[2].Value.ToString();
            dtpFecha.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
            txtInforme.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();

        }

        private void FormAdminInformesEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
