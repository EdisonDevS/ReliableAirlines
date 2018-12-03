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
    public partial class FormContabilidadIngresosConsultarVentas : Form
    {
        CnVentas venta = new CnVentas();
        public FormContabilidadIngresosConsultarVentas()
        {
            InitializeComponent();
            this.dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datos = new DataTable();
                datos = venta.consultarVentas(dtpInicio.Text, dtpFinal.Text);
                dgvVentas.DataSource = datos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido unerror al inentar conectar con la base de datos");
            }
            
        }

    }
}
