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
    public partial class FormContabilidadContactosModificar : Form
    {

        CnContacto contacto = new CnContacto();
        public FormContabilidadContactosModificar()
        {
            InitializeComponent();
            this.dgvNumeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnConsultaContacto_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datos = new DataTable();
                datos = contacto.consultaContacto(txtNIT.Text);

                txtNombre.Text = datos.Rows[0][1].ToString();
                txtDireccion.Text = datos.Rows[0][2].ToString();
                txtCorreo.Text = datos.Rows[0][3].ToString();

                DataTable numeros = new DataTable();
                numeros = contacto.consultaNumeros(txtNIT.Text);

                dgvNumeros.DataSource = numeros;

                txtNombre.Enabled = true;
                txtNumTelefono.Enabled = true;
                txtDireccion.Enabled = true;
                txtCorreo.Enabled = true;
                txtContesta.Enabled = true;

                btnModificarContacto.Enabled = true;
                btnTelefono.Enabled = true;
                btnVerSeleccionado.Enabled = true;
                btnGuardarNumero.Enabled = true;

            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error cargando los datos");
            }
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumTelefono.Text) || string.IsNullOrWhiteSpace(txtContesta.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                try
                {
                    contacto.añadirTelefono(txtNIT.Text, txtNumTelefono.Text, txtContesta.Text);
                    dgvNumeros.DataSource = contacto.consultaNumeros(txtNIT.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al intentar añadir el numero");
                }
            }
            
        }

        private void btnVerSeleccionado_Click(object sender, EventArgs e)
        {
            txtNumTelefono.Text = dgvNumeros.CurrentRow.Cells[2].Value.ToString();
            txtContesta.Text = dgvNumeros.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnGuardarNumero_Click(object sender, EventArgs e)
        {
            try
            {
                contacto.actualizarNumero(Int32.Parse(dgvNumeros.CurrentRow.Cells[0].Value.ToString()), txtNumTelefono.Text, txtContesta.Text);
                dgvNumeros.DataSource = contacto.consultaNumeros(txtNIT.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar modificar el numero" + ex);
            }
            
        }

        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNIT.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                try
                {
                    contacto.modificarContacto(txtNIT.Text, txtNombre.Text, txtDireccion.Text, txtCorreo.Text);
                    MessageBox.Show("Se ha modificado el contacto correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al intentar modificar el contacto" + ex);
                }
            }
            
        }
    }
}
