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
    public partial class FormMiCuenta : Form
    {
        CnSesion sesion = new CnSesion();
        CnAdministracionUsuarios usuarios = new CnAdministracionUsuarios();
        public FormMiCuenta(CnSesion datosUsuario)
        {
            InitializeComponent();
            this.sesion = datosUsuario;
            DataTable datos = new DataTable();
            datos = usuarios.cargarDatosUsuario(sesion.documento);
            lblUsuario.Text += datos.Rows[0][0].ToString();
            lblNombre.Text += datos.Rows[0][1].ToString();
            lblApellido.Text += datos.Rows[0][2].ToString();
            lblDocumento.Text += datos.Rows[0][3].ToString() + " " + datos.Rows[0][4].ToString();
            lblNacimiento.Text += datos.Rows[0][5].ToString();
            lblTelefono.Text += datos.Rows[0][6].ToString();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtVerificar.Text)
            {
                usuarios.cambiarContraseña(txtContraseña.Text, sesion.documento);
                MessageBox.Show("Contraseña actualizada correctamente");
            }
            else
                MessageBox.Show("Las contraseñas no coinciden");

        }
    }
}
