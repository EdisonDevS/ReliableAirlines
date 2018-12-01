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
    public partial class FormContabilidadGastosIngresosConsultarExternos : Form
    {
        CnMovimientosFinancieros mov = new CnMovimientosFinancieros();
        int tipoMovimiento = 0;
        public FormContabilidadGastosIngresosConsultarExternos(int tipo)
        {
            InitializeComponent();
            this.tipoMovimiento = tipo;
            this.dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataTable datos = new DataTable();
            datos = mov.consultarMovimientosExternos(tipoMovimiento, dtpDesde.Text, dtpHasta.Text);
            dgvDatos.DataSource = datos;
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblContacto.Text = "Contacto: ";
            lblNit.Text = "Nit: ";
            lblValor.Text = "Valor: ";

            txtDescripcion.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
            dtpFecha.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
            lblContacto.Text += dgvDatos.CurrentRow.Cells[2].Value.ToString();
            lblNit.Text += dgvDatos.CurrentRow.Cells[3].Value.ToString();
            lblValor.Text += dgvDatos.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
