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
    public partial class FormContabilidadGastosIngresosGenerarExternos : Form
    {
        int tipoMovimiento;
        CnContacto contactos = new CnContacto();
        CnMovimientosFinancieros mov = new CnMovimientosFinancieros();
        public FormContabilidadGastosIngresosGenerarExternos(int tipo)
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

                //Facturación

                DatosGastoIngresoExterno datos = new DatosGastoIngresoExterno();
                ReporteGastoIngresoExterno reporte = new ReporteGastoIngresoExterno();

                datos.Contacto = cbbReceptor.Text;
                datos.NIT = cbbReceptor.SelectedValue.ToString();

                if (tipoMovimiento == 1)
                    datos.Tipo = "Ingreso";
                else
                    datos.Tipo = "Gasto";

                datos.Fecha = dtpFechaGasto.Text;
                datos.Descripcion = txtDescripcionGasto.Text;
                datos.Valor = txtValorGasto.Text;

                reporte.gastoIngresoExternos.Add(datos);
                reporte.ShowDialog();
            }
           catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar ingresar el gasto"+ex);
            }
        }
    }
}
