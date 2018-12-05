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
    public partial class FormCambioContraseña : Form
    {
        CnAdministracionUsuarios usuarios = new CnAdministracionUsuarios();
        string documento;
        public FormCambioContraseña(string doc)
        {
            InitializeComponent();
            this.documento = doc;
            lblDocumento.Text += documento;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtVerificar.Text)
            {
                usuarios.cambiarContraseña(txtContraseña.Text, documento);
                MessageBox.Show("Contraseña actualizada correctamente");
            }
            else
                MessageBox.Show("Las contraseñas no coinciden");
        }
    }
}
