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
    public partial class FormContabilidadGastosGenerarOtros : Form
    {
        CnContacto contactos = new CnContacto();
        CnMovimientosFinancieros mov = new CnMovimientosFinancieros();
        public FormContabilidadGastosGenerarOtros()
        {
            InitializeComponent();
            cbbReceptor.DataSource = contactos.consultaGralContactos();
            cbbReceptor.ValueMember = "nit";
            cbbReceptor.DisplayMember = "nombre";
        }

        private void btnGenerarGasto_Click(object sender, EventArgs e)
        {
            mov.nuevoMovimiento(txtDescripcionGasto.Text, txtValorGasto.Text, cbbReceptor.SelectedValue.ToString(), 2);
        }
    }
}
