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
    public partial class FormAdminNominaConsultaAjuste : Form
    {
        CnAdministracionUsuarios empleado = new CnAdministracionUsuarios();
        public FormAdminNominaConsultaAjuste()
        {
            InitializeComponent();
        }

        private void reemplazarFormulario(object formulario)
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor digite el documento a buscar");
            }
            else
            {
                if (empleado.verificarDocumento(txtDocumento.Text))
                {
                    btnVer.Hide();
                    txtDocumento.Hide();
                    label16.Hide();
                    reemplazarFormulario(new FormAdminNominaRegistroContrato(txtDocumento.Text));
                }
                else
                {
                    MessageBox.Show("Este documento no se encuentra registrado en la base de datos como un usuario");
                }
            }

        }
    }
}
