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
    public partial class FormEmpleadosInformes : Form
    {
        CnSesion sesion = new CnSesion();
        CnRegistros registro = new CnRegistros();
        public FormEmpleadosInformes(CnSesion usuario)
        {
            InitializeComponent();
            this.sesion = usuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtComentarios.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                registro.generarRegistroEmpleado(txtComentarios.Text, sesion.documento);
            }
            
        }
    }
}
