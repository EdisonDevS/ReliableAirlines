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

namespace CapaPresentesacion
{
    public partial class FormContabilidadGastosConsultarNomina : Form
    {
        CnMovimientosFinancieros mov = new CnMovimientosFinancieros();
        DataTable datos = new DataTable();

        public FormContabilidadGastosConsultarNomina()
        {
            InitializeComponent();
            this.dgvPagosRealizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable data = new DataTable();
            data = mov.consultarPagosRealizados();
            dgvPagosRealizados.DataSource = data;
        }

        private void btnVerTodosLosPagos_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                data = mov.consultarPagosRealizados();
                dgvPagosRealizados.DataSource = data;
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error cargando los datos");
            }
        }

        private void btnVerPagosEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                data = mov.consultarPagosRealizados(txtDocumento.Text);
                dgvPagosRealizados.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error cargando los datos");
            }
        }

        private void dgvPagosRealizados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNombre.Text = "Nombres: ";
            lblApellidos.Text = "Apellidos: ";
            lblDocumento.Text = "Documentos: ";
            lblNumeroContrato.Text = "Número de contrato: ";
            lblSueldo.Text = "Sueldo/Hora: ";
            lblTotal.Text = "Total a pagar: ";
            lblHoras.Text = "Horas Extra: ";
            lblDias.Text = "Días laborados: ";
            datos = mov.consultarDatosPagoRealizado(Int32.Parse(dgvPagosRealizados.CurrentRow.Cells[4].Value.ToString()));
            lblNombre.Text += datos.Rows[0][0].ToString();
            lblApellidos.Text += datos.Rows[0][1].ToString();
            lblDocumento.Text += datos.Rows[0][2].ToString();
            lblNumeroContrato.Text += datos.Rows[0][3].ToString();
            lblSueldo.Text += datos.Rows[0][4].ToString();
            lblDias.Text += datos.Rows[0][5].ToString();
            lblHoras.Text += datos.Rows[0][6].ToString();
            lblTotal.Text += datos.Rows[0][7].ToString();
        }
    }
}
