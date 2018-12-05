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
            lblInfo.Text += documentoEmpleado;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCuenta.Text) || string.IsNullOrWhiteSpace(txtPuesto.Text) || string.IsNullOrWhiteSpace(txtSueldo.Text) ||
                string.IsNullOrWhiteSpace(cbbBanco.Text) || string.IsNullOrWhiteSpace(cbbTipo.Text) || string.IsNullOrWhiteSpace(cbbTipoCuenta.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                try
                {
                    contrato.contratoEmpleado(documentoEmpleado, cbbTipo.Text, txtPuesto.Text, txtSueldo.Text, dtpInicio.Text,
                    dtpFinal.Text, txtCuenta.Text, cbbTipoCuenta.Text, cbbBanco.Text);

                    MessageBox.Show("Contrato creado exitosamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error con la base de datos");
                }
            }
            
            
        }

    }
}
