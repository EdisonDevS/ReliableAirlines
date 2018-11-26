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
    public partial class FormContabilidadGastosIngresosGenerarOtros : Form
    {
        int tipoMovimiento;
        CnContacto contactos = new CnContacto();
        CnMovimientosFinancieros mov = new CnMovimientosFinancieros();
        public FormContabilidadGastosIngresosGenerarOtros(int tipo)
        {
            InitializeComponent();
            this.tipoMovimiento = tipo;

            if (tipoMovimiento==1)
            {
                lblFuente.Text = "Fuente: ";
                btnGenerar.Text = "Generar ingreso";
            }

            cbbReceptor.DataSource = contactos.consultaGralContactos();
            cbbReceptor.ValueMember = "nit";
            cbbReceptor.DisplayMember = "nombre";
        }

        private void btnGenerarGasto_Click(object sender, EventArgs e)
        {
            try
            {
                mov.nuevoMovimiento(txtDescripcionGasto.Text, txtValorGasto.Text, cbbReceptor.SelectedValue.ToString(), tipoMovimiento, dtpFechaGasto.Text);
                MessageBox.Show("Gasto ingresado correctamente");
            }
           catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar ingresar el gasto");
            }
        }
    }
}
