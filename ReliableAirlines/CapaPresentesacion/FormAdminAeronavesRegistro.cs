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
    public partial class FormAdminAeronavesRegistro : Form
    {
        CnAeronaves aeronave = new CnAeronaves();
        public FormAdminAeronavesRegistro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            aeronave.CrearAeronave(txtMatricula.Text, txtTipo.Text, Convert.ToInt32(txtPclase.Text),
                                   Convert.ToInt32(txtCturista.Text), txtProv.Text, Convert.ToInt32(txtEqui.Text),
                                   dtpAdqui.Text);
            MessageBox.Show("Se ha registrado la nueva aeronave correctamente");
        }
        
    }
}
