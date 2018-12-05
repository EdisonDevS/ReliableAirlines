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
            DataTable ciudades = new DataTable();
            CnAdministracionUsuarios cargar = new CnAdministracionUsuarios();
            ciudades = cargar.CargarCiudades();
            cbbCiudades.DataSource = ciudades;
            cbbCiudades.ValueMember = "id";
            cbbCiudades.DisplayMember = "nombre";

        }

        private void ReemplazarForm(object formulario)
        {
            if (this.Controls.Count > 0)
                this.Controls.RemoveAt(0);

            Form hijo = formulario as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.Controls.Add(hijo);
            this.Tag = hijo;
            hijo.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEPS.Text) ||
                string.IsNullOrWhiteSpace(txtInfoAdicional.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtVerificaContraseña.Text) || string.IsNullOrWhiteSpace(dtpNacimiento.Text) ||
                string.IsNullOrWhiteSpace(cbbCiudades.Text) || string.IsNullOrWhiteSpace(cbbEstado.Text) || string.IsNullOrWhiteSpace(cbbTipoDoc.Text) ||
                string.IsNullOrWhiteSpace(cbbTipoUsuario.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                CnAdministracionUsuarios registrar = new CnAdministracionUsuarios();
                if (txtVerificaContraseña.Text == txtContraseña.Text)
                {
                    registrar.registro(txtDocumento.Text, cbbTipoDoc.Text, txtUsuario.Text, txtContraseña.Text,
                    cbbTipoUsuario.Text, txtNombres.Text, txtApellidos.Text, dtpNacimiento.Text, txtEmail.Text,
                    txtTelefono.Text, txtEPS.Text, txtDireccion.Text, Convert.ToInt32(cbbCiudades.SelectedValue), txtInfoAdicional.Text,
                    cbbEstado.Text);

                    MessageBox.Show("Se ha creado el nuevo usuario correctamente\nPuede proceder a establecer los terminos del contrato");

                    label1.Hide();
                    label11.Hide();
                    label12.Hide();
                    label13.Hide();
                    label14.Hide();
                    label15.Hide();
                    label16.Hide();
                    label17.Hide();
                    label18.Hide();
                    label19.Hide();
                    label2.Hide();
                    label20.Hide();
                    label21.Hide();
                    label22.Hide();
                    label3.Hide();
                    label4.Hide();
                    txtApellidos.Hide();
                    txtContraseña.Hide();
                    txtDireccion.Hide();
                    txtDocumento.Hide();
                    txtEmail.Hide();
                    txtEPS.Hide();
                    txtInfoAdicional.Hide();
                    txtNombres.Hide();
                    txtTelefono.Hide();
                    txtUsuario.Hide();
                    txtVerificaContraseña.Hide();
                    dtpNacimiento.Hide();
                    btnRegistrar.Hide();
                    cbbCiudades.Hide();
                    cbbEstado.Hide();
                    cbbTipoDoc.Hide();
                    cbbTipoUsuario.Hide();
                    ReemplazarForm(new FormAdminNominaRegistroContrato(txtDocumento.Text));
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
            }
            
            
        }


        private void registroEmpleado_Load(object sender, EventArgs e)
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
