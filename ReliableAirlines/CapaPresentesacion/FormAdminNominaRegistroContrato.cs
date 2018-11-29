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
    public partial class FormAdminNominaRegistroContrato : Form
    {
        CnAdministracionUsuarios contrato = new CnAdministracionUsuarios();
        string documentoEmpleado;
        public FormAdminNominaRegistroContrato(string doc)
        {
            this.documentoEmpleado = doc;
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                contrato.contratoEmpleado(documentoEmpleado, cbbTipo.Text, txtPuesto.Text, txtSueldo.Text, Int32.Parse(cbbPeriodo.Text), dtpInicio.Text,
                dtpFinal.Text, txtCuenta.Text, cbbTipoCuenta.Text, cbbBanco.Text);

                MessageBox.Show("Contrato creado exitosamente");
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error con la base de datos");
            }
            
        }

    }
}
