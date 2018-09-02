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
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            CnModificarUsuario modificarUsuario = new CnModificarUsuario();
            DataTable informacion = modificarUsuario.cargarDatos(txtDocumento.Text);
            if(informacion.Rows.Count>0)
            {
                txtNombres.Text = informacion.Rows[0]["nombres"].ToString();
                txtApellidos.Text = informacion.Rows[0]["apellidos"].ToString();
                txtDoc.Text = informacion.Rows[0]["documento"].ToString();
                cbbTipoDoc.Text = informacion.Rows[0]["tipoDocumento"].ToString();
                dtpNacimiento.Text = informacion.Rows[0]["fechaNacimiento"].ToString();
                cbbTipoContra.Text = informacion.Rows[0]["tipoContrato"].ToString();
                txtPuesto.Text = informacion.Rows[0]["puesto"].ToString();
                txtSueldo.Text = informacion.Rows[0]["sueldo"].ToString();
                txtCuenta.Text = informacion.Rows[0]["cuenta"].ToString();
                cbbTipoCuenta.Text = informacion.Rows[0]["tipoCuenta"].ToString();
                cbbBanco.Text = informacion.Rows[0]["banco"].ToString();
                txtEPS.Text = informacion.Rows[0]["EPS"].ToString();
                txtDireccion.Text = informacion.Rows[0]["direccion"].ToString();
                txtEmail.Text = informacion.Rows[0]["email"].ToString();
                txtTelefono.Text = informacion.Rows[0]["telefono"].ToString();
                txtCiudad.Text = informacion.Rows[0]["ciudad"].ToString();
                txtInfo.Text = informacion.Rows[0]["infoAdicional"].ToString();
                txtUsuario.Text = informacion.Rows[0]["usuario"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontraron usuarios con este documento");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }
    }
}
