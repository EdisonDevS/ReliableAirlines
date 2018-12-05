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
    public partial class FormContabilidadContactosCrear : Form
    {

        CnContacto contacto = new CnContacto();
        public FormContabilidadContactosCrear()
        {
            InitializeComponent();
            this.dgvNumeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCrearContacto_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNIT.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                try
                {
                    contacto.crearContacto(txtNIT.Text, txtNombre.Text, txtDireccion.Text, txtCorreo.Text);
                    txtNumTelefono.Enabled = true;
                    txtContesta.Enabled = true;
                    btnTelefono.Enabled = true;
                    txtNIT.Enabled = false;
                    txtNombre.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al intentar crear el contacto");
                }
            }
            
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNumTelefono.Text) || string.IsNullOrWhiteSpace(txtContesta.Text))
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
    }
}
