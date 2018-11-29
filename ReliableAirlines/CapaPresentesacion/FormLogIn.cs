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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CnSesion autorizacion = new CnSesion();
            if(autorizacion.iniciarSesion(txtUser.Text, txtPass.Text))
            {
                switch (autorizacion.permisos[0])
                {
                    case '1':
                        this.Hide();
                        CnMovimientosFinancieros pagos = new CnMovimientosFinancieros();
                        pagos.generarPagosPendientes();
                        FormVistaPrincipalAdmin admin = new FormVistaPrincipalAdmin();
                        admin.Show();
                        break;
                    case '2':
                        this.Hide();
                        FormVistaPrincipalCaja caja = new FormVistaPrincipalCaja();
                        caja.Show();
                        break;
                    case '3':
                        this.Hide();
                        FormVistaPrincipalTripulante tripu = new FormVistaPrincipalTripulante();
                        tripu.Show();
                        break;
                    case '4':
                        this.Hide();
                        FormVistaPrincipalEmpleados emple = new FormVistaPrincipalEmpleados();
                        emple.Show();
                        break;
                    case '5':
                        this.Hide();
                        FormVistaPrincipalCliente clien = new FormVistaPrincipalCliente(autorizacion);
                        clien.Show();
                        break;
                }
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormRegistroCliente registro = new FormRegistroCliente();
            registro.Show();
        }
    }
}
