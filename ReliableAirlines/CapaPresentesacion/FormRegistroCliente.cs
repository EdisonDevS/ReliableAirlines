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
    public partial class FormRegistroCliente : Form
    {
        public FormRegistroCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(cbbTipoDoc.Text) || string.IsNullOrWhiteSpace(txtVerificaContraseña.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                CnAdministracionUsuarios registrar = new CnAdministracionUsuarios();

                registrar.registro(txtDocumento.Text, cbbTipoDoc.Text, txtUsuario.Text, txtContraseña.Text, "5", txtNombres.Text,
                    txtApellidos.Text, dtpNacimiento.Text, txtEmail.Text, txtTelefono.Text);

                MessageBox.Show("Se ha añadido el nuevo usuario correctamente");
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        
    }
}
