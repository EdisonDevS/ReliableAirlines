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
    public partial class FormAdminNominaRegistro : Form
    {
        public FormAdminNominaRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CnRegistroUsuario registrar = new CnRegistroUsuario();
            if(txtVerificaContraseña.Text==txtContraseña.Text)
            {
                registrar.registro(txtDocumento.Text, cbbTipoDoc.Text, txtUsuario.Text, txtContraseña.Text,
                cbbTipoUsuario.Text, txtNombres.Text, txtApellidos.Text, dtpNacimiento.Text, txtEmail.Text,
                txtTelefono.Text, cbbTipoContra.Text, txtPuesto.Text, txtCuenta.Text, cbbTipoCuenta.Text,
                cbbBanco.Text, txtEPS.Text, txtDireccion.Text, txtCiudad.Text, txtInfoAdicional.Text,txtSueldo.Text);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }
            
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void registroEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
