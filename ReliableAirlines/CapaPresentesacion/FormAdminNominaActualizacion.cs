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
using System.Data.SqlClient;

namespace CapaPresentesacion
{
    public partial class FormAdminNominaActualizacion : Form
    {
        public FormAdminNominaActualizacion()
        {
            InitializeComponent();
            DataTable ciudades = new DataTable();
            CnAdministracionUsuarios ciudad = new CnAdministracionUsuarios();
            ciudades = ciudad.CargarCiudades();
            cbbCiudades.DataSource = ciudades;
            cbbCiudades.DisplayMember = "nombre";
            cbbCiudades.ValueMember = "id";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor ingrese un numero de documento");
            }
            else
            {
                CnAdministracionUsuarios modificarUsuario = new CnAdministracionUsuarios();
                DataTable informacion = modificarUsuario.cargarDatos(txtDocumento.Text);
                if (informacion.Rows.Count > 0)
                {
                    txtNombres.Text = informacion.Rows[0]["nombres"].ToString();
                    txtApellidos.Text = informacion.Rows[0]["apellidos"].ToString();
                    txtDoc.Text = informacion.Rows[0]["documento"].ToString();
                    cbbTipoDoc.Text = informacion.Rows[0]["tipoDocumento"].ToString();
                    dtpNacimiento.Text = informacion.Rows[0]["fechaNacimiento"].ToString();
                    txtEPS.Text = informacion.Rows[0]["EPS"].ToString();
                    txtDireccion.Text = informacion.Rows[0]["direccion"].ToString();
                    txtEmail.Text = informacion.Rows[0]["email"].ToString();
                    txtTelefono.Text = informacion.Rows[0]["telefono"].ToString();
                    cbbCiudades.SelectedValue = informacion.Rows[0]["ciudad"];
                    txtInfo.Text = informacion.Rows[0]["infoAdicional"].ToString();
                    txtUsuario.Text = informacion.Rows[0]["usuario"].ToString();
                    cbbEstado.Text = informacion.Rows[0]["estado"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios con este documento");
                }
            }
            

        }

        private void btnGuardarCambios_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDoc.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEPS.Text) ||
                string.IsNullOrWhiteSpace(txtInfo.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(cbbCiudades.Text) || string.IsNullOrWhiteSpace(cbbEstado.Text) ||
                string.IsNullOrWhiteSpace(cbbTipoDoc.Text) || string.IsNullOrWhiteSpace(dtpNacimiento.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                CnAdministracionUsuarios modificarUsuario = new CnAdministracionUsuarios();
                modificarUsuario.realizarCambios(txtDoc.Text, cbbTipoDoc.Text, txtUsuario.Text,
                    txtNombres.Text, txtApellidos.Text, dtpNacimiento.Text, txtEmail.Text,
                    txtTelefono.Text, txtEPS.Text, txtDireccion.Text, Convert.ToInt32(cbbCiudades.SelectedValue), txtInfo.Text,
                    cbbEstado.Text);

                MessageBox.Show("Se han modificado los \n" +
                                "datos correctamente.");

            }
        }

        private void btnReestablecerContraseña_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor llene primero el campo del documento");
            }
            else
            {
                FormCambioContraseña contra = new FormCambioContraseña(txtDocumento.Text);
                contra.Show();
            }  
        }
    }
}
