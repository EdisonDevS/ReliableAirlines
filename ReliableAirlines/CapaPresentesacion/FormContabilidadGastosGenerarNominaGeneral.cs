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
    public partial class FormContabilidadGastosGenerarNominaGeneral : Form
    {
        CnMovimientosFinancieros mov = new CnMovimientosFinancieros();

        public FormContabilidadGastosGenerarNominaGeneral()
        {
            InitializeComponent();
        }

        private void btnPagoGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                mov.generarPago();
                MessageBox.Show("Se ha generado el pago correctamente");
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error con la base de datos");
            }
            
        }
    }
}
