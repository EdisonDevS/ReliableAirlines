using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentesacion
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "1234")
            {
                this.Hide();
                FormVistaPrincipalAdmin admin = new FormVistaPrincipalAdmin();
                admin.Show();
            }

            if (txtUser.Text == "caja" && txtPass.Text == "1234")
            {
                this.Hide();
                FormVistaPrincipalCaja caja = new FormVistaPrincipalCaja();
                caja.Show();
            }
        }
    }
}
